namespace SOSM1
{
    partial class SignUp
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.mailLabel = new System.Windows.Forms.Label();
            this.userNameBox = new System.Windows.Forms.TextBox();
            this.mailBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.repeatPasswordLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.repeatPasswordBox = new System.Windows.Forms.TextBox();
            this.signButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(96, 29);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(105, 13);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Nazwa użytkownika:";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Location = new System.Drawing.Point(115, 69);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(67, 13);
            this.mailLabel.TabIndex = 1;
            this.mailLabel.Text = "Adres e-mail:";
            this.mailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userNameBox
            // 
            this.userNameBox.Location = new System.Drawing.Point(56, 46);
            this.userNameBox.Name = "userNameBox";
            this.userNameBox.Size = new System.Drawing.Size(184, 20);
            this.userNameBox.TabIndex = 2;
            // 
            // mailBox
            // 
            this.mailBox.Location = new System.Drawing.Point(56, 85);
            this.mailBox.Name = "mailBox";
            this.mailBox.Size = new System.Drawing.Size(184, 20);
            this.mailBox.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(129, 108);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(39, 13);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Hasło:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // repeatPasswordLabel
            // 
            this.repeatPasswordLabel.AutoSize = true;
            this.repeatPasswordLabel.Location = new System.Drawing.Point(105, 147);
            this.repeatPasswordLabel.Name = "repeatPasswordLabel";
            this.repeatPasswordLabel.Size = new System.Drawing.Size(86, 13);
            this.repeatPasswordLabel.TabIndex = 5;
            this.repeatPasswordLabel.Text = "Potwierdź hasło:";
            this.repeatPasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(56, 124);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(184, 20);
            this.passwordBox.TabIndex = 6;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // repeatPasswordBox
            // 
            this.repeatPasswordBox.Location = new System.Drawing.Point(56, 163);
            this.repeatPasswordBox.Name = "repeatPasswordBox";
            this.repeatPasswordBox.Size = new System.Drawing.Size(184, 20);
            this.repeatPasswordBox.TabIndex = 7;
            this.repeatPasswordBox.UseSystemPasswordChar = true;
            // 
            // signButton
            // 
            this.signButton.Location = new System.Drawing.Point(111, 189);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(75, 23);
            this.signButton.TabIndex = 8;
            this.signButton.Text = "Zarejestruj";
            this.signButton.UseVisualStyleBackColor = true;
            this.signButton.Click += new System.EventHandler(this.signButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(111, 227);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Wróć";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // SignUp
            // 
            this.AcceptButton = this.signButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 262);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.signButton);
            this.Controls.Add(this.repeatPasswordBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.repeatPasswordLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.mailBox);
            this.Controls.Add(this.userNameBox);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.userNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Rejestracja";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.TextBox userNameBox;
        private System.Windows.Forms.TextBox mailBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label repeatPasswordLabel;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox repeatPasswordBox;
        private System.Windows.Forms.Button signButton;
        private System.Windows.Forms.Button cancelButton;
    }
}