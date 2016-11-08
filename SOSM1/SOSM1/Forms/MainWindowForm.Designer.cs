namespace SOSM1
{
    partial class MainWindowForm
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
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.logoutButton = new System.Windows.Forms.Button();
            this.contactButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.productsButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainMenuPanel = new System.Windows.Forms.Panel();
            this.userControlPanel = new System.Windows.Forms.Panel();
            this.sectionLabelPanel = new System.Windows.Forms.Panel();
            this.sectionLabel = new System.Windows.Forms.Label();
            this.cartButton = new System.Windows.Forms.Button();
            this.cartSizeLabel = new System.Windows.Forms.Label();
            this.profileButton = new System.Windows.Forms.Button();
            this.sideMenuPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainMenuPanel.SuspendLayout();
            this.sectionLabelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.sideMenuPanel.Controls.Add(this.profileButton);
            this.sideMenuPanel.Controls.Add(this.cartSizeLabel);
            this.sideMenuPanel.Controls.Add(this.cartButton);
            this.sideMenuPanel.Controls.Add(this.sectionLabelPanel);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sideMenuPanel.Location = new System.Drawing.Point(200, 0);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(884, 66);
            this.sideMenuPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.homeButton);
            this.flowLayoutPanel1.Controls.Add(this.productsButton);
            this.flowLayoutPanel1.Controls.Add(this.adminButton);
            this.flowLayoutPanel1.Controls.Add(this.contactButton);
            this.flowLayoutPanel1.Controls.Add(this.logoutButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(30, 140);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(170, 446);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.logoutButton.Location = new System.Drawing.Point(3, 311);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(143, 71);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Wyloguj";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // contactButton
            // 
            this.contactButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.contactButton.Location = new System.Drawing.Point(3, 234);
            this.contactButton.Name = "contactButton";
            this.contactButton.Size = new System.Drawing.Size(143, 71);
            this.contactButton.TabIndex = 4;
            this.contactButton.Text = "Kontakt";
            this.contactButton.UseVisualStyleBackColor = true;
            this.contactButton.Click += new System.EventHandler(this.contactButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.adminButton.Location = new System.Drawing.Point(3, 157);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(143, 71);
            this.adminButton.TabIndex = 3;
            this.adminButton.Text = "Panel administracyjny";
            this.adminButton.UseVisualStyleBackColor = true;
            this.adminButton.Visible = false;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // productsButton
            // 
            this.productsButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.productsButton.Location = new System.Drawing.Point(3, 80);
            this.productsButton.Name = "productsButton";
            this.productsButton.Size = new System.Drawing.Size(143, 71);
            this.productsButton.TabIndex = 2;
            this.productsButton.Text = "Katalog produktów";
            this.productsButton.UseVisualStyleBackColor = true;
            this.productsButton.Click += new System.EventHandler(this.productsButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.homeButton.Location = new System.Drawing.Point(3, 3);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(143, 71);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Strona główna";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::SOSM1.Properties.Resources.logoBig;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // mainMenuPanel
            // 
            this.mainMenuPanel.AutoScroll = true;
            this.mainMenuPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.mainMenuPanel.Controls.Add(this.flowLayoutPanel1);
            this.mainMenuPanel.Controls.Add(this.pictureBox1);
            this.mainMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.mainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.mainMenuPanel.Name = "mainMenuPanel";
            this.mainMenuPanel.Size = new System.Drawing.Size(200, 586);
            this.mainMenuPanel.TabIndex = 1;
            // 
            // userControlPanel
            // 
            this.userControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlPanel.Location = new System.Drawing.Point(200, 66);
            this.userControlPanel.Name = "userControlPanel";
            this.userControlPanel.Size = new System.Drawing.Size(884, 520);
            this.userControlPanel.TabIndex = 2;
            // 
            // sectionLabelPanel
            // 
            this.sectionLabelPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sectionLabelPanel.BackColor = System.Drawing.SystemColors.Control;
            this.sectionLabelPanel.Controls.Add(this.sectionLabel);
            this.sectionLabelPanel.Location = new System.Drawing.Point(0, 23);
            this.sectionLabelPanel.Name = "sectionLabelPanel";
            this.sectionLabelPanel.Size = new System.Drawing.Size(452, 43);
            this.sectionLabelPanel.TabIndex = 0;
            // 
            // sectionLabel
            // 
            this.sectionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sectionLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sectionLabel.Location = new System.Drawing.Point(0, 0);
            this.sectionLabel.Name = "sectionLabel";
            this.sectionLabel.Size = new System.Drawing.Size(452, 43);
            this.sectionLabel.TabIndex = 0;
            this.sectionLabel.Text = "Section_Name";
            this.sectionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cartButton
            // 
            this.cartButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cartButton.Location = new System.Drawing.Point(468, 23);
            this.cartButton.Name = "cartButton";
            this.cartButton.Size = new System.Drawing.Size(108, 37);
            this.cartButton.TabIndex = 1;
            this.cartButton.Text = "Koszyk";
            this.cartButton.UseVisualStyleBackColor = true;
            // 
            // cartSizeLabel
            // 
            this.cartSizeLabel.BackColor = System.Drawing.SystemColors.Control;
            this.cartSizeLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.cartSizeLabel.Location = new System.Drawing.Point(582, 23);
            this.cartSizeLabel.Name = "cartSizeLabel";
            this.cartSizeLabel.Size = new System.Drawing.Size(66, 37);
            this.cartSizeLabel.TabIndex = 2;
            this.cartSizeLabel.Text = "0";
            this.cartSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // profileButton
            // 
            this.profileButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.profileButton.Location = new System.Drawing.Point(670, 23);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(188, 37);
            this.profileButton.TabIndex = 3;
            this.profileButton.Text = "User_Name";
            this.profileButton.UseVisualStyleBackColor = true;
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 586);
            this.Controls.Add(this.userControlPanel);
            this.Controls.Add(this.sideMenuPanel);
            this.Controls.Add(this.mainMenuPanel);
            this.Name = "MainWindowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SOSM";
            this.Load += new System.EventHandler(this.MainWindowForm_Load);
            this.sideMenuPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainMenuPanel.ResumeLayout(false);
            this.sectionLabelPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideMenuPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button productsButton;
        private System.Windows.Forms.Button adminButton;
        private System.Windows.Forms.Button contactButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel mainMenuPanel;
        private System.Windows.Forms.Panel userControlPanel;
        private System.Windows.Forms.Panel sectionLabelPanel;
        private System.Windows.Forms.Button cartButton;
        private System.Windows.Forms.Label sectionLabel;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Label cartSizeLabel;
    }
}