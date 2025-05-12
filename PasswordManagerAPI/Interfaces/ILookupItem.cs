using PasswordManagerAPI.DTOs.LookupDTO;

namespace PasswordManagerAPI.Interfaces
{
    public interface ILookupItem
    {
        Task<List<LookupItemDTO>> GetLookupItemsByTypeId(int TypeId);
    }
}
