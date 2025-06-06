using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using PasswordManagerAPI.Context;
using PasswordManagerAPI.DTOs.AccountDTO;
using PasswordManagerAPI.Entitys;
using PasswordManagerAPI.Helpers;
using PasswordManagerAPI.Interfaces;
using System.Security.Cryptography;
using System.Text;

namespace PasswordManagerAPI.Services
{
    public class AccountService : IAccountInterface
    {
        private readonly PasswordManagerDbContext _context;
        public AccountService(PasswordManagerDbContext context)
        {
            _context = context;
        }
        public async Task<string> CopyAccountOrignizalPassword(int Id)
        {
            var query = (from a in _context.Accounts
                         where a.Id == Id
                         select new
                         {
                             Pass = a.Password,
                             Nonce = a.PasswordNonce,
                             Tag = a.PasswordTag,
                             Key = a.Key
                         }).FirstOrDefault();
            //Decypt 
            return EncryptionHelper.Decrypt(query.Pass, query.Nonce, query.Tag, query.Key);
        }

        public async Task<string> CreateSreongPassword(int length)
        {
            if (length < 6)
                throw new ArgumentException("Password length should be at least 6 characters.");

            const string upperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowerChars = "abcdefghijklmnopqrstuvwxyz";
            const string digits = "0123456789";
            const string specialChars = "!@#$%^&*()_+-=[]{}|;:,.<>?";

            Random random = new Random();

            // Ensure at least one character from each category
            var password = new StringBuilder()
                .Append(upperChars[random.Next(upperChars.Length)])
                .Append(lowerChars[random.Next(lowerChars.Length)])
                .Append(digits[random.Next(digits.Length)])
                .Append(specialChars[random.Next(specialChars.Length)]);

            // Fill the remaining length with a mix of all characters
            string allChars = upperChars + lowerChars + digits + specialChars;
            for (int i = password.Length; i < length; i++)
            {
                password.Append(allChars[random.Next(allChars.Length)]);
            }

            // Shuffle the password to randomize character order
            return new string(password.ToString().OrderBy(_ => random.Next()).ToArray());
        }

        public async Task<string> CreateUpdateAccount(CreateUpdateAccountInputDTO input)
        {
            // Validate input
            if (input == null)
                throw new ArgumentNullException(nameof(input));

            if (string.IsNullOrWhiteSpace(input.Username))
                throw new ArgumentException("Username is required.");

            if (string.IsNullOrWhiteSpace(input.Password))
                throw new ArgumentException("Password is required.");
            Account account;
            if (input.Id.HasValue)
            {
                // Update existing account
                account = await _context.Accounts.FindAsync(input.Id.Value);
                if (account == null)
                    throw new InvalidOperationException($"Account with ID {input.Id} not found.");

                // Update fields
                account.Title = input.Title ?? account.Title;
                account.Description = input.Description ?? account.Description;

                account.UsernameTypeId = input.UsernameTypeId ?? account.UsernameTypeId;
                account.UserId = input.UserId ?? account.UserId;
                byte[] key = new byte[32];
                RandomNumberGenerator.Fill(key);
                if (input.Username != null)
                {
                    var usernameNew = EncryptionHelper.Encrypt(input.Username, key);
                    account.Username = usernameNew.CipherText;// encryption
                    account.UserNameNonce = usernameNew.Nonce;
                    account.UserNameTag = usernameNew.Tag;
                }
                if (input.Password != null)
                {
                    var passwordNew = EncryptionHelper.Encrypt(input.Password, key);
                    account.Password = passwordNew.CipherText;// encryption
                    account.PasswordNonce = passwordNew.Nonce;
                    account.PasswordTag = passwordNew.Tag;
                }

                account.CategoryId = input.CategoryId ?? account.CategoryId;
                account.ProviderId = input.ProviderId ?? account.ProviderId;

                _context.Accounts.Update(account);
            }
            else
            {
                byte[] key = new byte[32];
                RandomNumberGenerator.Fill(key);

                var usernameNew = EncryptionHelper.Encrypt(input.Username, key);
                var passwordNew = EncryptionHelper.Encrypt(input.Password, key);
                // Create new account
                account = new Account
                {
                    Title = input.Title,
                    Description = input.Description,
                    Username = usernameNew.CipherText,// encryption
                    UserNameNonce = usernameNew.Nonce,
                    UserNameTag = usernameNew.Tag,
                    Password = passwordNew.CipherText,// encryption
                    PasswordNonce = passwordNew.Nonce,
                    PasswordTag = passwordNew.Tag,
                    UsernameTypeId = input.UsernameTypeId ?? throw new ArgumentException("UsernameTypeId is required."),
                    UserId = input.UserId ?? throw new ArgumentException("UserId is required."),
                    CategoryId = input.CategoryId ?? throw new ArgumentException("CategoryId is required."),
                    ProviderId = input.ProviderId
                };

                await _context.Accounts.AddAsync(account);
            }

            // Save changes to the database
            await _context.SaveChangesAsync();

            return input.Id.HasValue ? "Account updated successfully." : "Account created successfully.";
        }

