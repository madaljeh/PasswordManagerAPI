﻿namespace PasswordManagerAPI.DTOs.UserAuthenticationDTO
{
    public class ResetPersonPasswordInputDTO
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string OTP { get; set; }
    }
}
