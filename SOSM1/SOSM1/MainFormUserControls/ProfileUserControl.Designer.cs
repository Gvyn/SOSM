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
            this.DescLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeDescLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.stateDescLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameDesclabel
            // 
            this.nameDesclabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.nameDesclabel.Location = new System.Drawing.Point(124, 64);
            this.nameDesclabel.Name = "nameDesclabel";
            this.nameDesclabel.Size = new System.Drawing.Size(140, 23);
            this.nameDesclabel.TabIndex = 0;
            this.nameDesclabel.Text = "Nazwa użykownika:";
            // 
            // nameLabel
            // 
            this.nameLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.nameLabel.Location = new System.Drawing.Point(270, 64);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(278, 23);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "User_Name";
            // 
            // mailDescLabel
            // 
            this.mailDescLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.mailDescLabel.Location = new System.Drawing.Point(124, 97);
            this.mailDescLabel.Name = "mailDescLabel";
            this.mailDescLabel.Size = new System.Drawing.Size(140, 23);
            this.mailDescLabel.TabIndex = 2;
            this.mailDescLabel.Text = "Adres e-mail:";
            // 
            // mailLabel
            // 
            this.mailLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.mailLabel.Location = new System.Drawing.Point(270, 97);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(278, 23);
            this.mailLabel.TabIndex = 3;
            this.mailLabel.Text = "User_Mail";
            // 
            // historyButton
            // 
            this.historyButton.Font = new System.Drawing.Font("Arial", 11.25F);
            this.historyButton.Location = new System.Drawing.Point(126, 221);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(239, 25);
            this.historyButton.TabIndex = 4;
            this.historyButton.Text = "Historia transakcji";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // DescLabel
            // 
            this.DescLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.DescLabel.Location = new System.Drawing.Point(123, 27);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(242, 23);
            this.DescLabel.TabIndex = 5;
            this.DescLabel.Text = "Dane użytkownika:";
            // 
            // typeLabel
            // 
            this.typeLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.typeLabel.Location = new System.Drawing.Point(270, 130);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(278, 23);
            this.typeLabel.TabIndex = 7;
            this.typeLabel.Text = "User_Type";
            // 
            // typeDescLabel
            // 
            this.typeDescLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.typeDescLabel.Location = new System.Drawing.Point(124, 130);
            this.typeDescLabel.Name = "typeDescLabel";
            this.typeDescLabel.Size = new System.Drawing.Size(140, 23);
            this.typeDescLabel.TabIndex = 6;
            this.typeDescLabel.Text = "Typ konta:";
            // 
            // stateLabel
            // 
            this.stateLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.stateLabel.Location = new System.Drawing.Point(270, 163);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(278, 23);
            this.stateLabel.TabIndex = 9;
            this.stateLabel.Text = "User_State";
            // 
            // stateDescLabel
            // 
            this.stateDescLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.stateDescLabel.Location = new System.Drawing.Point(124, 163);
            this.stateDescLabel.Name = "stateDescLabel";
            this.stateDescLabel.Size = new System.Drawing.Size(140, 23);
            this.stateDescLabel.TabIndex = 8;
            this.stateDescLabel.Text = "Stan konta:";
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Arial", 11.25F);
            this.editButton.Location = new System.Drawing.Point(126, 261);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(239, 25);
            this.editButton.TabIndex = 10;
            this.editButton.Text = "Ustawienia konta";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // ProfileUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.stateDescLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.typeDescLabel);
            this.Controls.Add(this.DescLabel);
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
        private System.Windows.Forms.Label DescLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label typeDescLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label stateDescLabel;
        private System.Windows.Forms.Button editButton;
    }
}