        public async Task<AccountDetailDTO> GetDetailDTO(int Id)
        {
            var query = await _context.Accounts.Where(a => a.Id == Id).Select(x=> new AccountDetailDTO
            {
                Id = x.Id,
                Category = _context.LookupItems.Any(o=> o.Id == x.CategoryId)? _context.LookupItems.FirstOrDefault(o => o.Id == x.CategoryId).Name : "No Category",
                Description = x.Description,
                Title = x.Title,
                Username = x.Username,
                Password = x.Password,
                CreationDate =x.CreationDate.ToShortDateString(),
                ProviderImage = _context.Providers.Any(o => o.Id == x.ProviderId) ? _context.Providers.FirstOrDefault(o => o.Id == x.ProviderId).Image : "No Image",
                ProviderName = _context.Providers.Any(o => o.Id == x.ProviderId) ? _context.Providers.FirstOrDefault(o => o.Id == x.ProviderId).Name : "No Provider Name",
                UpdateDate = x.UpdatedDate == null?"" : ((DateTime)x.UpdatedDate).ToShortDateString(),
                UserNameType = _context.LookupItems.Any(o => o.Id == x.UsernameTypeId) ? _context.LookupItems.FirstOrDefault(o => o.Id == x.UsernameTypeId).Name : "No UsernameTypeId",
            }).FirstOrDefaultAsync();

            return query;
        }

        public async Task<List<AccountDTO>> GetMyAccount(int userId)
        {
            var query = from a in _context.Accounts
                        join p in _context.Providers on a.ProviderId equals p.Id
                        join c in _context.LookupItems on a.CategoryId equals c.Id
                        join ut in _context.LookupItems on a.UsernameTypeId equals ut.Id
                        where a.UserId == userId
                        select new AccountDTO
                        {
                            Id = a.Id,
                            ProviderImage = p.Image,
                            Category = c.Name,
                            ProviderName = p.Name,
                            UserNameType = ut.Name,
                            CreationDate = a.CreationDate.ToShortDateString(),
                            Username = a.Username,
                            Title = a.Title,
                        };

            return await query.ToListAsync();
        }

        public async Task<List<AccountDTO>> SearchAccount(AccountSearchInputDTO input)
        {
            var query = from a in _context.Accounts
                        join p in _context.Providers on a.ProviderId equals p.Id
                        join c in _context.LookupItems on a.CategoryId equals c.Id
                        join ut in _context.LookupItems on a.UsernameTypeId equals ut.Id
                        where a.UserId == input.UserId &&
                        (
                            (input.Name == null || a.Title.Contains(input.Name)) ||
                            (input.ProviderName == null || p.Name.Contains(input.ProviderName)) ||
                            (input.Category == null || c.Name.Contains(input.Category)) 
                        )
                        select new AccountDTO
                        {
                            Id = a.Id,
                            ProviderImage = p.Image,
                            Category = c.Name,
                            ProviderName = p.Name,
                            UserNameType = ut.Name,
                            CreationDate = a.CreationDate.ToShortDateString(),
                            Username = a.Username,
                            Title = a.Title,
                        };

            return await query.ToListAsync();
        }
    }
}
