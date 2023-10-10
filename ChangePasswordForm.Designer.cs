namespace IBLab1
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
            this.oldPwTb_ = new System.Windows.Forms.TextBox();
            this.confirmPwTb_ = new System.Windows.Forms.TextBox();
            this.newPwTb_ = new System.Windows.Forms.TextBox();
            this.applyBtn_ = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // oldPwTb_
            // 
            this.oldPwTb_.Location = new System.Drawing.Point(193, 69);
            this.oldPwTb_.Name = "oldPwTb_";
            this.oldPwTb_.PasswordChar = '*';
            this.oldPwTb_.Size = new System.Drawing.Size(100, 20);
            this.oldPwTb_.TabIndex = 0;
            // 
            // confirmPwTb_
            // 
            this.confirmPwTb_.Location = new System.Drawing.Point(193, 189);
            this.confirmPwTb_.Name = "confirmPwTb_";
            this.confirmPwTb_.PasswordChar = '*';
            this.confirmPwTb_.Size = new System.Drawing.Size(100, 20);
            this.confirmPwTb_.TabIndex = 2;
            // 
            // newPwTb_
            // 
            this.newPwTb_.Location = new System.Drawing.Point(193, 130);
            this.newPwTb_.Name = "newPwTb_";
            this.newPwTb_.PasswordChar = '*';
            this.newPwTb_.Size = new System.Drawing.Size(100, 20);
            this.newPwTb_.TabIndex = 1;
            // 
            // applyBtn_
            // 
            this.applyBtn_.Location = new System.Drawing.Point(205, 231);
            this.applyBtn_.Name = "applyBtn_";
            this.applyBtn_.Size = new System.Drawing.Size(75, 23);
            this.applyBtn_.TabIndex = 3;
            this.applyBtn_.Text = "Apply";
            this.applyBtn_.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Old Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "\r\nNew Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirm the password";
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 289);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.applyBtn_);
            this.Controls.Add(this.newPwTb_);
            this.Controls.Add(this.confirmPwTb_);
            this.Controls.Add(this.oldPwTb_);
            this.Name = "ChangePasswordForm";
            this.Text = "CahngePasswordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox oldPwTb_;
        private System.Windows.Forms.TextBox confirmPwTb_;
        private System.Windows.Forms.TextBox newPwTb_;
        private System.Windows.Forms.Button applyBtn_;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}