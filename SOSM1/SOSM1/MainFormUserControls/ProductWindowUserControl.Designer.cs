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
            this.amountLabel = new System.Windows.Forms.Label();
            this.categoryFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.categoryRootLabel = new System.Windows.Forms.Label();
            this.currentCategoryLabel = new System.Windows.Forms.Label();
            this.currentObjectLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.toBasketButton = new System.Windows.Forms.Button();
            this.unitLabel = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.inBasketDescriptionLabel = new System.Windows.Forms.Label();
            this.inBasketLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.categoryFlowPanel.SuspendLayout();
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
            this.descriptionLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.descriptionLabel.Location = new System.Drawing.Point(363, 56);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(278, 293);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "Product_Description";
            // 
            // descriptionDescriptionLabel
            // 
            this.descriptionDescriptionLabel.AutoSize = true;
            this.descriptionDescriptionLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriptionDescriptionLabel.Location = new System.Drawing.Point(319, 56);
            this.descriptionDescriptionLabel.Name = "descriptionDescriptionLabel";
            this.descriptionDescriptionLabel.Size = new System.Drawing.Size(43, 17);
            this.descriptionDescriptionLabel.TabIndex = 2;
            this.descriptionDescriptionLabel.Text = "Opis:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.priceLabel.Location = new System.Drawing.Point(17, 347);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(73, 17);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Price_Info";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.amountLabel.Location = new System.Drawing.Point(17, 367);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(89, 17);
            this.amountLabel.TabIndex = 5;
            this.amountLabel.Text = "Amount_info";
            // 
            // categoryFlowPanel
            // 
            this.categoryFlowPanel.Controls.Add(this.categoryRootLabel);
            this.categoryFlowPanel.Controls.Add(this.currentCategoryLabel);
            this.categoryFlowPanel.Controls.Add(this.currentObjectLabel);
            this.categoryFlowPanel.Location = new System.Drawing.Point(20, 16);
            this.categoryFlowPanel.Name = "categoryFlowPanel";
            this.categoryFlowPanel.Size = new System.Drawing.Size(358, 34);
            this.categoryFlowPanel.TabIndex = 6;
            // 
            // categoryRootLabel
            // 
            this.categoryRootLabel.AutoSize = true;
            this.categoryRootLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.categoryRootLabel.Location = new System.Drawing.Point(3, 0);
            this.categoryRootLabel.Margin = new System.Windows.Forms.Padding(3, 0, 1, 0);
            this.categoryRootLabel.Name = "categoryRootLabel";
            this.categoryRootLabel.Size = new System.Drawing.Size(135, 17);
            this.categoryRootLabel.TabIndex = 0;
            this.categoryRootLabel.Text = "Wszystkie produkty";
            this.categoryRootLabel.Click += new System.EventHandler(this.categoryRootLabel_Click);
            // 
            // currentCategoryLabel
            // 
            this.currentCategoryLabel.AutoSize = true;
            this.currentCategoryLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.currentCategoryLabel.Location = new System.Drawing.Point(140, 0);
            this.currentCategoryLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.currentCategoryLabel.Name = "currentCategoryLabel";
            this.currentCategoryLabel.Size = new System.Drawing.Size(120, 17);
            this.currentCategoryLabel.TabIndex = 1;
            this.currentCategoryLabel.Text = "Current Category";
            this.currentCategoryLabel.Click += new System.EventHandler(this.currentCategoryLabel_Click);
            // 
            // currentObjectLabel
            // 
            this.currentObjectLabel.AutoSize = true;
            this.currentObjectLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.currentObjectLabel.Location = new System.Drawing.Point(1, 17);
            this.currentObjectLabel.Margin = new System.Windows.Forms.Padding(1, 0, 3, 0);
            this.currentObjectLabel.Name = "currentObjectLabel";
            this.currentObjectLabel.Size = new System.Drawing.Size(135, 17);
            this.currentObjectLabel.TabIndex = 2;
            this.currentObjectLabel.Text = "CurrentObjectLabel";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTextBox.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
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
            this.searchButton.Font = new System.Drawing.Font("Arial", 9F);
            this.searchButton.Location = new System.Drawing.Point(609, 14);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Wyszukaj";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // toBasketButton
            // 
            this.toBasketButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.toBasketButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.toBasketButton.Location = new System.Drawing.Point(542, 354);
            this.toBasketButton.Name = "toBasketButton";
            this.toBasketButton.Size = new System.Drawing.Size(142, 23);
            this.toBasketButton.TabIndex = 9;
            this.toBasketButton.Text = "Dodaj do koszyka";
            this.toBasketButton.UseVisualStyleBackColor = true;
            this.toBasketButton.Click += new System.EventHandler(this.toBasketButton_Click);
            // 
            // unitLabel
            // 
            this.unitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.unitLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.unitLabel.Location = new System.Drawing.Point(503, 383);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(100, 23);
            this.unitLabel.TabIndex = 10;
            this.unitLabel.Text = "Unit_type";
            this.unitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // amountBox
            // 
            this.amountBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.amountBox.Location = new System.Drawing.Point(609, 383);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(75, 20);
            this.amountBox.TabIndex = 11;
            this.amountBox.Text = "0";
            this.amountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // inBasketDescriptionLabel
            // 
            this.inBasketDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inBasketDescriptionLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.inBasketDescriptionLabel.Location = new System.Drawing.Point(492, 406);
            this.inBasketDescriptionLabel.Name = "inBasketDescriptionLabel";
            this.inBasketDescriptionLabel.Size = new System.Drawing.Size(121, 23);
            this.inBasketDescriptionLabel.TabIndex = 12;
            this.inBasketDescriptionLabel.Text = "Już w koszyku:";
            this.inBasketDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inBasketLabel
            // 
            this.inBasketLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inBasketLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.inBasketLabel.Location = new System.Drawing.Point(609, 406);
            this.inBasketLabel.Name = "inBasketLabel";
            this.inBasketLabel.Size = new System.Drawing.Size(75, 23);
            this.inBasketLabel.TabIndex = 13;
            this.inBasketLabel.Text = "InBasket";
            this.inBasketLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductWindowUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.inBasketLabel);
            this.Controls.Add(this.inBasketDescriptionLabel);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.toBasketButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.categoryFlowPanel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.descriptionDescriptionLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.productPictureBox);
            this.Name = "ProductWindowUserControl";
            this.Size = new System.Drawing.Size(712, 454);
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.categoryFlowPanel.ResumeLayout(false);
            this.categoryFlowPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox productPictureBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label descriptionDescriptionLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.FlowLayoutPanel categoryFlowPanel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button toBasketButton;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label inBasketDescriptionLabel;
        private System.Windows.Forms.Label inBasketLabel;
        private System.Windows.Forms.Label categoryRootLabel;
        private System.Windows.Forms.Label currentCategoryLabel;
        private System.Windows.Forms.Label currentObjectLabel;
    }
}
