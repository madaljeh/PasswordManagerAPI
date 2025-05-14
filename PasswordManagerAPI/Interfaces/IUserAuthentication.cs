using PasswordManagerAPI.DTOs.UserAuthenticationDTO;

namespace PasswordManagerAPI.Interfaces
{
    public interface IUserAuthentication 
    {
        Task<string> SignUp(SignUpInputDTO input);
        Task<string> SignIn(SignInInputDTO input);
        Task<string> Verification(VerificationInputDTO input);
        Task<bool> SendOTP(string email);
        Task<bool> ResetPersonPassword(ResetPersonPasswordInputDTO input);
        Task<bool> SignOut(int userId);

    }
}
