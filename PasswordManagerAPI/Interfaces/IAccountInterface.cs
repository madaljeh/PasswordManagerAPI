using PasswordManagerAPI.DTOs.AccountDTO;
using PasswordManagerAPI.Entitys;

namespace PasswordManagerAPI.Interfaces
{
    public interface IAccountInterface
    {
        Task<List<AccountDTO>> GetMyAccount(int userId);
        Task<AccountDetailDTO> GetDetailDTO(int Id);
        Task<List<AccountDTO>> SearchAccount(AccountSearchInputDTO input);
        Task<string> CopyAccountOrignizalPassword(int Id);
        Task<string> CreateSreongPassword(int length);
        Task<string> CreateUpdateAccount(CreateUpdateAccountInputDTO input);
    }
}
