using PasswordManagerAPI.DTOs.UserProfileDTO;

namespace PasswordManagerAPI.Interfaces
{
    public interface IUserProfile
    {
        Task<ProfileDTO> GetUserProfile(int UserId);
        Task<string> UpdateUserProfile(UpdateProfileDTO input);

        Task<string> UpdateImageProfile(int UserId,string url);
    }
}
