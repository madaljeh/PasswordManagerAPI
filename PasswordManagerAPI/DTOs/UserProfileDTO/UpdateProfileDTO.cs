namespace PasswordManagerAPI.DTOs.UserProfileDTO
{
    public class UpdateProfileDTO
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string? Image { get; set; }
        public int Id { get; set; }
    }
}
