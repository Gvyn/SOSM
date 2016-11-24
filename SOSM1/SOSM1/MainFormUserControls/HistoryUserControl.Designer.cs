namespace SOSM1
{
    partial class HistoryUserControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.sumDescLabel = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.numberLabel = new System.Windows.Forms.Label();
            this.numberDescLabel = new System.Windows.Forms.Label();
            this.salesFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.sumDescLabel);
            this.panel1.Controls.Add(this.sumLabel);
            this.panel1.Controls.Add(this.numberLabel);
            this.panel1.Controls.Add(this.numberDescLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 70);
            this.panel1.TabIndex = 0;
            // 
            // sumDescLabel
            // 
            this.sumDescLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sumDescLabel.Font = new System.Drawing.Font("Arial", 18F);
            this.sumDescLabel.Location = new System.Drawing.Point(389, 0);
            this.sumDescLabel.Name = "sumDescLabel";
            this.sumDescLabel.Size = new System.Drawing.Size(120, 70);
            this.sumDescLabel.TabIndex = 2;
            this.sumDescLabel.Text = "Na kwotę:";
            this.sumDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sumLabel
            // 
            this.sumLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sumLabel.Font = new System.Drawing.Font("Arial", 18F);
            this.sumLabel.Location = new System.Drawing.Point(509, 0);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(311, 70);
            this.sumLabel.TabIndex = 3;
            this.sumLabel.Text = "Summed_Value";
            this.sumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numberLabel
            // 
            this.numberLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.numberLabel.Font = new System.Drawing.Font("Arial", 18F);
            this.numberLabel.Location = new System.Drawing.Point(215, 0);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(168, 70);
            this.numberLabel.TabIndex = 1;
            this.numberLabel.Text = "Number_Of_Transactions";
            this.numberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numberDescLabel
            // 
            this.numberDescLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.numberDescLabel.Font = new System.Drawing.Font("Arial", 18F);
            this.numberDescLabel.Location = new System.Drawing.Point(0, 0);
            this.numberDescLabel.Name = "numberDescLabel";
            this.numberDescLabel.Size = new System.Drawing.Size(215, 70);
            this.numberDescLabel.TabIndex = 0;
            this.numberDescLabel.Text = "Łącznie transakcji:";
            this.numberDescLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // salesFlowPanel
            // 
            this.salesFlowPanel.AutoScroll = true;
            this.salesFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.salesFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.salesFlowPanel.Name = "salesFlowPanel";
            this.salesFlowPanel.Size = new System.Drawing.Size(820, 362);
            this.salesFlowPanel.TabIndex = 1;
            this.salesFlowPanel.WrapContents = false;
            // 
            // HistoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.salesFlowPanel);
            this.Controls.Add(this.panel1);
            this.Name = "HistoryUserControl";
            this.Size = new System.Drawing.Size(820, 432);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label numberDescLabel;
        private System.Windows.Forms.FlowLayoutPanel salesFlowPanel;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Label sumDescLabel;
        private System.Windows.Forms.Label numberLabel;
    }
}
