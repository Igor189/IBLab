namespace IB
{
    partial class RepeatPwdForm
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
            loginTextBox = new TextBox();
            label1 = new Label();
            loginButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // loginTextBox
            // 
            loginTextBox.BorderStyle = BorderStyle.FixedSingle;
            loginTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginTextBox.Location = new Point(144, 22);
            loginTextBox.Margin = new Padding(2);
            loginTextBox.Name = "loginTextBox";
            loginTextBox.PasswordChar = '*';
            loginTextBox.Size = new Size(143, 29);
            loginTextBox.TabIndex = 1;
            loginTextBox.TextChanged += loginTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 21);
            label1.TabIndex = 3;
            label1.Text = "Repeat password:";
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.Location = new Point(159, 74);
            loginButton.Margin = new Padding(2);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(128, 31);
            loginButton.TabIndex = 8;
            loginButton.Text = "Apply";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(8, 74);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(128, 31);
            button1.TabIndex = 10;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RepeatPwdForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 124);
            Controls.Add(button1);
            Controls.Add(loginButton);
            Controls.Add(label1);
            Controls.Add(loginTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "RepeatPwdForm";
            Text = "Repeat password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox loginTextBox;
        private Label label1;
        private Button loginButton;
        private Button button1;
    }
}