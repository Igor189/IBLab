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
    public partial class DecryptForm : Form
    {
        public DecryptForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!CryptoAPI.IsPasswordValid(passwordTextBox.Text))
            {
                MessageBox.Show("Incorrect password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }
            try
            {
                DatabaseRepository.MemoryStream = CryptoAPI.DecryptData(passwordTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Error in decrypting file!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }

            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }
    }
}
