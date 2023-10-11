namespace IB
{
    public partial class ChangePasswordForm : Form
    {
        private static AccountManager accountManager = Singleton<AccountManager>.Instance;
        private User _user;

        public ChangePasswordForm(User user)
        {
            InitializeComponent();
            _user = user;
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            if (oldPwTb_.Text == "" || newPwdTb_.Text == "" ||
                confirmTb_.Text == "")
            {
                MessageBox.Show("The password cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (newPwdTb_.Text != confirmTb_.Text)
            {
                MessageBox.Show("Password mismatch!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!accountManager.IsPwdUnique(_user, new Password { Value = oldPwTb_.Text }))
            {
                MessageBox.Show("Incorrect password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!accountManager.IsCorrenspondsRestricts(_user.Username, new Password { Value = newPwdTb_.Text }))
            {
                MessageBox.Show("Your password does not meet the restrictions!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            accountManager.ChangePwd(_user, new Password { Value = newPwdTb_.Text });

            MessageBox.Show("Password changed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oldPasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            oldPwTb_.Text = oldPwTb_.Text.Replace(" ", "");
        }

        private void newPasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            newPwdTb_.Text = newPwdTb_.Text.Replace(" ", "");
        }

        private void repeatNewPasswordTextbox_TextChanged(object sender, EventArgs e)
        {
            confirmTb_.Text = confirmTb_.Text.Replace(" ", "");
        }
    }
}
