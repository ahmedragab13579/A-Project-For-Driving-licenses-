using System;
using System.IO;
using System.Security.Cryptography;

namespace DVDL_InfrastructureLayer
{
    public class Encrypt
    {
        private readonly ConfigManager _configManager;
        private readonly byte[] Key;
        private readonly byte[] IV;

        public Encrypt()
        {
            _configManager = new ConfigManager();
            Key = Convert.FromBase64String(_configManager.GetAppSetting("Key")); // فك الـ Base64
            IV = Convert.FromBase64String(_configManager.GetAppSetting("IV"));   // فك الـ Base64
        }

        public string EncryptText(string plainText)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    using (StreamWriter sw = new StreamWriter(cs))
                    {
                        sw.Write(plainText);
                    }

                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

    }
}
