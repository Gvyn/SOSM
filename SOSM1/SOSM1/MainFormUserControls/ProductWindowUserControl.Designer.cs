namespace SOSM1
{
    partial class ProductWindowUserControl
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
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionDescriptionLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.noPictureLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.categoryFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // productPictureBox
            // 
            this.productPictureBox.Location = new System.Drawing.Point(20, 56);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(263, 254);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPictureBox.TabIndex = 0;
            this.productPictureBox.TabStop = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriptionLabel.Location = new System.Drawing.Point(363, 56);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(278, 293);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Product_Description";
            // 
            // descriptionDescriptionLabel
            // 
            this.descriptionDescriptionLabel.AutoSize = true;
            this.descriptionDescriptionLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.descriptionDescriptionLabel.Location = new System.Drawing.Point(319, 56);
            this.descriptionDescriptionLabel.Name = "descriptionDescriptionLabel";
            this.descriptionDescriptionLabel.Size = new System.Drawing.Size(38, 20);
            this.descriptionDescriptionLabel.TabIndex = 2;
            this.descriptionDescriptionLabel.Text = "Opis:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priceLabel.Location = new System.Drawing.Point(17, 347);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(65, 20);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Price_Info";
            // 
            // noPictureLabel
            // 
            this.noPictureLabel.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.noPictureLabel.Location = new System.Drawing.Point(20, 237);
            this.noPictureLabel.Name = "noPictureLabel";
            this.noPictureLabel.Size = new System.Drawing.Size(263, 73);
            this.noPictureLabel.TabIndex = 4;
            this.noPictureLabel.Text = "No_Picture_Info";
            this.noPictureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.noPictureLabel.Visible = false;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.amountLabel.Location = new System.Drawing.Point(17, 367);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(78, 20);
            this.amountLabel.TabIndex = 5;
            this.amountLabel.Text = "Amount_info";
            // 
            // categoryFlowPanel
            // 
            this.categoryFlowPanel.Location = new System.Drawing.Point(20, 16);
            this.categoryFlowPanel.Name = "categoryFlowPanel";
            this.categoryFlowPanel.Size = new System.Drawing.Size(358, 34);
            this.categoryFlowPanel.TabIndex = 6;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.searchTextBox.Location = new System.Drawing.Point(415, 16);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(188, 21);
            this.searchTextBox.TabIndex = 7;
            this.searchTextBox.Text = "atrybut wyszukiwania";
            this.searchTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchButton.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.searchButton.Location = new System.Drawing.Point(609, 14);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Wyszukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // ProductWindowUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.categoryFlowPanel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.noPictureLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.descriptionDescriptionLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.productPictureBox);
            this.Name = "ProductWindowUserControl";
            this.Size = new System.Drawing.Size(712, 454);
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox productPictureBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label descriptionDescriptionLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label noPictureLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.FlowLayoutPanel categoryFlowPanel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
    }
}
