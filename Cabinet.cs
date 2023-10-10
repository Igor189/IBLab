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
    public partial class Cabinet : Form
    {
        public Cabinet(User user)
        {
            InitializeComponent();
            if(user is NoAdmin)
            {
                usersBtn_.Enabled = false;
            }
        }

        private void exitBtn__Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you really want to quit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void changePwdBtn__Click(object sender, EventArgs e)
        {
            var changePwd = new ChangePasswordForm();
            changePwd.ShowDialog();
        }
    }
}
