namespace PasswordManagerAPI.DTOs.AccountDTO
{
    public class CreateUpdateAccountInputDTO
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Username { get; set; }
        public int? UsernameTypeId { get; set; }
        public int? UserId { get; set; }
        public string? Password { get; set; }
        public int? CategoryId { get; set; }
        public int? ProviderId { get; set; }
    }
}
