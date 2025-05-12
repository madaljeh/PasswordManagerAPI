using Microsoft.EntityFrameworkCore;
using PasswordManagerAPI.Context;
using PasswordManagerAPI.DTOs.LookupDTO;
using PasswordManagerAPI.Interfaces;

namespace PasswordManagerAPI.Services
{
    public class LookupItemService : ILookupItem
    {
        private readonly PasswordManagerDbContext _context;
        public LookupItemService(PasswordManagerDbContext context)
        {
            _context = context;
        }
        public async Task<List<LookupItemDTO>> GetLookupItemsByTypeId(int TypeId)
        {
            var query = from item in _context.LookupItems
                        join type in _context.LookupTypes on item.LookupTypeID equals type.Id
                        where type.Id == TypeId
                        select new LookupItemDTO
                        {
                            Id = item.Id,
                            Name = item.Name,
                            ParentName = type.Name,
                        };
            return await query.ToListAsync();
        }
    }
}
