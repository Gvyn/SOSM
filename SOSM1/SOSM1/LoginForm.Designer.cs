namespace SOSM1
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
            this.loginButton = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.signLabel = new System.Windows.Forms.Label();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.signButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.Location = new System.Drawing.Point(98, 130);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Zaloguj";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(84, 49);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(102, 13);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "Nazwa użytkownika";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(117, 88);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(36, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Hasło";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signLabel
            // 
            this.signLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signLabel.AutoSize = true;
            this.signLabel.Location = new System.Drawing.Point(92, 178);
            this.signLabel.Name = "signLabel";
            this.signLabel.Size = new System.Drawing.Size(86, 13);
            this.signLabel.TabIndex = 3;
            this.signLabel.Text = "Nie masz konta?";
            this.signLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userNameBox
            // 
            this.userNameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userNameBox.Location = new System.Drawing.Point(41, 65);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(188, 20);
            this.userNameBox.TabIndex = 4;
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordBox.Location = new System.Drawing.Point(41, 104);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(188, 20);
            this.passwordBox.TabIndex = 5;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // signButton
            // 
            this.signButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signButton.Location = new System.Drawing.Point(98, 204);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(75, 23);
            this.signButton.TabIndex = 6;
            this.signButton.Text = "Zarejestruj";
            this.signButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 252);
            this.Controls.Add(this.signButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.signLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.loginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logowanie";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_FormClosed);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label signLabel;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button signButton;
    }
}