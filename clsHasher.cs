using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_System___Middle_Layer
{
    public class clsHasher
    {
        private const int EncryptionKey = 10;
        public static string ComputeSha256Hash(string Password)
        {
            SHA256 sha256Hash = SHA256.Create();

            // ComputeHash - returns byte array
            byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(Password));

            // Convert byte array to a string
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("x2")); // Convert to hexadecimal representation
            }
            return builder.ToString();
        }

        public static string EncryptHashValue(string HashValue)
        {
            StringBuilder builder = new StringBuilder(HashValue);
            for (int i = 0; i < builder.Length; i++)
            {
                builder[i] = Convert.ToChar((Convert.ToInt16(HashValue[i]) - EncryptionKey));
            }
            return builder.ToString();
        }

        public static string DecryptHashValue(string HashValue)
        {
            StringBuilder builder = new StringBuilder(HashValue);
            for (int i = 0; i < builder.Length; i++)
            {
                builder[i] = Convert.ToChar((Convert.ToInt16(HashValue[i]) + EncryptionKey));
            }
            return builder.ToString();
        }

        public static int GenerateSaltValue()
        {
            return new Random().Next(0, int.MaxValue);
        }
    }
}
