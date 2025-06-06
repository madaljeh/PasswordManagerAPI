namespace PasswordManagerAPI.Entitys
{
    public class Account : ParentEntity
    {
        public string Title { get; set; }
        public string? Description { get; set; }
        public string Username { get; set; }
        public int UsernameTypeId { get; set; }
        public int UserId { get; set; }
        public string Password { get; set; }
        public int CategoryId { get; set; }
        public int? ProviderId { get; set; }
        public string UserNameNonce { get; set; }
        public string UserNameTag { get; set; }

        public string PasswordNonce { get; set; }
        public string PasswordTag { get; set; }
        public byte[] Key { get; set; }

    }
}
