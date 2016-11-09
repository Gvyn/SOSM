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
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // productPictureBox
            // 
            this.productPictureBox.Location = new System.Drawing.Point(22, 74);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(263, 254);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPictureBox.TabIndex = 0;
            this.productPictureBox.TabStop = false;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Location = new System.Drawing.Point(365, 74);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(278, 293);
            this.descriptionLabel.TabIndex = 1;
            this.descriptionLabel.Text = "label1";
            // 
            // descriptionDescriptionLabel
            // 
            this.descriptionDescriptionLabel.AutoSize = true;
            this.descriptionDescriptionLabel.Location = new System.Drawing.Point(305, 74);
            this.descriptionDescriptionLabel.Name = "descriptionDescriptionLabel";
            this.descriptionDescriptionLabel.Size = new System.Drawing.Size(31, 13);
            this.descriptionDescriptionLabel.TabIndex = 2;
            this.descriptionDescriptionLabel.Text = "Opis:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(19, 365);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(35, 13);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "label1";
            // 
            // noPictureLabel
            // 
            this.noPictureLabel.Location = new System.Drawing.Point(22, 297);
            this.noPictureLabel.Name = "noPictureLabel";
            this.noPictureLabel.Size = new System.Drawing.Size(263, 31);
            this.noPictureLabel.TabIndex = 4;
            this.noPictureLabel.Text = "label2";
            this.noPictureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.noPictureLabel.Visible = false;
            // 
            // ProductWindowUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.noPictureLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.descriptionDescriptionLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.productPictureBox);
            this.Name = "ProductWindowUserControl";
            this.Size = new System.Drawing.Size(712, 456);
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
    }
}
