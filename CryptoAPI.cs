using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace IBLab1
{
    public static class CryptoAPI
    {
        private const int KEYSIZE = 256;
        private const int BLOCKSIZE = 128;
        private const CipherMode MODE = CipherMode.CFB;
        private const string PASSWORDHASH = "b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86";
        private const string FILEPATH = "db.db";
        private static string _password;

        public static bool CheckPassword(string password)
        {
            SHA512 sha = SHA512.Create();
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] passwordHashBytes = sha.ComputeHash(passwordBytes);
            string passwordHash = BitConverter.ToString(passwordHashBytes).Replace("-", "");

            return passwordHash.Equals(PASSWORDHASH.ToUpper());
        }

        public static void EncryptFile(MemoryStream inputData)
        {
            if (_password == null)
            {
                throw new ArgumentNullException(nameof(_password));
            }

            using (Aes aes = Aes.Create())
            {
                aes.KeySize = KEYSIZE;
                aes.BlockSize = BLOCKSIZE;
                aes.Mode = MODE;
                aes.GenerateIV();

                var key = new Rfc2898DeriveBytes(_password, aes.IV, 1000, HashAlgorithmName.SHA512);
                aes.Key = key.GetBytes(aes.KeySize / 8);

                using (FileStream fsCrypt = new FileStream(FILEPATH, FileMode.OpenOrCreate))
                {
                    fsCrypt.SetLength(0);

                    fsCrypt.Write(aes.IV, 0, aes.IV.Length);
                    using (CryptoStream cs = new CryptoStream(fsCrypt, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        inputData.WriteTo(cs);
                    }
                }
            }
        }


        public static MemoryStream DecryptFile(string password)
        {
            _password = password;

            MemoryStream decryptedData = new MemoryStream();
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = KEYSIZE;
                aes.BlockSize = BLOCKSIZE;
                aes.Mode = MODE;

                byte[] iv = new byte[aes.IV.Length];
                using (FileStream fsCrypt = new FileStream(FILEPATH, FileMode.OpenOrCreate))
                {
                    fsCrypt.Read(iv, 0, iv.Length);
                    var key = new Rfc2898DeriveBytes(password, iv, 1000, HashAlgorithmName.SHA512);
                    aes.Key = key.GetBytes(aes.KeySize / 8);
                    aes.IV = iv;

                    using (CryptoStream cs = new CryptoStream(fsCrypt, aes.CreateDecryptor(), CryptoStreamMode.Read))
                    {
                        cs.CopyTo(decryptedData);
                    }
                }
            }
            decryptedData.Position = 0;
            return decryptedData;
        }
    }
}
