using System;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Configuration;

namespace Encryption.Tool
{
    public class StringEncryption
    {
        private static byte[] InitializationVector = { 0x12, 0x34, 0x56, 0x78, 0x90, 0xab, 0xcd, 0xef };

        /// <summary>
        /// Get & Sets The Encryption Key
        /// </summary>
        public static string EncryptionKey { get; set; }

        #region Static Constructor

        static StringEncryption()
        {
            var encryptionKey = ConfigurationManager.AppSettings["EncryptionKey"];
            EncryptionKey = string.IsNullOrEmpty(encryptionKey) ? "pritamsh" : encryptionKey;
        }

        #endregion Static Constructor

        #region Public Methods

        public static string Encrypt(string value)
        {
            return Encrypt(value, EncryptionKey);
        }

        public static string Encrypt(string value, string encryptionKey)
        {
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    var key = Encoding.UTF8.GetBytes(encryptionKey);
                    var des = new DESCryptoServiceProvider();
                    var inputByteArray = Encoding.UTF8.GetBytes(value);
                    var ms = new MemoryStream();
                    var cs = new CryptoStream(ms, des.CreateEncryptor(key, InitializationVector), CryptoStreamMode.Write);
                    cs.Write(inputByteArray, 0, inputByteArray.Length);
                    cs.FlushFinalBlock();
                    var output = ms.ToArray();
                    return BytesToHex(output);
                }
                return value;
            }
            catch
            {
                return value;
            }
        }

        public static string Decrypt(string value)
        {
            return Decrypt(value, EncryptionKey);
        }

        public static string Decrypt(string value, string encryptionKey)
        {
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    var key = Encoding.UTF8.GetBytes(encryptionKey);
                    var des = new DESCryptoServiceProvider();
                    var inputByteArray = HexToBytes(value);

                    var ms = new MemoryStream();
                    var cs = new CryptoStream(ms, des.CreateDecryptor(key, InitializationVector), CryptoStreamMode.Write);
                    cs.Write(inputByteArray, 0, inputByteArray.Length);
                    cs.FlushFinalBlock();
                    Encoding encoding = Encoding.UTF8;
                    return encoding.GetString(ms.ToArray());
                }
                return value;
            }
            catch
            {
                return value;
            }
        }

        public static string GenerateHashWithSalt(string value)
        {
            return GenerateHashWithSalt(value, EncryptionKey);
        }

        public static string GenerateHashWithSalt(string value, string salt)
        {
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    var testWithSalt = value + salt;
                    var buffer = Encoding.UTF8.GetBytes(testWithSalt);
                    HashAlgorithm algorithm = new SHA256Managed();
                    var hash = algorithm.ComputeHash(buffer);

                    return Convert.ToBase64String(hash);
                }
                return value;
            }
            catch
            {
                return value;
            }
        }

        public static string DecryptHashWithSalt(string value)
        {
            return DecryptHashWithSalt(value, EncryptionKey);
        }

        public static string DecryptHashWithSalt(string value, string salt)
        {
            try
            {
                if (!string.IsNullOrEmpty(value))
                {
                    var hash = Convert.FromBase64String(value);

                    HashAlgorithm algorithm = new SHA256Managed();
                    var buffer = algorithm.TransformFinalBlock(hash, 0, 32);

                    var testWithSalt = Encoding.UTF8.GetString(buffer);

                    value = testWithSalt.Replace(salt, string.Empty);
                    return value;
                }
                return value;
            }
            catch
            {
                return value;
            }
        }

        #endregion Public Methods

        #region Private Methods

        private static byte[] HexToBytes(string value)
        {
            int i = 0, x = 0;
            var bytes = new byte[value.Length / 2];
            while (value.Length > i)
            {
                var lngDecimal = Convert.ToInt32(value.Substring(i, 2), 16);
                bytes[x] = Convert.ToByte(lngDecimal);
                i += 2;
                x += 1;
            }
            return bytes;
        }

        private static string BytesToHex(byte[] bytes)
        {
            var hexString = new StringBuilder(bytes.Length);
            for (var i = 0; i < bytes.Length; i++)
            {
                hexString.Append(bytes[i].ToString("X2"));
            }
            return hexString.ToString();
        }

        #endregion Private Methods

    }
}