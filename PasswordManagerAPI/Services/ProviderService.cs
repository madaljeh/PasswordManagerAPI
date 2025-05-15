using Microsoft.EntityFrameworkCore;
using PasswordManagerAPI.Context;
using PasswordManagerAPI.DTOs.ProviderDTO;
using PasswordManagerAPI.Entitys;
using PasswordManagerAPI.Interfaces;

namespace PasswordManagerAPI.Services
{
    public class ProviderService : IProvider
    {
        private readonly PasswordManagerDbContext _context;
        public ProviderService(PasswordManagerDbContext context)
        {
            _context = context;
        }
        public async Task<string> CreateUpdateProvider(CreateUpdateProviderDTO input)
        {
            if (input.Id != null) // Update  
            {
                var item = await _context.Providers.Where(x => x.Id == input.Id).FirstOrDefaultAsync();
                if (item != null)
                {
                    if (!string.IsNullOrEmpty(input.Name))
                    {
                        item.Name = input.Name;
                    }
                    if (!string.IsNullOrEmpty(input.SiteURL))
                    {
                        item.SiteURL = input.SiteURL;
                    }
                    if (!string.IsNullOrEmpty(input.Image))
                    {
                        item.Image = input.Image;
                    }
                    _context.Update(item);
                    await _context.SaveChangesAsync();
                    return "Provider Updated";
                }
                return "Provider Not Found";
            }
            else // Create  
            {
                Provider provider = new Provider
                {
                    SiteURL = input.SiteURL ?? string.Empty,
                    Name = input.Name ?? string.Empty,
                    Image = input.Image ?? string.Empty
                };
                _context.Add(provider);
                await _context.SaveChangesAsync();

                return "New Provider Added";
            }
        }

        public async Task<List<ProviderDTO>> GetProvider()
        {
            var output = _context.Providers.Select(x => new ProviderDTO
            {
                Id = x.Id,
                Name = x.Name,
                Image = x.Image,
            }); 
            return await output.ToListAsync();
        }

        public async Task<ProviderDetailsDTO> GetProviderDetails(int Id)
        {
            var output = await _context.Providers.Where(x=> x.Id == Id).Select(p=> new ProviderDetailsDTO
            {
                Id=p.Id,
                Name=p.Name,
                Image=p.Image,
                CreationDate=p.CreationDate.ToShortDateString(),
                SiteURL=p.SiteURL
            }).FirstOrDefaultAsync();

            return output;
        }
    }
}
