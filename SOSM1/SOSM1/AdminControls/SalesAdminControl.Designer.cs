namespace SOSM1.AdminControls
{
    partial class SalesAdminControl
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
            this.setPanel = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.allButton = new System.Windows.Forms.Button();
            this.histPanel = new System.Windows.Forms.Panel();
            this.setPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // setPanel
            // 
            this.setPanel.Controls.Add(this.searchBox);
            this.setPanel.Controls.Add(this.searchButton);
            this.setPanel.Controls.Add(this.categoryBox);
            this.setPanel.Controls.Add(this.allButton);
            this.setPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.setPanel.Location = new System.Drawing.Point(0, 0);
            this.setPanel.Name = "setPanel";
            this.setPanel.Size = new System.Drawing.Size(828, 66);
            this.setPanel.TabIndex = 0;
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Arial", 11.25F);
            this.searchBox.Location = new System.Drawing.Point(571, 20);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(224, 25);
            this.searchBox.TabIndex = 3;
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Arial", 11.25F);
            this.searchButton.Location = new System.Drawing.Point(252, 18);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(111, 29);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Wyszukaj po:";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // categoryBox
            // 
            this.categoryBox.Font = new System.Drawing.Font("Arial", 11.25F);
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(369, 20);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(173, 25);
            this.categoryBox.TabIndex = 1;
            this.categoryBox.SelectionChangeCommitted += new System.EventHandler(this.categoryBox_SelectionChangeCommitted);
            // 
            // allButton
            // 
            this.allButton.Font = new System.Drawing.Font("Arial", 11.25F);
            this.allButton.Location = new System.Drawing.Point(12, 17);
            this.allButton.Name = "allButton";
            this.allButton.Size = new System.Drawing.Size(159, 29);
            this.allButton.TabIndex = 0;
            this.allButton.Text = "Wszystkie transakcje";
            this.allButton.UseVisualStyleBackColor = true;
            this.allButton.Click += new System.EventHandler(this.allButton_Click);
            // 
            // histPanel
            // 
            this.histPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.histPanel.Location = new System.Drawing.Point(0, 66);
            this.histPanel.Name = "histPanel";
            this.histPanel.Size = new System.Drawing.Size(828, 440);
            this.histPanel.TabIndex = 1;
            // 
            // SalesAdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.histPanel);
            this.Controls.Add(this.setPanel);
            this.Name = "SalesAdminControl";
            this.Size = new System.Drawing.Size(828, 506);
            this.setPanel.ResumeLayout(false);
            this.setPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel setPanel;
        private System.Windows.Forms.Panel histPanel;
        private System.Windows.Forms.Button allButton;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox categoryBox;
    }
}
