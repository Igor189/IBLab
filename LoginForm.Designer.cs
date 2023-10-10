namespace IBLab1
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginL_ = new System.Windows.Forms.Label();
            this.loginTB_ = new System.Windows.Forms.TextBox();
            this.passwordTB_ = new System.Windows.Forms.TextBox();
            this.passwordL_ = new System.Windows.Forms.Label();
            this.applyBtn_ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginL_
            // 
            this.loginL_.AutoSize = true;
            this.loginL_.Location = new System.Drawing.Point(208, 66);
            this.loginL_.Name = "loginL_";
            this.loginL_.Size = new System.Drawing.Size(33, 13);
            this.loginL_.TabIndex = 0;
            this.loginL_.Text = "Login";
            // 
            // loginTB_
            // 
            this.loginTB_.Location = new System.Drawing.Point(181, 82);
            this.loginTB_.Name = "loginTB_";
            this.loginTB_.Size = new System.Drawing.Size(100, 20);
            this.loginTB_.TabIndex = 1;
            // 
            // passwordTB_
            // 
            this.passwordTB_.Location = new System.Drawing.Point(181, 136);
            this.passwordTB_.Name = "passwordTB_";
            this.passwordTB_.PasswordChar = '*';
            this.passwordTB_.Size = new System.Drawing.Size(100, 20);
            this.passwordTB_.TabIndex = 3;
            // 
            // passwordL_
            // 
            this.passwordL_.AutoSize = true;
            this.passwordL_.Location = new System.Drawing.Point(208, 120);
            this.passwordL_.Name = "passwordL_";
            this.passwordL_.Size = new System.Drawing.Size(53, 13);
            this.passwordL_.TabIndex = 2;
            this.passwordL_.Text = "Password";
            // 
            // applyBtn_
            // 
            this.applyBtn_.Location = new System.Drawing.Point(195, 172);
            this.applyBtn_.Name = "applyBtn_";
            this.applyBtn_.Size = new System.Drawing.Size(75, 23);
            this.applyBtn_.TabIndex = 4;
            this.applyBtn_.Text = "Apply";
            this.applyBtn_.UseVisualStyleBackColor = true;
            this.applyBtn_.Click += new System.EventHandler(this.applyBtn__Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 234);
            this.Controls.Add(this.applyBtn_);
            this.Controls.Add(this.passwordTB_);
            this.Controls.Add(this.passwordL_);
            this.Controls.Add(this.loginTB_);
            this.Controls.Add(this.loginL_);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginL_;
        private System.Windows.Forms.TextBox loginTB_;
        private System.Windows.Forms.TextBox passwordTB_;
        private System.Windows.Forms.Label passwordL_;
        private System.Windows.Forms.Button applyBtn_;
    }
}

