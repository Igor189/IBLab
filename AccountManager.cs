using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLab1
{
    internal class AccountManager
    {
        private static DatabaseRepository database = Singleton<DatabaseRepository>.GetValue();

        public bool Login(User user)
        {
            if (database.IsUserExists(user) && database.IsFirstLogin(user.Username))
            {
                database.ChangePassword(user, user.Password);
            }

            return database.IsUserExists(user) && database.IsPasswordCorrect(user);
        }

        public bool IsFirstLogin(string username)
        {
            return database.IsFirstLogin(username);
        }

        public bool IsUserExist(User user)
        {
            return database.IsUserExists(user);
        }

        public bool IsPasswordUnique(User user, Password oldPassword)
        {
            return user.Password.IsSamePassword(oldPassword);
        }

        public void ChangePassword(User user, Password newPassword)
        {  
            database.ChangePassword(user, newPassword);
        }

        public void AddUser(User user)
        {
            database.AddNewUser(user);
        }

        public User? GetUser(User user)
        {
            return database.GetUser(user);
        }

        public bool IsCorrenspondsRestricts(string username, Password password)
        {
            var user = database.GetUserByUsername(username);

            return !user.IsPasswordLimit || 
                user.IsPasswordLimit && password.IsPasswordCorrespondsRestriction;
        }

        public List<User> GetAllUsers()
        {
            return database.GetUsers();
        }

        public void SaveAll(List<User> users)
        {
            database.SaveAll(users);
        }

        public void EncryptAll()
        {
            database.EncryptStream();
        }
    }
}
