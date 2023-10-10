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
    public enum UserStatus
    {
        ADMIN,
        NOADMIN
    };
    public partial class Login : Form
    {
        private User user_;
        public Login()
        {
            InitializeComponent();
        }

        private UserStatus CheckStatus(string login)
        {
            return login == UserStatus.ADMIN.ToString() ? UserStatus.ADMIN : UserStatus.NOADMIN;
        }

        private void applyBtn__Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(passwordTB_.Text) && !string.IsNullOrEmpty(loginTB_.Text))
            {
                switch(CheckStatus(loginTB_.Text))
                {
                    case UserStatus.ADMIN: user_ = new Admin(); break;
                    case UserStatus.NOADMIN: user_ = new NoAdmin(); break;
                }
                if(user_.Password!=passwordTB_.Text)
                {
                    MessageBox.Show("Ты еблан!","Ошибка!",)
                }
            }
        }
    }
}
