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
    public partial class ProductDataUserControl : UserControl
    {
        private Product productDataObject;
        public ProductDataUserControl(Product productDataObject)
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

            if(productDataObject.Amount==0)
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

        private void toBasketButton_Click(object sender, EventArgs e)
        {
            decimal amount;
            if (decimal.TryParse(amountBox.Text, out amount))
            {
                if (productDataObject.UnitType == 0 && amount % 1 != 0)
                    MessageBox.Show("Możesz dodać tylko całkowitą liczbę sztuk!");
                else
                {
                    if (amount <= 0)
                        MessageBox.Show("Możesz dodać tylko dodatnią ilość!");
                    else
                    {
                        if (amount > productDataObject.Amount)
                        {
                            string question = "Maksymalnie dostępnych ";

                            switch (productDataObject.UnitType)
                            {
                                case 0:
                                    question += "sztuk";
                                    break;
                                case 1:
                                    question += "kilogramów";
                                    break;
                                case 2:
                                    question += "litrów";
                                    break;
                            }
                            question += ": " + productDataObject.Amount + ".\n Czy chciał(a)byś je dodać?";
                            DialogResult dialogResult = MessageBox.Show(question, "Brak produktu na stanie", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                AddBasket(productDataObject.Amount);
                            }
                        }
                        else
                            AddBasket(amount);
                    }
                }
            }
            else
                MessageBox.Show("Wprowadź prawidłową ilość produktu!");

        }
        private void AddBasket(decimal amount)
        {
            productDataObject.Amount -= amount;
            MainWindowForm mainForm = (MainWindowForm)Application.OpenForms["MainWindowForm"];
            mainForm.addBasket(productDataObject.ProductID, amount, productDataObject.Amount);
            MessageBox.Show("Dodano do koszyka.");
        }

        private void productNameLabel_Click(object sender, EventArgs e)
        {

            (ParentForm as MainWindowForm).CreateProductWindow(productDataObject);
        }
    }
}
