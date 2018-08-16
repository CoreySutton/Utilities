using System;
using System.Security.Cryptography;
using System.Text;

namespace CoreySutton.Utilities
{
    public static class Encryption
    {
        public static (string encryptedValue, string entropy) Encrypt(string value)
        {
            // Data to protect. Convert a string to a byte[] using Encoding.UTF8.GetBytes().
            byte[] plaintext = Encoding.UTF8.GetBytes(value);

            // Generate additional entropy (will be used as the Initialization vector)
            byte[] entropy = new byte[20];
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(entropy);
            }

            byte[] ciphertext = ProtectedData.Protect(plaintext, entropy,
                DataProtectionScope.CurrentUser);

            string cipherTextString = System.Convert.ToBase64String(ciphertext);
            string entropyString = System.Convert.ToBase64String(entropy);

            return (cipherTextString, entropyString);
        }

        public static string Decrypt(string cipherText, string entropy)
        {
            byte[] cipherTextBytes = System.Convert.FromBase64String(cipherText);
            byte[] entropyBytes = System.Convert.FromBase64String(entropy);

            byte[] plainText = ProtectedData.Unprotect(cipherTextBytes, entropyBytes, DataProtectionScope.CurrentUser);

            string plainTextString = Encoding.UTF8.GetString(plainText);

            return plainTextString;
        }
    }
}
