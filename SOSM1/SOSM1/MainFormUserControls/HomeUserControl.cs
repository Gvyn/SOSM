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
    public partial class HomeUserControl : UserControl
    {
        Product productOnSale;
        public HomeUserControl()
        {
            InitializeComponent();
            SetWelcomeMessage();
            SetSaleInfo();
        }

        private async void SetWelcomeMessage()
        {
            try
            {
                InterfaceToDataBaseOtherMethods Method = new InterfaceToDataBaseOtherMethods();
                welcomeMessageLabel.Text = await Method.GetWelcomeMessage();
                if (welcomeMessageLabel.Text.Length == 0)
                    welcomeMessagePanel.Visible = false;
            }
            catch (InvalidOperationException)
            {
                welcomeMessageLabel.Text = Properties.Resources.DefaultWelcomeMessage;
            }
        }
        private async void SetSaleInfo()
        {
            InterfaceToDataBaseProductMethods Methods = new InterfaceToDataBaseProductMethods();
            productOnSale = await Methods.GetRandomSale();
            if (productOnSale!= null)
            {
                if (productOnSale.Picture == null)
                {
                    salePictureBox.Visible = false;
                    saleLabel.TextAlign = ContentAlignment.MiddleCenter;
                }
                else
                    salePictureBox.Image = productOnSale.Picture;
                saleLabel.Text = "Promocja na: " + productOnSale.ProductName + "!\n" + "Jedyne " + productOnSale.Discount + "zł z " + productOnSale.Price + "zł za ";
                switch (productOnSale.UnitType)
                {
                    case 0:
                        saleLabel.Text += "sztukę!";
                        break;
                    case 1:
                        saleLabel.Text += "kilogram!";
                        break;
                    case 2:
                        saleLabel.Text += "litr!";
                        break;
                }

            }
            else
            {
                salePictureBox.Visible = false;
                saleLabel.Text = Properties.Resources.DefaultSale;
            }


        }

        private void salePanel_Click(object sender, EventArgs e)
        {
            if (productOnSale != null)
            {
                (ParentForm as MainWindowForm).CreateProductWindow(productOnSale);
            }
        }

    }
}
