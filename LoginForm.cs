namespace IB
{
    public partial class LoginForm : Form
    {
        public DialogResult Result { get; private set; }
        public UserState Role { get; private set; }
        public User? User { get; private set; }

        private int counter_ = 0;
        private static AccountManager accountManager_ = Singleton<AccountManager>.Instance;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            User = new User(loginTb_.Text, pwdTb_.Text);

            if (User.Username == "" || pwdTb_.Text == "")
            {
                MessageBox.Show("No login or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (accountManager_.IsUserExist(User) && accountManager_.IsFirstLogin(User.Username))
            {
                var secondPasswordForm = new RepeatPwdForm(User.Username, User.Password);
                secondPasswordForm.ShowDialog();
                if (secondPasswordForm.Result != DialogResult.OK) return;
            }

            if (accountManager_.Login(User))
            {
                if (accountManager_.IsUserExist(User) && accountManager_.GetUser(User).IsBlocked)
                {
                    MessageBox.Show("Your account is blocked!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (loginTb_.Text == "ADMIN")
                    Role = UserState.Admin;
                else
                    Role = UserState.User;

                if (!accountManager_.IsCorrenspondsRestricts(User.Username, User.Password))
                {
                    var res = MessageBox.Show("Your password does not meet the requirements! Change password?", "Warning",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (res == DialogResult.Yes)
                    {
                        var changePasswordForm = new ChangePasswordForm(accountManager_.GetUser(User));
                        changePasswordForm.ShowDialog();
                    }
                }

                Result = DialogResult.Continue;
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong login or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                counter_++;
            }

            if (counter_ >= 3)
            {
                Application.Exit();
            }
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            loginTb_.Text = loginTb_.Text.Replace(" ", "");
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            pwdTb_.Text = pwdTb_.Text.Replace(" ", "");
        }
    }
}
