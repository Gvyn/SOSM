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
    public partial class HistoryUserControl : UserControl
    {

        public HistoryUserControl(User UserData)
        {
            InitializeComponent();
            salesFlowPanel.Controls.Add(new SaleDataUserControl());
            InterfaceToDataBaseSaleMethods Methods = new InterfaceToDataBaseSaleMethods();
            List<Sale> UserSaleList = Methods.GetSalesHistory(UserData.UserID).Result;
            decimal sum = 0;
            foreach(Sale sale in UserSaleList)
            {
                sum += Methods.GetSaleValue(sale.SaleID).Result;
                salesFlowPanel.Controls.Add(new SaleDataUserControl(sale, sum));
            }
            numberLabel.Text = UserSaleList.Count.ToString();
            sumLabel.Text = sum.ToString()+"zł";
        }
    }
}
