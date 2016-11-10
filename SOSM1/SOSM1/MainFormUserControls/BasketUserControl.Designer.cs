namespace SOSM1
{
    partial class BasketUserControl
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
            this.summaryPanel = new System.Windows.Forms.Panel();
            this.finishTransactionButton = new System.Windows.Forms.Button();
            this.sumPriceLabel = new System.Windows.Forms.Label();
            this.basketsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.summaryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // summaryPanel
            // 
            this.summaryPanel.Controls.Add(this.finishTransactionButton);
            this.summaryPanel.Controls.Add(this.sumPriceLabel);
            this.summaryPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.summaryPanel.Location = new System.Drawing.Point(0, 442);
            this.summaryPanel.Name = "summaryPanel";
            this.summaryPanel.Size = new System.Drawing.Size(1052, 116);
            this.summaryPanel.TabIndex = 1;
            // 
            // finishTransactionButton
            // 
            this.finishTransactionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.finishTransactionButton.Font = new System.Drawing.Font("Arial", 18F);
            this.finishTransactionButton.Location = new System.Drawing.Point(801, 23);
            this.finishTransactionButton.Name = "finishTransactionButton";
            this.finishTransactionButton.Size = new System.Drawing.Size(205, 65);
            this.finishTransactionButton.TabIndex = 1;
            this.finishTransactionButton.Text = "Potwierdź zakup";
            this.finishTransactionButton.UseVisualStyleBackColor = true;
            this.finishTransactionButton.Click += new System.EventHandler(this.finishTransactionButton_Click);
            // 
            // sumPriceLabel
            // 
            this.sumPriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sumPriceLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sumPriceLabel.Location = new System.Drawing.Point(159, 35);
            this.sumPriceLabel.Name = "sumPriceLabel";
            this.sumPriceLabel.Size = new System.Drawing.Size(636, 41);
            this.sumPriceLabel.TabIndex = 0;
            this.sumPriceLabel.Text = "Summed Price";
            this.sumPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // basketsFlowPanel
            // 
            this.basketsFlowPanel.AutoScroll = true;
            this.basketsFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basketsFlowPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.basketsFlowPanel.Location = new System.Drawing.Point(0, 0);
            this.basketsFlowPanel.Name = "basketsFlowPanel";
            this.basketsFlowPanel.Size = new System.Drawing.Size(1052, 442);
            this.basketsFlowPanel.TabIndex = 2;
            this.basketsFlowPanel.WrapContents = false;
            // 
            // BasketUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.basketsFlowPanel);
            this.Controls.Add(this.summaryPanel);
            this.Name = "BasketUserControl";
            this.Size = new System.Drawing.Size(1052, 558);
            this.summaryPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel summaryPanel;
        private System.Windows.Forms.FlowLayoutPanel basketsFlowPanel;
        private System.Windows.Forms.Button finishTransactionButton;
        private System.Windows.Forms.Label sumPriceLabel;
    }
}
