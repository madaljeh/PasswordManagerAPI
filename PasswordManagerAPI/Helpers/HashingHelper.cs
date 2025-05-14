using System.Security.Cryptography;
using System.Text;

namespace PasswordManagerAPI.Helpers
{
    public class HashingHelper
    {
        public static string HashValue256(string inputValue)
        {
            var inputByte = Encoding.UTF8.GetBytes(inputValue);
            var hashAlgorithm = SHA256.Create();
            var hashByte= hashAlgorithm.ComputeHash(inputByte);
            return BitConverter.ToString(hashByte).Replace("-","").ToLower();
        }
        public static string HashValue384(string inputValue)
        {
            var inputByte = Encoding.UTF8.GetBytes(inputValue);
            var hashAlgorithm = SHA384.Create();
            var hashByte = hashAlgorithm.ComputeHash(inputByte);
            return BitConverter.ToString(hashByte).Replace("-", "").ToLower();
        }
        public static string HashValue512(string inputValue)
        {
            var inputByte = Encoding.UTF8.GetBytes(inputValue);
            var hashAlgorithm = SHA512.Create();
            var hashByte = hashAlgorithm.ComputeHash(inputByte);
            return BitConverter.ToString(hashByte).Replace("-", "").ToLower();
        }
    }
}
