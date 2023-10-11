namespace IB
{
    partial class DecryptForm
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
            passwordTextBox = new TextBox();
            label2 = new Label();
            applyBtn_ = new Button();
            cancelBtn_ = new Button();
            SuspendLayout();
            // 
            // passwordTextBox
            // 
            passwordTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordTextBox.Location = new Point(143, 25);
            passwordTextBox.Margin = new Padding(2, 2, 2, 2);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(196, 29);
            passwordTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 31);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(131, 19);
            label2.TabIndex = 4;
            label2.Text = "Database password:";
            // 
            // applyBtn_
            // 
            applyBtn_.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            applyBtn_.Location = new Point(211, 71);
            applyBtn_.Margin = new Padding(2, 2, 2, 2);
            applyBtn_.Name = "applyBtn_";
            applyBtn_.Size = new Size(128, 31);
            applyBtn_.TabIndex = 5;
            applyBtn_.Text = "Apply";
            applyBtn_.UseVisualStyleBackColor = true;
            applyBtn_.Click += loginButton_Click;
            // 
            // cancelBtn_
            // 
            cancelBtn_.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cancelBtn_.Location = new Point(5, 71);
            cancelBtn_.Margin = new Padding(2, 2, 2, 2);
            cancelBtn_.Name = "cancelBtn_";
            cancelBtn_.Size = new Size(128, 31);
            cancelBtn_.TabIndex = 6;
            cancelBtn_.Text = "Cancel";
            cancelBtn_.UseVisualStyleBackColor = true;
            cancelBtn_.Click += button1_Click;
            // 
            // DecryptForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 118);
            Controls.Add(cancelBtn_);
            Controls.Add(applyBtn_);
            Controls.Add(label2);
            Controls.Add(passwordTextBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "DecryptForm";
            Text = "Decryption of the database";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passwordTextBox;
        private Label label2;
        private Button applyBtn_;
        private Button cancelBtn_;
    }
}