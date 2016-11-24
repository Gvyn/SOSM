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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.activateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveChangesButton.Location = new System.Drawing.Point(44, 337);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(113, 54);
            this.saveChangesButton.TabIndex = 9;
            this.saveChangesButton.Text = "ZAPISZ ZMIANY";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // productPictureBox
            // 
            this.productPictureBox.InitialImage = global::SOSM1.Properties.Resources.logoBig;
            this.productPictureBox.Location = new System.Drawing.Point(0, 0);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(200, 200);
            this.productPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.productPictureBox.TabIndex = 6;
            this.productPictureBox.TabStop = false;
            // 
            // imageButton
            // 
            this.imageButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imageButton.Location = new System.Drawing.Point(44, 206);
            this.imageButton.Name = "imageButton";
            this.imageButton.Size = new System.Drawing.Size(113, 45);
            this.imageButton.TabIndex = 10;
            this.imageButton.Text = "ZMIEŃ OBRAZEK";
            this.imageButton.UseVisualStyleBackColor = true;
            this.imageButton.Click += new System.EventHandler(this.imageButton_Click);
            // 
            // nameTextbox
            // 
            this.nameTextbox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameTextbox.Location = new System.Drawing.Point(224, 8);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(334, 25);
            this.nameTextbox.TabIndex = 11;
            // 
            // amountTextbox
            // 
            this.amountTextbox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.amountTextbox.Location = new System.Drawing.Point(224, 39);
            this.amountTextbox.Name = "amountTextbox";
            this.amountTextbox.Size = new System.Drawing.Size(172, 25);
            this.amountTextbox.TabIndex = 12;
            // 
            // priceTextbox
            // 
            this.priceTextbox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.priceTextbox.Location = new System.Drawing.Point(224, 70);
            this.priceTextbox.Name = "priceTextbox";
            this.priceTextbox.Size = new System.Drawing.Size(172, 25);
            this.priceTextbox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(564, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "NAZWA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(564, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "ILOŚĆ NA SKŁADZIE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(564, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "CENA W ZŁ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(564, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "JEDNOSTKA";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoriesBindingSource, "CategoryID", true));
            this.categoryComboBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(224, 212);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(334, 25);
            this.categoryComboBox.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(569, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "KATEGORIA";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.descriptionTextBox.Location = new System.Drawing.Point(224, 255);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(335, 187);
            this.descriptionTextBox.TabIndex = 21;
            this.descriptionTextBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(569, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "OPIS";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton1.Location = new System.Drawing.Point(224, 134);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 21);
            this.radioButton1.TabIndex = 23;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "sztuki";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton2.Location = new System.Drawing.Point(224, 161);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 21);
            this.radioButton2.TabIndex = 24;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "kilogramy";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.radioButton3.Location = new System.Drawing.Point(224, 185);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(48, 21);
            this.radioButton3.TabIndex = 25;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "litry";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(571, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "STAN:";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.stateLabel.Location = new System.Drawing.Point(628, 317);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(82, 18);
            this.stateLabel.TabIndex = 27;
            this.stateLabel.Text = "AKTYWNY";
            // 
            // activateButton
            // 
            this.activateButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.activateButton.Location = new System.Drawing.Point(590, 352);
            this.activateButton.Name = "activateButton";
            this.activateButton.Size = new System.Drawing.Size(99, 23);
            this.activateButton.TabIndex = 28;
            this.activateButton.Text = "AKTYWUJ";
            this.activateButton.UseVisualStyleBackColor = true;
            this.activateButton.Click += new System.EventHandler(this.activateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteButton.Location = new System.Drawing.Point(590, 381);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(99, 23);
            this.deleteButton.TabIndex = 29;
            this.deleteButton.Text = "USUŃ";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(224, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 25);
            this.textBox1.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(564, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "CENA PROMOCYJNA";
            // 
            // categoriesBindingSource
            // 
            this.categoriesBindingSource.DataSource = typeof(SOSM1.Categories);
            // 
            // categoriesBindingSource1
            // 
            this.categoriesBindingSource1.DataSource = typeof(SOSM1.Categories);
            // 
            // ProductDataAdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.activateButton);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceTextbox);
            this.Controls.Add(this.amountTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.imageButton);
            this.Controls.Add(this.saveChangesButton);
            this.Controls.Add(this.productPictureBox);
            this.Name = "ProductDataAdminControl";
            this.Size = new System.Drawing.Size(753, 445);
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.BindingSource categoriesBindingSource;
        private System.Windows.Forms.BindingSource categoriesBindingSource1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox descriptionTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Button activateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
    }
}
