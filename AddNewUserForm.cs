namespace IB
{
    public partial class AddNewUserForm : Form
    {
        private static AccountManager accountManager = Singleton<AccountManager>.Instance;

        public AddNewUserForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var user = new User(textBox1.Text, "", checkBox1.Checked);
            if (user.Username == "")
            {
                MessageBox.Show("\r\nThe username cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (accountManager.IsUserExist(user))
            {
                MessageBox.Show("A user with the same name already exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                accountManager.AddUser(user);
                MessageBox.Show("User added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace(" ", "");
        }
    }
}
