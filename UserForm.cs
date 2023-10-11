namespace IB
{
    public partial class UserForm : Form
    {
        private MainForm _mainForm;
        private User _user;

        public UserForm(User user, UserState role, MainForm mainForm)
        {
            InitializeComponent();
            _mainForm = mainForm;
            this.FormClosing += new FormClosingEventHandler(Form_Closing);
            _user = user;

            if (role == UserState.User)
            {
                newUserBtn_.Enabled = false;
                allUsersBtn_.Enabled = false;
            }

            ChangePwdBtn_.Click += ChangePwdBtn_Click;
            newUserBtn_.Click += NewUserBtn_Click;
            allUsersBtn_.Click += AllUsersBtn_Click;
            exitBtn_.Click += ExitBtn_Click;
        }

        private void Form_Closing(object? sender, FormClosingEventArgs e)
        {
            _mainForm.Show();
        }

        private void ExitBtn_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void ChangePwdBtn_Click(object? sender, EventArgs e)
        {
            var changePasswordForm = new ChangePasswordForm(_user);
            changePasswordForm.ShowDialog();
        }

        private void NewUserBtn_Click(object? sender, EventArgs e)
        {
            var newUserForm = new AddNewUserForm();
            newUserForm.ShowDialog();
        }

        private void AllUsersBtn_Click(object? sender, EventArgs e)
        {
            var allUsersForm = new ShowUsersForm();
            allUsersForm.ShowDialog();
        }

        private void About_Click(object sender, EventArgs e)
        {
            using (AboutForm box = new AboutForm())
            {
                box.ShowDialog(this);
            }
        }
    }
}
