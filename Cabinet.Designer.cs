﻿namespace IBLab1
{
    partial class Cabinet
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
            this.exitBtn_ = new System.Windows.Forms.Button();
            this.changePwdBtn_ = new System.Windows.Forms.Button();
            this.usersBtn_ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitBtn_
            // 
            this.exitBtn_.Location = new System.Drawing.Point(403, 331);
            this.exitBtn_.Name = "exitBtn_";
            this.exitBtn_.Size = new System.Drawing.Size(75, 23);
            this.exitBtn_.TabIndex = 0;
            this.exitBtn_.Text = "Exit";
            this.exitBtn_.UseVisualStyleBackColor = true;
            this.exitBtn_.Click += new System.EventHandler(this.exitBtn__Click);
            // 
            // changePwdBtn_
            // 
            this.changePwdBtn_.Location = new System.Drawing.Point(378, 181);
            this.changePwdBtn_.Name = "changePwdBtn_";
            this.changePwdBtn_.Size = new System.Drawing.Size(138, 23);
            this.changePwdBtn_.TabIndex = 1;
            this.changePwdBtn_.Text = "Change Password";
            this.changePwdBtn_.UseVisualStyleBackColor = true;
            this.changePwdBtn_.Click += new System.EventHandler(this.changePwdBtn__Click);
            // 
            // usersBtn_
            // 
            this.usersBtn_.Location = new System.Drawing.Point(378, 210);
            this.usersBtn_.Name = "usersBtn_";
            this.usersBtn_.Size = new System.Drawing.Size(138, 23);
            this.usersBtn_.TabIndex = 2;
            this.usersBtn_.Text = "Users";
            this.usersBtn_.UseVisualStyleBackColor = true;
            // 
            // Cabinet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.usersBtn_);
            this.Controls.Add(this.changePwdBtn_);
            this.Controls.Add(this.exitBtn_);
            this.Name = "Cabinet";
            this.Text = "Cabinet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitBtn_;
        private System.Windows.Forms.Button changePwdBtn_;
        private System.Windows.Forms.Button usersBtn_;
    }
}