using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IBLab1
{
    public class DatabaseRepository
    {
        private const string ADMINDATA = "ADMIN  false false true";
        public static MemoryStream MemoryStream { private get;  set; }

        public DatabaseRepository()
        {
            CreateDatabase();
        }

        public bool IsUserExists(User user)
        {
            var list = FileParser.Parse(MemoryStream);

            return list.Contains(user);
        }

        public bool IsUserExists(string username)
        {
            var list = FileParser.Parse(MemoryStream);

            return list.FirstOrDefault(x => x.Username == username) != null;
        }

        public bool IsPasswordCorrect(User user)
        {
            var list = FileParser.Parse(MemoryStream);

            var userFromDb = list.Where(x => x.Username == user.Username).First();
            return userFromDb.Password.IsSamePassword(user.Password);
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

        public void ChangePassword(User user, Password newPassword)
        {
            var list = FileParser.Parse(MemoryStream);

            list.FirstOrDefault(x => x.Equals(user)).Password = newPassword;
            user.Password = newPassword;

            using (StreamWriter writer = new StreamWriter(MemoryStream, leaveOpen:true))
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

        public void EncryptStream()
        {
            CryptoAPI.EncryptFile(MemoryStream);
        }

        private void CreateDatabase()
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
                writer.WriteLine(ADMINDATA);
                writer.Flush();
            }
        }
    }
}
