
namespace IB
{
    internal class AccountManager
    {
        private static DatabaseRepository database = Singleton<DatabaseRepository>.Instance;

        public bool Login(User user)
        {
            if (database.IsUserExists(user) && database.IsFirstLogin(user.Username))
            {
                database.ChangePwd(user, user.Password);
            }

            return database.IsUserExists(user) && database.IsCorrectPwd(user);
        }

        public bool IsFirstLogin(string username)
        {
            return database.IsFirstLogin(username);
        }

        public bool IsUserExist(User user)
        {
            return database.IsUserExists(user);
        }

        public bool IsPwdUnique(User user, Password oldPassword)
        {
            return user.Password.IsSamePassword(oldPassword);
        }

        public void ChangePwd(User user, Password newPassword)
        {  
            database.ChangePwd(user, newPassword);
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
            database.Encrypt();
        }
    }
}
