namespace PasswordManagerAPI.Entitys
{
    public class Profile:ParentEntity
    {
        
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public string? Image { get; set; }
        public int UserId { get; set; }

    }
}
