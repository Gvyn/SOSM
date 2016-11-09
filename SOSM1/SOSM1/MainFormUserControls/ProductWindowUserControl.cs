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
            SetBasketData();
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


        }
        private void SetBasketData()
        {
            inBasketLabel.Text = (ParentForm as MainWindowForm).GetBasket(productDataObject.ProductID).ToString();
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

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            setSearchWatermarkOff();
        }
        private void setSearchWatermarkOff()
        {
            if (searchTextBox.ForeColor!=SystemColors.WindowText)
            {
                searchTextBox.ForeColor = SystemColors.WindowText;
                searchTextBox.Text = "";
            }
        }
        private void searchTextBox_Leave(object sender, EventArgs e)
        {
            setSearchWatermarkOn();
        }
        private void setSearchWatermarkOn()
        {
            if (searchTextBox.Text == "")
            {
                searchTextBox.ForeColor = Color.LightGray;
                searchTextBox.Text = "atrybut wyszukiwania";
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(searchTextBox.ForeColor == SystemColors.WindowText && searchTextBox.Text != "")
                (ParentForm as MainWindowForm).CreateProductsCatalog(searchTextBox.Text);
        }

        private void toBasketButton_Click(object sender, EventArgs e)
        {

        }
    }
}
