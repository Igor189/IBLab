namespace IB
{
    partial class ChangePasswordForm
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
            oldPwTb_ = new TextBox();
            newPwdTb_ = new TextBox();
            confirmTb_ = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            applyBtn_ = new Button();
            cancelBtn_ = new Button();
            SuspendLayout();
            // 
            // oldPwTb_
            // 
            oldPwTb_.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            oldPwTb_.Location = new Point(200, 11);
            oldPwTb_.Margin = new Padding(2);
            oldPwTb_.Name = "oldPwTb_";
            oldPwTb_.PasswordChar = '*';
            oldPwTb_.Size = new Size(196, 29);
            oldPwTb_.TabIndex = 2;
            oldPwTb_.TextChanged += oldPasswordTextbox_TextChanged;
            // 
            // newPwdTb_
            // 
            newPwdTb_.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newPwdTb_.Location = new Point(200, 48);
            newPwdTb_.Margin = new Padding(2);
            newPwdTb_.Name = "newPwdTb_";
            newPwdTb_.PasswordChar = '*';
            newPwdTb_.Size = new Size(196, 29);
            newPwdTb_.TabIndex = 3;
            newPwdTb_.TextChanged += newPasswordTextbox_TextChanged;
            // 
            // confirmTb_
            // 
            confirmTb_.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            confirmTb_.Location = new Point(200, 90);
            confirmTb_.Margin = new Padding(2);
            confirmTb_.Name = "confirmTb_";
            confirmTb_.PasswordChar = '*';
            confirmTb_.Size = new Size(196, 29);
            confirmTb_.TabIndex = 4;
            confirmTb_.TextChanged += repeatNewPasswordTextbox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(14, 14);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 5;
            label1.Text = "Old password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(14, 52);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 6;
            label2.Text = "New password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 94);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(157, 20);
            label3.TabIndex = 7;
            label3.Text = "Confirm the password:";
            // 
            // applyBtn_
            // 
            applyBtn_.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            applyBtn_.Location = new Point(246, 138);
            applyBtn_.Margin = new Padding(2);
            applyBtn_.Name = "applyBtn_";
            applyBtn_.Size = new Size(150, 31);
            applyBtn_.TabIndex = 9;
            applyBtn_.Text = "Apply";
            applyBtn_.UseVisualStyleBackColor = true;
            applyBtn_.Click += changePasswordButton_Click;
            // 
            // cancelBtn_
            // 
            cancelBtn_.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cancelBtn_.Location = new Point(6, 138);
            cancelBtn_.Margin = new Padding(2);
            cancelBtn_.Name = "cancelBtn_";
            cancelBtn_.Size = new Size(150, 31);
            cancelBtn_.TabIndex = 10;
            cancelBtn_.Text = "Cancel";
            cancelBtn_.UseVisualStyleBackColor = true;
            cancelBtn_.Click += button1_Click;
            // 
            // ChangePasswordForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 183);
            Controls.Add(cancelBtn_);
            Controls.Add(applyBtn_);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(confirmTb_);
            Controls.Add(newPwdTb_);
            Controls.Add(oldPwTb_);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "ChangePasswordForm";
            Text = "Change Password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox oldPwTb_;
        private TextBox newPwdTb_;
        private TextBox confirmTb_;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button applyBtn_;
        private Button cancelBtn_;
    }
}