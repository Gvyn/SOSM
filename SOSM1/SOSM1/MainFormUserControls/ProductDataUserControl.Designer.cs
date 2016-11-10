namespace SOSM1
{
    partial class ProductDataUserControl
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
            this.productNameLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.toBasketButton = new System.Windows.Forms.Button();
            this.unitLabel = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // productPictureBox
            // 
            this.productPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.productPictureBox.InitialImage = global::SOSM1.Properties.Resources.logoBig;
            this.productPictureBox.Location = new System.Drawing.Point(0, 0);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(106, 90);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPictureBox.TabIndex = 0;
            this.productPictureBox.TabStop = false;
            this.productPictureBox.Click += new System.EventHandler(this.productNameLabel_Click);
            // 
            // productNameLabel
            // 
            this.productNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.productNameLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.productNameLabel.Location = new System.Drawing.Point(112, 15);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(294, 24);
            this.productNameLabel.TabIndex = 1;
            this.productNameLabel.Text = "label1";
            this.productNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productNameLabel.Click += new System.EventHandler(this.productNameLabel_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.priceLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.priceLabel.Location = new System.Drawing.Point(112, 47);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(294, 24);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "label2";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toBasketButton
            // 
            this.toBasketButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toBasketButton.Font = new System.Drawing.Font("Arial", 11.25F);
            this.toBasketButton.Location = new System.Drawing.Point(486, 7);
            this.toBasketButton.Name = "toBasketButton";
            this.toBasketButton.Size = new System.Drawing.Size(139, 33);
            this.toBasketButton.TabIndex = 3;
            this.toBasketButton.Text = "Do koszyka";
            this.toBasketButton.UseVisualStyleBackColor = true;
            this.toBasketButton.Click += new System.EventHandler(this.toBasketButton_Click);
            // 
            // unitLabel
            // 
            this.unitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.unitLabel.Font = new System.Drawing.Font("Arial", 11.25F);
            this.unitLabel.Location = new System.Drawing.Point(390, 47);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(90, 23);
            this.unitLabel.TabIndex = 4;
            this.unitLabel.Text = "label2";
            this.unitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // amountBox
            // 
            this.amountBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.amountBox.Font = new System.Drawing.Font("Arial", 11.25F);
            this.amountBox.Location = new System.Drawing.Point(486, 46);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(139, 25);
            this.amountBox.TabIndex = 5;
            this.amountBox.Text = "0";
            // 
            // ProductDataUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.toBasketButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productPictureBox);
            this.Name = "ProductDataUserControl";
            this.Size = new System.Drawing.Size(628, 90);
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox productPictureBox;
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button toBasketButton;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.TextBox amountBox;
    }
}
