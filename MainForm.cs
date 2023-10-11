using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IB
{
    public partial class MainForm : Form
    {
        private static AccountManager accountManager = Singleton<AccountManager>.Instance;

        public MainForm()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (loginForm.Result != DialogResult.Continue)
            {
                return;
            }

            var userForm = new UserForm(loginForm.User, loginForm.Role, this);
            this.Hide();
            userForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            accountManager.EncryptAll();
            Application.Exit();
        }
    }
}
