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
        public HistoryUserControl(bool showUserName = false)
        {
            InitializeComponent();
            InterfaceToDataBaseSaleMethods Methods = new InterfaceToDataBaseSaleMethods();
            List<Sale> UserSaleList = Methods.GetProductSalesHistory().Result;
            Init(UserSaleList, showUserName);
        }

        public HistoryUserControl(User UserData, bool showUserName = false)
        {
            InitializeComponent();
            InterfaceToDataBaseSaleMethods Methods = new InterfaceToDataBaseSaleMethods();
            List<Sale> UserSaleList = Methods.GetUserSalesHistory(UserData.UserID).Result;
            Init(UserSaleList, showUserName);
        }
        public HistoryUserControl(long ProductID, bool showUserName = false)
        {
            InitializeComponent();
            InterfaceToDataBaseSaleMethods Methods = new InterfaceToDataBaseSaleMethods();
            List<Sale> UserSaleList = Methods.GetProductSalesHistory(ProductID).Result;
            Init(UserSaleList, showUserName);
        }
        public HistoryUserControl(DateTime Date, int comparePositions=3, bool showUserName = false)
        {
            InitializeComponent();
            InterfaceToDataBaseSaleMethods Methods = new InterfaceToDataBaseSaleMethods();
            List<Sale> UserSaleList = Methods.GetDateSalesHistory(Date, comparePositions).Result;
            Init(UserSaleList, showUserName);
        }

        private void Init(List<Sale> UserSaleList, bool showUserName = false)
        {
            salesFlowPanel.Controls.Add(new SaleDataUserControl(showUserName));
            decimal sum = 0;
            foreach (Sale sale in UserSaleList)
            {
                InterfaceToDataBaseSaleMethods Methods = new InterfaceToDataBaseSaleMethods();
                sum += Methods.GetSaleValue(sale.SaleID).Result;
                salesFlowPanel.Controls.Add(new SaleDataUserControl(sale, sum, showUserName));
            }
            numberLabel.Text = UserSaleList.Count.ToString();
            sumLabel.Text = sum.ToString() + "zł";

        }

    }
}
