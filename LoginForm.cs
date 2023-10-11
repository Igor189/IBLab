namespace IBLab1
{
    public partial class LoginForm : Form
    {
        private static AccountManager accountManager = Singleton<AccountManager>.GetValue();
        public DialogResult Result { get; private set; }
        public UserState Role { get; private set; }
        public User? User { get; private set; }

        private int authCnt = 0;

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

            if (accountManager.IsUserExist(User) && accountManager.IsFirstLogin(User.Username))
            {
                var secondPasswordForm = new RepeatPwdForm(User.Username, User.Password);
                secondPasswordForm.ShowDialog();
                if (secondPasswordForm.Result != DialogResult.OK) return;
            }

            if (accountManager.Login(User))
            {
                if (accountManager.IsUserExist(User) && accountManager.GetUser(User).IsBlocked)
                {
                    MessageBox.Show("Your account is blocked!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (loginTb_.Text == "ADMIN")
                    Role = UserState.ADMIN;
                else
                    Role = UserState.USER;

                if (!accountManager.IsCorrenspondsRestricts(User.Username, User.Password))
                {
                    var res = MessageBox.Show("Your password does not meet the requirements! Change password?", "Warning",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (res == DialogResult.Yes)
                    {
                        var changePasswordForm = new ChangePasswordForm(accountManager.GetUser(User));
                        changePasswordForm.ShowDialog();
                    }
                }

                Result = DialogResult.Continue;
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong login or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                authCnt++;
            }

            if (authCnt >= 3)
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
