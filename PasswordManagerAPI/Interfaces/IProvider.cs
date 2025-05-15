using PasswordManagerAPI.DTOs.ProviderDTO;

namespace PasswordManagerAPI.Interfaces
{
    public interface IProvider
    {
        Task<ProviderDetailsDTO> GetProviderDetails(int Id);
        Task<List<ProviderDTO>> GetProvider();
        Task<string> CreateUpdateProvider(CreateUpdateProviderDTO input);
    }
}
