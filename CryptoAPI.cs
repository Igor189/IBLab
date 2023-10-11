using System.Security.Cryptography;
using System.Text;

namespace IB
{
    public static class CryptoAPI
    {
        private static readonly string pwdHash_ = "b109f3bbbc244eb82441917ed06d618b9008dd09b3befd1b5e07394c706a8bb980b1d7785e5976ec049b46df5f1326af5a2ea6d103fd07c95385ffab0cacbc86";
        private static readonly string path_ = "db.db";
        private static string password_;
        private static readonly int keySize_ = 256;
        private static readonly int blockSize_ = 128;
        private static readonly CipherMode mode_ = CipherMode.CFB;

        public static bool IsPasswordValid(string password)
        {
            SHA512 sha = SHA512.Create();
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] passwordHashBytes = sha.ComputeHash(passwordBytes);
            string passwordHash = BitConverter.ToString(passwordHashBytes).Replace("-", "");

            return passwordHash.Equals(pwdHash_.ToUpper());
        }

        public static void EncryptData(MemoryStream inputData)
        {
            if (password_ == null)
            {
                throw new ArgumentNullException(nameof(password_));
            }

            using (Aes aes = Aes.Create())
            {
                aes.KeySize = keySize_;
                aes.BlockSize = blockSize_;
                aes.Mode = mode_;
                aes.GenerateIV();

                var key = new Rfc2898DeriveBytes(password_, aes.IV, 1000, HashAlgorithmName.SHA512);
                aes.Key = key.GetBytes(aes.KeySize / 8);

                using (FileStream fsCrypt = new FileStream(path_, FileMode.OpenOrCreate))
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


        public static MemoryStream DecryptData(string password)
        {
            password_ = password;

            MemoryStream decryptedData = new MemoryStream();
            using (Aes aes = Aes.Create())
            {
                aes.KeySize = keySize_;
                aes.BlockSize = blockSize_;
                aes.Mode = mode_;

                byte[] iv = new byte[aes.IV.Length];
                using (FileStream fsCrypt = new FileStream(path_, FileMode.OpenOrCreate))
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
