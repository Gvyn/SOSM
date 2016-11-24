using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOSM1
{
    public partial class SaleDataUserControl : UserControl
    {
        Sale SaleData;
        public SaleDataUserControl()
        {
            InitializeComponent();
            MakeExample();
        }

        private void MakeExample()
        {
            Click -= SaleDataUserControl_Click;
            idLabel.Click -= SaleDataUserControl_Click;
            dateLabel.Click -= SaleDataUserControl_Click; 
            sumLabel.Click -= SaleDataUserControl_Click; 
            idLabel.Text = "ID transakcji";
            dateLabel.Text = "Data transakcji";
            sumLabel.Text = "Wartość transakcji";
        }

        public SaleDataUserControl(Sale SaleData, decimal sum)
        {
            InitializeComponent();
            this.SaleData = SaleData;
            idLabel.Text = this.SaleData.SaleID.ToString();
            dateLabel.Text = this.SaleData.Date.ToString();
            sumLabel.Text = sum+"zł";
        }

        private void SaleDataUserControl_Click(object sender, EventArgs e)
        {
            (ParentForm as MainWindowForm).CreateSaleWindowControl(SaleData);

        }
    }
}
