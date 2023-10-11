namespace IB
{
    public class DatabaseRepository
    {
        public static MemoryStream MemoryStream { private get;  set; }

        private readonly string adminData_ = "ADMIN  false false true";

        public DatabaseRepository()
        {
            CreateDbFile();
        }
        public bool IsCorrectPwd(User user)
        {
            var list = FileParser.Parse(MemoryStream);

            var userFromDb = list.Where(x => x.Username == user.Username).First();
            return userFromDb.Password.IsSamePassword(user.Password);
        }

        public bool IsUserExists(User user)
        {
            var list = FileParser.Parse(MemoryStream);

            return list.Contains(user);
        }
        public void ChangePwd(User user, Password newPassword)
        {
            var list = FileParser.Parse(MemoryStream);

            list.FirstOrDefault(x => x.Equals(user)).Password = newPassword;
            user.Password = newPassword;

            using (StreamWriter writer = new StreamWriter(MemoryStream, leaveOpen: true))
            {
                MemoryStream.SetLength(0);
                MemoryStream.Position = 0;

                foreach (var e in list)
                {
                    writer.WriteLine(e.ToString());
                }

                writer.Flush();
            }
        }


        public bool IsFirstLogin(string? username)
        {
            var list = FileParser.Parse(MemoryStream);

            return list.FirstOrDefault(x => x.Username == username)?.Password.Value
                == "";
        }

        public void AddNewUser(User user)
        {
            using (StreamWriter writer = new StreamWriter(MemoryStream, leaveOpen:true))
            {
                writer.WriteLine(user.ToString());
                writer.Flush();
            }
        }        

        public User? GetUser(User user)
        {
            var list = FileParser.Parse(MemoryStream);
            return list.FirstOrDefault(x => x.Equals(user));
        }

        public User? GetUserByUsername(string username)
        {
            var list = FileParser.Parse(MemoryStream);
            return list.FirstOrDefault(x => x.Username == username);
        }

        public List<User> GetUsers()
        {
            return FileParser.Parse(MemoryStream);
        }

        public void SaveAll(List<User> users)
        {
            using (StreamWriter writer = new StreamWriter(MemoryStream, leaveOpen: true))
            {
                MemoryStream.SetLength(0);
                MemoryStream.Position = 0;

                foreach (var e in users)
                {
                    writer.WriteLine(e.ToString());
                }

                writer.Flush();
            }
        }

        public void Encrypt()
        {
            CryptoAPI.EncryptData(MemoryStream);
        }

        private void CreateDbFile()
        {
            using (StreamReader r = new StreamReader(MemoryStream, leaveOpen:true))
            {
                MemoryStream.Position = 0;

                if (r.ReadToEnd().Contains("ADMIN")){
                    return;
                }
            }

            using (StreamWriter writer = new StreamWriter(MemoryStream, leaveOpen: true))
            {
                writer.WriteLine(adminData_);
                writer.Flush();
            }
        }
    }
}
