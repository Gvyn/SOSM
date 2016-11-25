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
        User UserData;
        public SaleDataUserControl(bool showName = false)
        {
            InitializeComponent();
            MakeExample(showName);
        }

        private void MakeExample(bool showName = false)
        {
            Click -= SaleDataUserControl_Click;
            idLabel.Click -= SaleDataUserControl_Click;
            dateLabel.Click -= SaleDataUserControl_Click; 
            sumLabel.Click -= SaleDataUserControl_Click; 
            idLabel.Text = "ID transakcji";
            dateLabel.Text = "Data transakcji";
            sumLabel.Text = "Wartość transakcji";
            userLabel.Click -= userLabel_Click;
            if (showName)
            {
                userLabel.Text = "Nazwa użytkownika";
            }
            else
            {
                userLabel.Visible = false;
            }
        }

        public SaleDataUserControl(Sale SaleData, decimal sum, bool showName = false)
        {
            InitializeComponent();
            this.SaleData = SaleData;
            idLabel.Text = this.SaleData.SaleID.ToString();
            dateLabel.Text = this.SaleData.Date.ToString();
            sumLabel.Text = sum+"zł";
            if (showName)
            {
                InterfaceToDataBaseUserMethods Methods = new InterfaceToDataBaseUserMethods();
                UserData = Methods.GetUserData(SaleData.UserID).Result;
                userLabel.Text = UserData.UserName;
            }
            else
            {
                userLabel.Visible = false;
            }
        }

        private void SaleDataUserControl_Click(object sender, EventArgs e)
        {
            (ParentForm as MainWindowForm).CreateSaleWindowControl(SaleData);

        }

        private void userLabel_Click(object sender, EventArgs e)
        {
            (ParentForm as MainWindowForm).CreateProfileUserControl(UserData);
        }
    }
}
