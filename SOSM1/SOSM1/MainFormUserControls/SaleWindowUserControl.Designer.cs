namespace SOSM1.MainFormUserControls
{
    partial class SaleWindowUserControl
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
            this.infoPanel = new System.Windows.Forms.Panel();
            this.flowOrdersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.idDescLabel = new System.Windows.Forms.Label();
            this.idLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.dateDescLabel = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.sumDescLabel = new System.Windows.Forms.Label();
            this.flowLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.infoPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.flowLabel);
            this.infoPanel.Controls.Add(this.sumLabel);
            this.infoPanel.Controls.Add(this.sumDescLabel);
            this.infoPanel.Controls.Add(this.dateLabel);
            this.infoPanel.Controls.Add(this.dateDescLabel);
            this.infoPanel.Controls.Add(this.idLabel);
            this.infoPanel.Controls.Add(this.idDescLabel);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel.Location = new System.Drawing.Point(0, 0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(708, 90);
            this.infoPanel.TabIndex = 0;
            // 
            // flowOrdersPanel
            // 
            this.flowOrdersPanel.AutoScroll = true;
            this.flowOrdersPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowOrdersPanel.Location = new System.Drawing.Point(0, 90);
            this.flowOrdersPanel.Name = "flowOrdersPanel";
            this.flowOrdersPanel.Size = new System.Drawing.Size(708, 304);
            this.flowOrdersPanel.TabIndex = 2;
            // 
            // idDescLabel
            // 
            this.idDescLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.idDescLabel.Location = new System.Drawing.Point(3, 0);
            this.idDescLabel.Name = "idDescLabel";
            this.idDescLabel.Size = new System.Drawing.Size(106, 29);
            this.idDescLabel.TabIndex = 0;
            this.idDescLabel.Text = "ID transakcji:";
            this.idDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idLabel
            // 
            this.idLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.idLabel.Location = new System.Drawing.Point(115, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(138, 29);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "saleID";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.dateLabel.Location = new System.Drawing.Point(457, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(118, 29);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Date";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateDescLabel
            // 
            this.dateDescLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.dateDescLabel.Location = new System.Drawing.Point(333, 0);
            this.dateDescLabel.Name = "dateDescLabel";
            this.dateDescLabel.Size = new System.Drawing.Size(118, 29);
            this.dateDescLabel.TabIndex = 2;
            this.dateDescLabel.Text = "Data transakcji:";
            this.dateDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sumLabel
            // 
            this.sumLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.sumLabel.Location = new System.Drawing.Point(155, 29);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(296, 29);
            this.sumLabel.TabIndex = 5;
            this.sumLabel.Text = "Summed_Value";
            this.sumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sumDescLabel
            // 
            this.sumDescLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.sumDescLabel.Location = new System.Drawing.Point(3, 29);
            this.sumDescLabel.Name = "sumDescLabel";
            this.sumDescLabel.Size = new System.Drawing.Size(146, 29);
            this.sumDescLabel.TabIndex = 4;
            this.sumDescLabel.Text = "Wartość transakcji:";
            this.sumDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLabel
            // 
            this.flowLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.flowLabel.Location = new System.Drawing.Point(0, 61);
            this.flowLabel.Name = "flowLabel";
            this.flowLabel.Size = new System.Drawing.Size(708, 29);
            this.flowLabel.TabIndex = 6;
            this.flowLabel.Text = "Lista produktów:";
            this.flowLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(708, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Powrót do historii transakcji";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 394);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 38);
            this.panel1.TabIndex = 8;
            // 
            // SaleWindowUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowOrdersPanel);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.panel1);
            this.Name = "SaleWindowUserControl";
            this.Size = new System.Drawing.Size(708, 432);
            this.infoPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.FlowLayoutPanel flowOrdersPanel;
        private System.Windows.Forms.Label idDescLabel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label dateDescLabel;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Label sumDescLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label flowLabel;
        private System.Windows.Forms.Panel panel1;
    }
}
