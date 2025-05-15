using Microsoft.AspNetCore.DataProtection;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace PasswordManagerAPI.Helpers
{
    public static class TokenHelper
    {
        public static string GenrateJWTToken(string UserId,string RoleName)
        {
            var JWTTokenHandler = new JwtSecurityTokenHandler();
            string secret = "kjdghagerjhbcauyebcjwebcageuwybdeajbceubycabcjwhegubjehbwuabcjbcew";
            var tokenByteKey = Encoding.UTF8.GetBytes(secret);
            var descriptor = new SecurityTokenDescriptor
            {
                Expires = DateTime.UtcNow.AddHours(2),
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("UserId",UserId),
                    new Claim("RoleName",RoleName)
                }),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenByteKey), SecurityAlgorithms.HmacSha256Signature)
            };
            var tokenjson = JWTTokenHandler.CreateToken(descriptor);
            var token = JWTTokenHandler.WriteToken(tokenjson);
            return token;
        } 

        public static string IsVaildToken(string token)
        {
            try
            {
                var JWTTokenHandler = new JwtSecurityTokenHandler();
                string secret = "kjdghagerjhbcauyebcjwebcageuwybdeajbceubycabcjwhegubjehbwuabcjbcew";
                var tokenByteKey = Encoding.UTF8.GetBytes(secret);

                var tokenVaildationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(tokenByteKey),
                    ValidateLifetime = true,
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                };
                var tokenBase = JWTTokenHandler.ValidateToken(token, tokenVaildationParameters, out SecurityToken validatedToken);

                return "Valid";
            }
            catch (Exception ex)
            {
                return $"InValid {ex.Message}";
            }
            
        }

    }
}
