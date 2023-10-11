namespace IB
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginTb_ = new TextBox();
            label1 = new Label();
            label2 = new Label();
            applyeBtn_ = new Button();
            cancelBtn_ = new Button();
            pwdTb_ = new TextBox();
            SuspendLayout();
            // 
            // loginTb_
            // 
            loginTb_.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginTb_.Location = new Point(108, 11);
            loginTb_.Margin = new Padding(2);
            loginTb_.Name = "loginTb_";
            loginTb_.Size = new Size(160, 29);
            loginTb_.TabIndex = 0;
            loginTb_.TextChanged += loginTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(48, 13);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(49, 21);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 49);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // applyeBtn_
            // 
            applyeBtn_.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            applyeBtn_.Location = new Point(167, 93);
            applyeBtn_.Margin = new Padding(2);
            applyeBtn_.Name = "applyeBtn_";
            applyeBtn_.Size = new Size(101, 31);
            applyeBtn_.TabIndex = 4;
            applyeBtn_.Text = "Apply";
            applyeBtn_.UseVisualStyleBackColor = true;
            applyeBtn_.Click += loginButton_Click;
            // 
            // cancelBtn_
            // 
            cancelBtn_.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cancelBtn_.Location = new Point(37, 93);
            cancelBtn_.Margin = new Padding(2);
            cancelBtn_.Name = "cancelBtn_";
            cancelBtn_.Size = new Size(101, 31);
            cancelBtn_.TabIndex = 5;
            cancelBtn_.Text = "Cancel";
            cancelBtn_.UseVisualStyleBackColor = true;
            cancelBtn_.Click += exitButton_Click;
            // 
            // pwdTb_
            // 
            pwdTb_.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            pwdTb_.Location = new Point(108, 46);
            pwdTb_.Margin = new Padding(2);
            pwdTb_.Name = "pwdTb_";
            pwdTb_.PasswordChar = '*';
            pwdTb_.Size = new Size(160, 29);
            pwdTb_.TabIndex = 1;
            pwdTb_.TextChanged += passwordTextBox_TextChanged;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(313, 139);
            Controls.Add(pwdTb_);
            Controls.Add(cancelBtn_);
            Controls.Add(applyeBtn_);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginTb_);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginTb_;
        private Label label1;
        private Label label2;
        private Button applyeBtn_;
        private Button cancelBtn_;
        private TextBox pwdTb_;
    }
}