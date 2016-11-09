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
                if(InterfaceToDataBaseProductMethods.GetBiggestSale(out productOnSale))
                {
                    salePictureBox.Image = productOnSale.Picture;
                    saleLabel.Text = "Promocja na: " + productOnSale.ProductName + "!\n" + "Jedyne " + productOnSale.Discount + "zł z " + productOnSale.Price + "zł za ";
                    switch(productOnSale.UnitType)
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

        private void salePanel_Click(object sender, EventArgs e)
        {
            productOnSale = new Product("testkek", 1, 1, 1, 1,"lolololo", null, 1, 1);//kick when testing finished
            if (productOnSale != null)
            {
                (ParentForm as MainWindowForm).CreatePoductWindow(productOnSale);
            }
        }
        
    }
}
