namespace SOSM1.AdminControls
{
    partial class ProductsAdminControl
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
            this.addProductButton = new System.Windows.Forms.Button();
            this.categoryButton = new System.Windows.Forms.Button();
            this.searchProductsButton = new System.Windows.Forms.Button();
            this.searchProductsLabel = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // addProductButton
            // 
            this.addProductButton.Location = new System.Drawing.Point(20, 20);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(96, 30);
            this.addProductButton.TabIndex = 0;
            this.addProductButton.Text = "DODAJ+";
            this.addProductButton.UseVisualStyleBackColor = true;
            // 
            // categoryButton
            // 
            this.categoryButton.Location = new System.Drawing.Point(142, 20);
            this.categoryButton.Name = "categoryButton";
            this.categoryButton.Size = new System.Drawing.Size(127, 30);
            this.categoryButton.TabIndex = 1;
            this.categoryButton.Text = "EDYTUJ KATEGORIE";
            this.categoryButton.UseVisualStyleBackColor = true;
            // 
            // searchProductsButton
            // 
            this.searchProductsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchProductsButton.Location = new System.Drawing.Point(645, 20);
            this.searchProductsButton.Name = "searchProductsButton";
            this.searchProductsButton.Size = new System.Drawing.Size(96, 30);
            this.searchProductsButton.TabIndex = 2;
            this.searchProductsButton.Text = "WYSZUKAJ";
            this.searchProductsButton.UseVisualStyleBackColor = true;
            // 
            // searchProductsLabel
            // 
            this.searchProductsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchProductsLabel.Location = new System.Drawing.Point(292, 26);
            this.searchProductsLabel.Name = "searchProductsLabel";
            this.searchProductsLabel.Size = new System.Drawing.Size(347, 20);
            this.searchProductsLabel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 348);
            this.panel1.TabIndex = 4;
            // 
            // ProductsAdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchProductsLabel);
            this.Controls.Add(this.searchProductsButton);
            this.Controls.Add(this.categoryButton);
            this.Controls.Add(this.addProductButton);
            this.Name = "ProductsAdminControl";
            this.Size = new System.Drawing.Size(760, 420);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button categoryButton;
        private System.Windows.Forms.Button searchProductsButton;
        private System.Windows.Forms.TextBox searchProductsLabel;
        private System.Windows.Forms.Panel panel1;
    }
}
