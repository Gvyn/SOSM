namespace SOSM1
{
    partial class ProfileUserControl
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
            this.nameDesclabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.mailDescLabel = new System.Windows.Forms.Label();
            this.mailLabel = new System.Windows.Forms.Label();
            this.historyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameDesclabel
            // 
            this.nameDesclabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.nameDesclabel.Location = new System.Drawing.Point(123, 64);
            this.nameDesclabel.Name = "nameDesclabel";
            this.nameDesclabel.Size = new System.Drawing.Size(140, 23);
            this.nameDesclabel.TabIndex = 0;
            this.nameDesclabel.Text = "Nazwa użykownika:";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.nameLabel.Location = new System.Drawing.Point(269, 64);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(278, 23);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "User_Name";
            // 
            // mailDescLabel
            // 
            this.mailDescLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.mailDescLabel.Location = new System.Drawing.Point(123, 100);
            this.mailDescLabel.Name = "mailDescLabel";
            this.mailDescLabel.Size = new System.Drawing.Size(140, 23);
            this.mailDescLabel.TabIndex = 2;
            this.mailDescLabel.Text = "Adres e-mail:";
            // 
            // mailLabel
            // 
            this.mailLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.mailLabel.Location = new System.Drawing.Point(269, 100);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(278, 23);
            this.mailLabel.TabIndex = 3;
            this.mailLabel.Text = "User_Mail";
            // 
            // historyButton
            // 
            this.historyButton.Font = new System.Drawing.Font("Arial", 11.25F);
            this.historyButton.Location = new System.Drawing.Point(126, 161);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(239, 23);
            this.historyButton.TabIndex = 4;
            this.historyButton.Text = "Historia transakcji";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // ProfileUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.historyButton);
            this.Controls.Add(this.mailLabel);
            this.Controls.Add(this.mailDescLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameDesclabel);
            this.Name = "ProfileUserControl";
            this.Size = new System.Drawing.Size(712, 474);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label nameDesclabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label mailDescLabel;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.Button historyButton;
    }
}
