namespace SOSM1
{
    partial class BasketDataUserControl
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
            this.productNameLabel = new System.Windows.Forms.Label();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.sumPriceLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productNameLabel
            // 
            this.productNameLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.productNameLabel.Location = new System.Drawing.Point(1, 1);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(198, 33);
            this.productNameLabel.TabIndex = 0;
            this.productNameLabel.Text = "Product_Name";
            this.productNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productNameLabel.Click += new System.EventHandler(this.productNameLabel_Click);
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.productPriceLabel.Location = new System.Drawing.Point(205, 1);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(189, 33);
            this.productPriceLabel.TabIndex = 1;
            this.productPriceLabel.Text = "Product_Price";
            this.productPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // amountBox
            // 
            this.amountBox.Font = new System.Drawing.Font("Arial", 14F);
            this.amountBox.Location = new System.Drawing.Point(400, 3);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(78, 29);
            this.amountBox.TabIndex = 2;
            this.amountBox.Text = "Amount";
            this.amountBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sumPriceLabel
            // 
            this.sumPriceLabel.Font = new System.Drawing.Font("Arial", 14F);
            this.sumPriceLabel.Location = new System.Drawing.Point(484, 1);
            this.sumPriceLabel.Name = "sumPriceLabel";
            this.sumPriceLabel.Size = new System.Drawing.Size(166, 33);
            this.sumPriceLabel.TabIndex = 3;
            this.sumPriceLabel.Text = "Summed_Price";
            this.sumPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Arial", 14F);
            this.removeButton.Location = new System.Drawing.Point(664, -1);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 35);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Usuń";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // BasketDataUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.sumPriceLabel);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.productPriceLabel);
            this.Controls.Add(this.productNameLabel);
            this.Name = "BasketDataUserControl";
            this.Size = new System.Drawing.Size(742, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label sumPriceLabel;
        private System.Windows.Forms.Button removeButton;
    }
}
