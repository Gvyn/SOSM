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
            this.components = new System.ComponentModel.Container();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            this.imageButton = new System.Windows.Forms.Button();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.amountTextbox = new System.Windows.Forms.TextBox();
            this.priceTextbox = new System.Windows.Forms.TextBox();
            this.unitCheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveChangesButton.Font = new System.Drawing.Font("Arial", 11.25F);
            this.saveChangesButton.Location = new System.Drawing.Point(733, 56);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(113, 34);
            this.saveChangesButton.TabIndex = 9;
            this.saveChangesButton.Text = "ZAPISZ";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            // 
            // productPictureBox
            // 
            this.productPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.productPictureBox.InitialImage = global::SOSM1.Properties.Resources.logoBig;
            this.productPictureBox.Location = new System.Drawing.Point(0, 0);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(137, 183);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.productPictureBox.TabIndex = 6;
            this.productPictureBox.TabStop = false;
            // 
            // imageButton
            // 
            this.imageButton.Location = new System.Drawing.Point(143, 3);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(75, 45);
            this.imageButton.TabIndex = 10;
            this.imageButton.Text = "ZMIEŃ OBRAZEK";
            this.imageButton.UseVisualStyleBackColor = true;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(224, 13);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(182, 20);
            this.nameTextbox.TabIndex = 11;
            // 
            // amountTextbox
            // 
            this.amountTextbox.Location = new System.Drawing.Point(224, 39);
            this.amountTextbox.Name = "amountTextbox";
            this.amountTextbox.Size = new System.Drawing.Size(48, 20);
            this.amountTextbox.TabIndex = 12;
            // 
            // priceTextbox
            // 
            this.priceTextbox.Location = new System.Drawing.Point(224, 65);
            this.priceTextbox.Name = "priceTextbox";
            this.priceTextbox.Size = new System.Drawing.Size(48, 20);
            this.priceTextbox.TabIndex = 13;
            // 
            // unitCheckedListBox1
            // 
            this.unitCheckedListBox1.FormattingEnabled = true;
            this.unitCheckedListBox1.Items.AddRange(new object[] {
            "sztuki",
            "kilogramy",
            "litry"});
            this.unitCheckedListBox1.Location = new System.Drawing.Point(224, 92);
            this.unitCheckedListBox1.Name = "unitCheckedListBox1";
            this.unitCheckedListBox1.Size = new System.Drawing.Size(115, 49);
            this.unitCheckedListBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(412, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "NAZWA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(412, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "ILOŚĆ NA SKŁADZIE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "CENA W ZŁ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(412, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "JEDNOSTKA";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoriesBindingSource, "CategoryID", true));
            this.categoryComboBox.DataSource = this.categoriesBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(224, 148);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(182, 21);
            this.categoryComboBox.TabIndex = 19;
            this.categoryComboBox.ValueMember = "CategoryID";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataSource = typeof(SOSM1.Categories);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(412, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "KATEGORIA";
            // 
            // ProductDataAdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unitCheckedListBox1);
            this.Controls.Add(this.priceTextbox);
            this.Controls.Add(this.amountTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.imageButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.productPictureBox);
            this.Name = "ProductDataAdminControl";
            this.Size = new System.Drawing.Size(860, 183);
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.PictureBox productPictureBox;
        private System.Windows.Forms.Button imageButton;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.TextBox amountTextbox;
        private System.Windows.Forms.TextBox priceTextbox;
        private System.Windows.Forms.CheckedListBox unitCheckedListBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private System.Windows.Forms.Label label5;
    }
}
