namespace IBLab1
{
    public class User
    {
        public User(string username, string? password)
        {
            Username = username;
            Password = new Password();
            Password.Value = password;
        }

        public User(string username, string? password, bool isPasswordLimit)
        {
            Username = username;
            Password = new Password();
            Password.Value = password;
            IsPasswordLimit = isPasswordLimit;
        }

        public User(string? username, string? password, bool isBlocked, bool isPasswordLimit)
        {
            Username = username;
            Password = new Password { Value = password };
            IsBlocked = isBlocked;
            IsPasswordLimit = isPasswordLimit;
        }

        public string? Username { get; private set; }
        public Password Password { get; set; }

        public bool IsBlocked { get; set; }
        public bool IsPasswordLimit { get; set; }
        
        public override string ToString()
        {
            return $"{Username} {Password.Value} {IsBlocked} {IsPasswordLimit} {Password.IsPasswordCorrespondsRestriction}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is not User) return false;

            var user = obj as User;

            return this.Username == user.Username;
        }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }
    }
}
