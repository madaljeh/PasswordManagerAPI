namespace PasswordManagerAPI.Entitys
{
    public class User:ParentEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string OTPCode { get; set; }
        public DateTime? OTPExipry { get; set; }
        public int RoleId { get; set; }
        public bool IsVerfied { get; set; }
        public bool IsLoggedIn { get; set; }
        public DateTime? LastLoginTime { get; set; }
    }
}
