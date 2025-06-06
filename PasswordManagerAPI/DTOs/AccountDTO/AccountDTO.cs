namespace PasswordManagerAPI.DTOs.AccountDTO
{
    public class AccountDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Username { get; set; }
        public string UserNameType { get; set; }
        public string Category { get; set; }
        public string ProviderImage { get; set; }
        public string ProviderName { get; set; }
        public string CreationDate { get; set; }
    }
}
