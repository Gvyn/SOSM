namespace SOSM1
{
    partial class HomeUserControl
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
            this.welcomeMessagePanel = new System.Windows.Forms.Panel();
            this.welcomeMessageLabel = new System.Windows.Forms.Label();
            this.salePanel = new System.Windows.Forms.Panel();
            this.saleLabel = new System.Windows.Forms.Label();
            this.salePictureBox = new System.Windows.Forms.PictureBox();
            this.welcomeMessagePanel.SuspendLayout();
            this.salePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.salePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeMessagePanel
            // 
            this.welcomeMessagePanel.Controls.Add(this.welcomeMessageLabel);
            this.welcomeMessagePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.welcomeMessagePanel.Location = new System.Drawing.Point(0, 0);
            this.welcomeMessagePanel.Name = "welcomeMessagePanel";
            this.welcomeMessagePanel.Size = new System.Drawing.Size(462, 542);
            this.welcomeMessagePanel.TabIndex = 0;
            // 
            // welcomeMessageLabel
            // 
            this.welcomeMessageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeMessageLabel.Font = new System.Drawing.Font("Arial", 18F);
            this.welcomeMessageLabel.Location = new System.Drawing.Point(0, 0);
            this.welcomeMessageLabel.Name = "welcomeMessageLabel";
            this.welcomeMessageLabel.Size = new System.Drawing.Size(462, 542);
            this.welcomeMessageLabel.TabIndex = 0;
            this.welcomeMessageLabel.Text = "Welcome_Message";
            this.welcomeMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salePanel
            // 
            this.salePanel.Controls.Add(this.saleLabel);
            this.salePanel.Controls.Add(this.salePictureBox);
            this.salePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salePanel.Location = new System.Drawing.Point(462, 0);
            this.salePanel.Name = "salePanel";
            this.salePanel.Size = new System.Drawing.Size(456, 542);
            this.salePanel.TabIndex = 1;
            // 
            // saleLabel
            // 
            this.saleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.saleLabel.Font = new System.Drawing.Font("Arial", 18F);
            this.saleLabel.Location = new System.Drawing.Point(0, 250);
            this.saleLabel.Name = "saleLabel";
            this.saleLabel.Size = new System.Drawing.Size(456, 292);
            this.saleLabel.TabIndex = 0;
            this.saleLabel.Text = "Sale_Info";
            this.saleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.saleLabel.Click += new System.EventHandler(this.salePanel_Click);
            // 
            // salePictureBox
            // 
            this.salePictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.salePictureBox.Location = new System.Drawing.Point(0, 0);
            this.salePictureBox.Name = "salePictureBox";
            this.salePictureBox.Size = new System.Drawing.Size(456, 250);
            this.salePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.salePictureBox.TabIndex = 1;
            this.salePictureBox.TabStop = false;
            this.salePictureBox.Click += new System.EventHandler(this.salePanel_Click);
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.salePanel);
            this.Controls.Add(this.welcomeMessagePanel);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(918, 542);
            this.welcomeMessagePanel.ResumeLayout(false);
            this.salePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.salePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel welcomeMessagePanel;
        private System.Windows.Forms.Panel salePanel;
        private System.Windows.Forms.Label welcomeMessageLabel;
        private System.Windows.Forms.Label saleLabel;
        private System.Windows.Forms.PictureBox salePictureBox;
    }
}
