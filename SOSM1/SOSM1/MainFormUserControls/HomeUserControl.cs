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
        public HomeUserControl()
        {
            InitializeComponent();
            SetWelcomeMessage();
            SetSaleInfo();
        }

        private void SetWelcomeMessage()
        {
            try
            {
                welcomeMessageLabel.Text = InterfaceToDataBaseOtherMethods.GetWelcomeMessage();
                if (welcomeMessageLabel.Text.Length == 0)
                    welcomeMessagePanel.Visible = false;
            }
            catch(NotImplementedException)//kick when implemented (empty contact info is their choice)
            {
                welcomeMessageLabel.Text = Properties.Resources.DefaultWelcomeMessage;
            }
        }
        private void SetSaleInfo()
        {
            try
            {
                Product productSale;
                if(InterfaceToDataBaseProductMethods.GetBiggestSale(out productSale))
                {
                    salePictureBox.Image = productSale.Picture;
                    saleLabel.Text = "Promocja na: " + productSale.ProductName + "!\n" + "Jedyne " + productSale.Discount + "zł z " + productSale.Price + "zł za ";
                    switch(productSale.UnitType)
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
            catch (NotImplementedException)//kick when implemented 
            {
                salePictureBox.Visible = false;
                saleLabel.Text = Properties.Resources.DefaultSale;
            }

        }
    }
}
