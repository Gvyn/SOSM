using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOSM1.AdminControls
{
    public partial class ProductDataAdminControl : UserControl
    {
        private Product productDataObject;

        public ProductDataAdminControl(Product productDataObject)
        {
            InitializeComponent();
            this.productDataObject = productDataObject;
            SetProductData();
        }

        private void SetProductData()
        {
            productNameLabel.Text = productDataObject.ProductName;
            if (productDataObject.Picture == null)
            {
                productPictureBox.Image = Properties.Resources.NoPicture;
            }
            else
            {
                productPictureBox.Image = productDataObject.Picture;
            }

            priceLabel.Text = ProductPriceInfoFormat(productDataObject.Discount, productDataObject.UnitType);
            switch (productDataObject.UnitType)
            {
                case 0:
                    unitLabel.Text = "Sztuk:";
                    break;
                case 1:
                    unitLabel.Text = "Kilogramów:";
                    break;
                case 2:
                    unitLabel.Text = "Litrów:";
                    break;
            }

            if (productDataObject.Amount == 0)
            {
                unitLabel.Visible = false;
                amountBox.Visible = false;
                toBasketButton.Text = "Brak na stanie";
                toBasketButton.Enabled = false;
            }
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
    }
}
