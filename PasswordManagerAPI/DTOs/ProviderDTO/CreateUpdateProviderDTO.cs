namespace PasswordManagerAPI.DTOs.ProviderDTO
{
    public class CreateUpdateProviderDTO
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Image { get; set; }
        public string? SiteURL { get; set; }
    }
}
