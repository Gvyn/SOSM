using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOSM1.MainFormUserControls
{
    public partial class SaleWindowUserControl : UserControl
    {
        Sale saleData;
        public SaleWindowUserControl(Sale saleData)
        {
            InitializeComponent();
            this.saleData = saleData;
            flowOrdersPanel.Controls.Add(new BasketDataUserControl());

            InterfaceToDataBaseSaleMethods Methods = new InterfaceToDataBaseSaleMethods();
            List<Order> ordersList = Methods.GetSaleOrders(saleData.SaleID).Result;

            idLabel.Text = saleData.SaleID.ToString();
            dateLabel.Text = saleData.Date.ToString();
            sumLabel.Text = Methods.GetSaleValue(saleData.SaleID).Result.ToString();
            
            foreach(Order order in ordersList)
            {
                flowOrdersPanel.Controls.Add(new BasketDataUserControl(order));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            (ParentForm as MainWindowForm).CreateHistoryControl(saleData.UserID);
        }
    }
}
