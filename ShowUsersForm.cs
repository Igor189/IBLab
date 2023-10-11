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
    public partial class ShowUsersForm : Form
    {
        private List<User> _users = new List<User>();
        private static AccountManager accountManager = Singleton<AccountManager>.Instance;

        public ShowUsersForm()
        {
            InitializeComponent();
        }

        private void AllUsersForm_Load(object sender, EventArgs e)
        {
            _users = accountManager.GetAllUsers();

            dataGridView1.DataSource = _users;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns["Username"].HeaderText = "User name";
            dataGridView1.Columns["Username"].ReadOnly = true;

            string searchValue = "ADMIN";
            int rowIndex = -1;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["Username"].Value.ToString().Equals(searchValue))
                {
                    rowIndex = row.Index;
                    break;
                }
            }

            if (rowIndex != -1)
            {
                dataGridView1.Rows[rowIndex].Cells["IsBlocked"].ReadOnly = true;
            }

            dataGridView1.Columns["IsBlocked"].HeaderText = "Blocked";
            dataGridView1.Columns["IsPasswordLimit"].HeaderText = "Password Limit";
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            accountManager.SaveAll(_users);
            MessageBox.Show("Saving was successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
