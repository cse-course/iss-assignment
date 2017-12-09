using System;
using System.Security.Cryptography;
using System.Text;

namespace Utils
{
    public class PasswordUtils
    {
        public static string Get(String Password)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(Password);
            byte[] inArray = HashAlgorithm.Create("SHA1").ComputeHash(bytes);
            return Convert.ToBase64String(inArray);
        }
    }
}
