namespace SOSM1.AdminControls
{
    partial class SettingsAdminControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.contactInfoButton = new System.Windows.Forms.Button();
            this.contactInfoTextbox = new System.Windows.Forms.TextBox();
            this.welcomeMessageButton = new System.Windows.Forms.Button();
            this.welcomeMessageTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // contactInfoButton
            // 
            this.contactInfoButton.Location = new System.Drawing.Point(363, 182);
            this.contactInfoButton.Name = "contactInfoButton";
            this.contactInfoButton.Size = new System.Drawing.Size(163, 35);
            this.contactInfoButton.TabIndex = 7;
            this.contactInfoButton.Text = "Zmień dane kontaktowe";
            this.contactInfoButton.UseVisualStyleBackColor = true;
            this.contactInfoButton.Click += new System.EventHandler(this.contactInfoButton_Click);
            // 
            // contactInfoTextbox
            // 
            this.contactInfoTextbox.Location = new System.Drawing.Point(27, 156);
            this.contactInfoTextbox.MinimumSize = new System.Drawing.Size(300, 80);
            this.contactInfoTextbox.Multiline = true;
            this.contactInfoTextbox.Name = "contactInfoTextbox";
            this.contactInfoTextbox.Size = new System.Drawing.Size(300, 80);
            this.contactInfoTextbox.TabIndex = 6;
            // 
            // welcomeMessageButton
            // 
            this.welcomeMessageButton.Location = new System.Drawing.Point(363, 50);
            this.welcomeMessageButton.Name = "welcomeMessageButton";
            this.welcomeMessageButton.Size = new System.Drawing.Size(163, 35);
            this.welcomeMessageButton.TabIndex = 5;
            this.welcomeMessageButton.Text = "Zmień wiadomość powitalną";
            this.welcomeMessageButton.UseVisualStyleBackColor = true;
            this.welcomeMessageButton.Click += new System.EventHandler(this.welcomeMessageButton_Click);
            // 
            // welcomeMessageTextbox
            // 
            this.welcomeMessageTextbox.Location = new System.Drawing.Point(27, 28);
            this.welcomeMessageTextbox.MinimumSize = new System.Drawing.Size(300, 80);
            this.welcomeMessageTextbox.Multiline = true;
            this.welcomeMessageTextbox.Name = "welcomeMessageTextbox";
            this.welcomeMessageTextbox.Size = new System.Drawing.Size(300, 80);
            this.welcomeMessageTextbox.TabIndex = 4;
            // 
            // SettingsAdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.contactInfoButton);
            this.Controls.Add(this.contactInfoTextbox);
            this.Controls.Add(this.welcomeMessageButton);
            this.Controls.Add(this.welcomeMessageTextbox);
            this.Name = "SettingsAdminControl";
            this.Size = new System.Drawing.Size(555, 367);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button contactInfoButton;
        private System.Windows.Forms.TextBox contactInfoTextbox;
        private System.Windows.Forms.Button welcomeMessageButton;
        private System.Windows.Forms.TextBox welcomeMessageTextbox;
    }
}
