using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBLab1
{
    public partial class EnterPasswordAgainForm : Form
    {
        private Password _firstPassword;
        private string _username;
        private static AccountManager accountManager = Singleton<AccountManager>.GetValue();

        public DialogResult Result { get; private set; }

        public EnterPasswordAgainForm(string username, Password password)
        {
            InitializeComponent();
            _username = username;
            _firstPassword = password;
            loginTextBox.TextChanged += Clear;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var secondPassword = new Password { Value = loginTextBox.Text };
            if (_firstPassword.IsSamePassword(secondPassword) && 
                accountManager.IsCorrenspondsRestricts(_username, secondPassword))
            {
                Result = DialogResult.OK;
                this.Close();
            }
            else if (!_firstPassword.IsSamePassword(secondPassword))
            {
                label3.Visible = true;
            }
            else
            {
                label2.Visible = true;
            }
        }

        private void Clear(object? sender, EventArgs e)
        {
            label2.Visible = false;
            label3.Visible = false;
        }

        private void loginTextBox_TextChanged(object sender, EventArgs e)
        {
            loginTextBox.Text = loginTextBox.Text.Replace(" ", "");
        }
    }
}
