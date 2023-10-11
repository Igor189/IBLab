namespace IB
{
    partial class MainForm
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
            loginBtn_ = new Button();
            exitBtn_ = new Button();
            SuspendLayout();
            // 
            // loginBtn_
            // 
            loginBtn_.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginBtn_.Location = new Point(33, 15);
            loginBtn_.Margin = new Padding(2);
            loginBtn_.Name = "loginBtn_";
            loginBtn_.Size = new Size(200, 44);
            loginBtn_.TabIndex = 0;
            loginBtn_.Text = "Sign in";
            loginBtn_.UseVisualStyleBackColor = true;
            loginBtn_.Click += loginButton_Click;
            // 
            // exitBtn_
            // 
            exitBtn_.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            exitBtn_.Location = new Point(33, 72);
            exitBtn_.Margin = new Padding(2);
            exitBtn_.Name = "exitBtn_";
            exitBtn_.Size = new Size(200, 44);
            exitBtn_.TabIndex = 1;
            exitBtn_.Text = "Exit";
            exitBtn_.UseVisualStyleBackColor = true;
            exitBtn_.Click += exitButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 144);
            Controls.Add(exitBtn_);
            Controls.Add(loginBtn_);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Main Window";
            FormClosing += MainForm_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button loginBtn_;
        private Button exitBtn_;
    }
}