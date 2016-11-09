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
    public partial class ProductWindowUserControl : UserControl
    {
        private Product productDataObject;
        public ProductWindowUserControl(Product productDataObject)
        {
            InitializeComponent();
            this.productDataObject = productDataObject;
            SetProductData();
        }

        private void SetProductData()
        {
            descriptionLabel.Text = productDataObject.Description;
            if (productDataObject.Picture == null)
            {
                productPictureBox.Image = Properties.Resources.YukoCrying;
                noPictureLabel.Text = Properties.Resources.DefaultNoProductPictureText;
                noPictureLabel.Visible = true;
            }
            else
            { 
                productPictureBox.Image = productDataObject.Picture;
            }

            priceLabel.Text = ProductPriceInfoFormat(productDataObject.Discount, productDataObject.UnitType);
            amountLabel.Text = ProductAmountInforFormat(productDataObject.Amount, productDataObject.UnitType);

               
        }

        private string ProductPriceInfoFormat(decimal price, long unitType)
        {
            string result = "Cena: " + price + "zł za ";
            switch (unitType)
            {
                case 0:
                    result += "sztukę";
                    break;
                case 1:
                    result += "kilogram";
                    break;
                case 2:
                    result += "litr";
                    break;
            }
            return result;
        }
        private string ProductAmountInforFormat(decimal amount, long unitType)
        {
            string result="";
            switch (unitType)
            {
                case 0:
                    result = "Sztuk";
                    break;
                case 1:
                    result = "Kilogramów";
                    break;
                case 2:
                    result = "Litrów";
                    break;
            }
            result += " dostępnych: " + amount;
            return result;

        }
    }
}
