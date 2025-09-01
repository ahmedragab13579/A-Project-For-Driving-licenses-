using System;
using System.IO;
using System.Security.Cryptography;

namespace DVDL_InfrastructureLayer
{
    public class Decrypt
    {
        private readonly ConfigManager _configManager;
        private readonly byte[] Key;
        private readonly byte[] IV;

        public Decrypt()
        {
            _configManager = new ConfigManager();
            Key = Convert.FromBase64String(_configManager.GetAppSetting("Key")); // فك الـ Base64
            IV = Convert.FromBase64String(_configManager.GetAppSetting("IV"));  // فك الـ Base64
        }

        public string DecryptText(string cipherText)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(cipherText)))
                using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                using (StreamReader sr = new StreamReader(cs))
                {
                    return sr.ReadToEnd();
                }
            }
        }
    }
}
