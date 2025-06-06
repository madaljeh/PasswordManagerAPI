namespace PasswordManagerAPI.DTOs.AccountDTO
{
    public class AccountDetailDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserNameType { get; set; }
        public string Category { get; set; }
        public string ProviderImage { get; set; }
        public string ProviderName { get; set; }
        public string CreationDate { get; set; }
        public string UpdateDate { get; set; }
    }
}
