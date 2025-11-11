using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HardwareRentalApp.Classes
{
    internal class ActivationKeyDecoder
    {
        private readonly byte[] Key = Encoding.UTF8.GetBytes("jaishriramjaishriramjaishriram--"); // 32 bytes for AES-256
        private readonly byte[] IV = Encoding.UTF8.GetBytes("jaibajrangbali--");   // 16 bytes for AES

        private DBInterface obj_DBAccess = new DBInterface();

        public string DecodeActivationKey(string encodedKey)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                byte[] encryptedBytes = Convert.FromBase64String(encodedKey);
                byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

                return Encoding.UTF8.GetString(decryptedBytes);

                // Activation key format: 32
                // User ID (6), MAC address (12), Product type (1), License type (1), Activation days (4), Request date (8)
                // 0-5,         6-17,               18,                 19,              20 - 23,           24-31
            }
        }
    }
}
