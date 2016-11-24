namespace SOSM1.AdminControls
{
    partial class ProductDataAdminControl
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
            this.amountBox = new System.Windows.Forms.TextBox();
            this.unitLabel = new System.Windows.Forms.Label();
            this.toBasketButton = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // amountBox
            // 
            this.amountBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.amountBox.Font = new System.Drawing.Font("Arial", 11.25F);
            this.amountBox.Location = new System.Drawing.Point(511, 46);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(139, 25);
            this.amountBox.TabIndex = 11;
            this.amountBox.Text = "0";
            // 
            // unitLabel
            // 
            this.unitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.unitLabel.Location = new System.Drawing.Point(415, 47);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(90, 23);
            this.unitLabel.TabIndex = 10;
            this.unitLabel.Text = "label2";
            this.unitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toBasketButton
            // 
            this.toBasketButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toBasketButton.Font = new System.Drawing.Font("Arial", 11.25F);
            this.toBasketButton.Location = new System.Drawing.Point(511, 7);
            this.toBasketButton.Name = "toBasketButton";
            this.toBasketButton.Size = new System.Drawing.Size(139, 33);
            this.toBasketButton.TabIndex = 9;
            this.toBasketButton.Text = "Do koszyka";
            this.toBasketButton.UseVisualStyleBackColor = true;
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.priceLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.priceLabel.Location = new System.Drawing.Point(137, 47);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(294, 24);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.Text = "label2";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productNameLabel
            // 
            this.productNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.productNameLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.productNameLabel.Location = new System.Drawing.Point(137, 15);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(294, 24);
            this.productNameLabel.TabIndex = 7;
            this.productNameLabel.Text = "label1";
            this.productNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productPictureBox
            // 
            this.productPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.productPictureBox.InitialImage = global::SOSM1.Properties.Resources.logoBig;
            this.productPictureBox.Location = new System.Drawing.Point(0, 0);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(106, 92);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPictureBox.TabIndex = 6;
            this.productPictureBox.TabStop = false;
            // 
            // ProductDataAdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.toBasketButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productPictureBox);
            this.Name = "ProductDataAdminControl";
            this.Size = new System.Drawing.Size(675, 92);
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.Button toBasketButton;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.PictureBox productPictureBox;
    }
}
