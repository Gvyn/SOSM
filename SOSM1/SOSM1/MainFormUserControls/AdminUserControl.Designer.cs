namespace SOSM1
{
    partial class AdminUserControl
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
            this.lineLabel = new System.Windows.Forms.Label();
            this.buttonProducts = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonSales = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.adminControlPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lineLabel
            // 
            this.lineLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lineLabel.Location = new System.Drawing.Point(20, 50);
            this.lineLabel.Margin = new System.Windows.Forms.Padding(3, 60, 3, 20);
            this.lineLabel.MaximumSize = new System.Drawing.Size(2, 2);
            this.lineLabel.MinimumSize = new System.Drawing.Size(700, 2);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(700, 2);
            this.lineLabel.TabIndex = 0;
            this.lineLabel.Text = "label1";
            // 
            // buttonProducts
            // 
            this.buttonProducts.Location = new System.Drawing.Point(20, 10);
            this.buttonProducts.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.buttonProducts.MaximumSize = new System.Drawing.Size(100, 30);
            this.buttonProducts.MinimumSize = new System.Drawing.Size(100, 30);
            this.buttonProducts.Name = "buttonProducts";
            this.buttonProducts.Size = new System.Drawing.Size(100, 30);
            this.buttonProducts.TabIndex = 1;
            this.buttonProducts.Text = "PRODUKTY";
            this.buttonProducts.UseVisualStyleBackColor = true;
            this.buttonProducts.Click += new System.EventHandler(this.buttonProducts_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.Location = new System.Drawing.Point(143, 10);
            this.buttonUsers.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.buttonUsers.MaximumSize = new System.Drawing.Size(100, 30);
            this.buttonUsers.MinimumSize = new System.Drawing.Size(100, 30);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(100, 30);
            this.buttonUsers.TabIndex = 2;
            this.buttonUsers.Text = "UŻYTKOWNICY";
            this.buttonUsers.UseVisualStyleBackColor = true;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsers_Click);
            // 
            // buttonSales
            // 
            this.buttonSales.Location = new System.Drawing.Point(266, 10);
            this.buttonSales.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.buttonSales.MaximumSize = new System.Drawing.Size(100, 30);
            this.buttonSales.MinimumSize = new System.Drawing.Size(100, 30);
            this.buttonSales.Name = "buttonSales";
            this.buttonSales.Size = new System.Drawing.Size(100, 30);
            this.buttonSales.TabIndex = 3;
            this.buttonSales.Text = "TRANSAKCJE";
            this.buttonSales.UseVisualStyleBackColor = true;
            this.buttonSales.Click += new System.EventHandler(this.buttonSales_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.Location = new System.Drawing.Point(389, 10);
            this.buttonSettings.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.buttonSettings.MaximumSize = new System.Drawing.Size(100, 30);
            this.buttonSettings.MinimumSize = new System.Drawing.Size(100, 30);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(100, 30);
            this.buttonSettings.TabIndex = 4;
            this.buttonSettings.Text = "USTAWIENIA";
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // adminControlPanel
            // 
            this.adminControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminControlPanel.Location = new System.Drawing.Point(4, 55);
            this.adminControlPanel.Name = "adminControlPanel";
            this.adminControlPanel.Size = new System.Drawing.Size(744, 405);
            this.adminControlPanel.TabIndex = 5;
            // 
            // AdminUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.adminControlPanel);
            this.Controls.Add(this.buttonSettings);
            this.Controls.Add(this.buttonSales);
            this.Controls.Add(this.buttonUsers);
            this.Controls.Add(this.buttonProducts);
            this.Controls.Add(this.lineLabel);
            this.Name = "AdminUserControl";
            this.Size = new System.Drawing.Size(751, 463);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lineLabel;
        private System.Windows.Forms.Button buttonProducts;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonSales;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Panel adminControlPanel;
    }
}
