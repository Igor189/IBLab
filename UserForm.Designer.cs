namespace IBLab1
{
    partial class UserForm
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
            menuStrip1 = new MenuStrip();
            aboutToolStrip_ = new ToolStripMenuItem();
            ChangePwdBtn_ = new Button();
            newUserBtn_ = new Button();
            allUsersBtn_ = new Button();
            exitBtn_ = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aboutToolStrip_ });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(450, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStrip_
            // 
            aboutToolStrip_.Name = "aboutToolStrip_";
            aboutToolStrip_.Size = new Size(52, 22);
            aboutToolStrip_.Text = "About";
            aboutToolStrip_.Click += справкаToolStripMenuItem_Click;
            // 
            // ChangePwdBtn_
            // 
            ChangePwdBtn_.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ChangePwdBtn_.Location = new Point(121, 62);
            ChangePwdBtn_.Margin = new Padding(2, 2, 2, 2);
            ChangePwdBtn_.Name = "ChangePwdBtn_";
            ChangePwdBtn_.Size = new Size(188, 31);
            ChangePwdBtn_.TabIndex = 11;
            ChangePwdBtn_.Text = "Change password";
            ChangePwdBtn_.UseVisualStyleBackColor = true;
            // 
            // newUserBtn_
            // 
            newUserBtn_.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            newUserBtn_.Location = new Point(121, 102);
            newUserBtn_.Margin = new Padding(2, 2, 2, 2);
            newUserBtn_.Name = "newUserBtn_";
            newUserBtn_.Size = new Size(188, 31);
            newUserBtn_.TabIndex = 12;
            newUserBtn_.Text = "New user";
            newUserBtn_.UseVisualStyleBackColor = true;
            // 
            // allUsersBtn_
            // 
            allUsersBtn_.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            allUsersBtn_.Location = new Point(121, 143);
            allUsersBtn_.Margin = new Padding(2, 2, 2, 2);
            allUsersBtn_.Name = "allUsersBtn_";
            allUsersBtn_.Size = new Size(188, 31);
            allUsersBtn_.TabIndex = 13;
            allUsersBtn_.Text = "All users";
            allUsersBtn_.UseVisualStyleBackColor = true;
            // 
            // exitBtn_
            // 
            exitBtn_.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            exitBtn_.Location = new Point(121, 187);
            exitBtn_.Margin = new Padding(2, 2, 2, 2);
            exitBtn_.Name = "exitBtn_";
            exitBtn_.Size = new Size(188, 31);
            exitBtn_.TabIndex = 14;
            exitBtn_.Text = "Exit";
            exitBtn_.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 270);
            Controls.Add(exitBtn_);
            Controls.Add(allUsersBtn_);
            Controls.Add(newUserBtn_);
            Controls.Add(ChangePwdBtn_);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "UserForm";
            Text = "Main menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aboutToolStrip_;
        private Button ChangePwdBtn_;
        private Button newUserBtn_;
        private Button allUsersBtn_;
        private Button exitBtn_;
    }
}