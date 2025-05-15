using EmailServicePackage;
using EmailServicePackage.Interfaces;
using PasswordManagerAPI.Context;
using PasswordManagerAPI.DTOs.UserAuthenticationDTO;
using PasswordManagerAPI.Entitys;
using PasswordManagerAPI.Helpers;
using PasswordManagerAPI.Interfaces;

namespace PasswordManagerAPI.Services
{
    public class UserAuthenticationService:IUserAuthentication
    {
        private readonly PasswordManagerDbContext _context;
        private readonly ISmtpService _smtpService;
        public UserAuthenticationService(PasswordManagerDbContext context, ISmtpService smtpService)
        {
            _context = context;
            _smtpService = smtpService;
        }

        public async Task<bool> ResetPersonPassword(ResetPersonPasswordInputDTO input)
        {
            var user = _context.Users.Where(x => x.Email == input.Email && x.OTPCode == input.OTP && x.IsLoggedIn == false && x.OTPExipry > DateTime.Now).SingleOrDefault();

            if (user == null)
            {
                return false;
            }
            if (input.Password != input.ConfirmPassword)
            {
                return false;
            }

            user.Password = input.ConfirmPassword;
            user.OTPCode = null;
            user.OTPExipry = null;

            _context.Users.Update(user);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> SendOTP(string email)
        {
            var user = _context.Users.Where(x => x.Email == email && x.IsLoggedIn == false).SingleOrDefault();
            if (user == null)
            {
                return false;
            }
            Random random = new Random();
            var otp = random.Next(11111, 99999);
            user.OTPCode = otp.ToString();
            user.OTPExipry = DateTime.Now.AddMinutes(5);
            await _smtpService.SendEmailAsync(new SendEmailDto()
            {
                To = email,
                Subject = "Your OTP",
                Body = $"{user.OTPCode} valid until {user.OTPExipry}"
            });
             _context.Users.Update(user);
           await _context.SaveChangesAsync();
            return true;

        }

        public async Task<string> SignIn(SignInInputDTO input)
        {
            var orignalUserName = input.Username;
            input.Username = HashingHelper.HashValue384(input.Username);
            var user = _context.Users.Where(x => (x.Email == input.Username || x.Username == input.Username) && x.Password == input.Password && x.IsLoggedIn ==false).SingleOrDefault();
            if (user == null)
            {
                return " User not Found";
            }

            Random random = new Random();
            var otp = random.Next(11111, 99999);
            user.OTPCode=otp.ToString();
            user.OTPExipry=DateTime.Now.AddMinutes(5);
            await _smtpService.SendEmailAsync(new SendEmailDto()
            {
                To = orignalUserName,
                Subject = "Your OTP",
                Body = $"{user.OTPCode} valid until {user.OTPExipry}"
            });
            _context.Users.Update(user);
            await _context.SaveChangesAsync();

            return "Check your Email for OTP";
        }

        public async Task<bool> SignOut(int userId)
        {
            var user = _context.Users.Where(x => x.Id == userId && x.IsLoggedIn == true).SingleOrDefault();
            if (user == null) 
            {
                return false;
            }

            user.LastLoginTime = DateTime.Now;
            user.IsLoggedIn=false;

            _context.Users.Update(user);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task<string> SignUp(SignUpInputDTO input)
        {
            User user = new User();
            user.Email = HashingHelper.HashValue384(input.Email);
            user.Password = HashingHelper.HashValue384(input.Password);
            user.Username = HashingHelper.HashValue384(input.Username);
            user.RoleId = 1;
            user.CreatedBy = "System";
            user.CreationDate = DateTime.Now;

            Random random = new Random();
            var otp =  random.Next(11111,99999);

            user.OTPCode = otp.ToString();
            user.OTPExipry=DateTime.Now.AddMinutes(5);
            await _smtpService.SendEmailAsync(new SendEmailDto()
            {
                To = input.Email,
                Subject = "Your OTP",
                Body = $"{user.OTPCode} valid until {user.OTPExipry}"
            });
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return "Verification Your Email By OTP Code";


        }

        public async Task<string> Verification(VerificationInputDTO input)
        {
            input.Email = HashingHelper.HashValue384(input.Email);
            var user = _context.Users.Where(x=> (x.Email == input.Email ||x.Username==input.Email)&& x.OTPCode==input.OTPCode&&x.IsLoggedIn==false && x.OTPExipry>DateTime.Now).SingleOrDefault();

            if (user == null)
            {
                return "Not Found";
            }
            if(input.IsSignup)
            {
                user.IsVerfied = true;
                user.OTPCode = null;
                user.OTPExipry = null;

                _context.Users.Update(user);
                await _context.SaveChangesAsync();
                return " Your Account is Verify";
            }
            else
            {
                user.LastLoginTime = DateTime.Now;
                user.IsVerfied = true;
                user.OTPCode = null;
                user.OTPExipry = null;

                _context.Users.Update(user);
                await _context.SaveChangesAsync();

                var resulte = TokenHelper.GenrateJWTToken(user.Id.ToString(),"Client");
                return resulte;
            }
        }
    }
}
