namespace SOSM1
{
    partial class SaleDataUserControl
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
            this.idLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            this.idLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.idLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.idLabel.Location = new System.Drawing.Point(0, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(158, 62);
            this.idLabel.TabIndex = 0;
            this.idLabel.Text = "SaleID";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.idLabel.Click += new System.EventHandler(this.SaleDataUserControl_Click);
            // 
            // dateLabel
            // 
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dateLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.dateLabel.Location = new System.Drawing.Point(390, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(168, 62);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "Date";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateLabel.Click += new System.EventHandler(this.SaleDataUserControl_Click);
            // 
            // sumLabel
            // 
            this.sumLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sumLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.sumLabel.Location = new System.Drawing.Point(558, 0);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(308, 62);
            this.sumLabel.TabIndex = 2;
            this.sumLabel.Text = "Summed_Value";
            this.sumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sumLabel.Click += new System.EventHandler(this.SaleDataUserControl_Click);
            // 
            // userLabel
            // 
            this.userLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.userLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.userLabel.Location = new System.Drawing.Point(158, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(232, 62);
            this.userLabel.TabIndex = 3;
            this.userLabel.Text = "User_Name";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userLabel.Click += new System.EventHandler(this.userLabel_Click);
            // 
            // SaleDataUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sumLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.idLabel);
            this.Name = "SaleDataUserControl";
            this.Size = new System.Drawing.Size(868, 62);
            this.Click += new System.EventHandler(this.SaleDataUserControl_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Label userLabel;
    }
}
