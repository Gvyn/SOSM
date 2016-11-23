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
                productPictureBox.Image = Properties.Resources.NoPicture;
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
            GenerateCategoryLabelChain();
            if(productDataObject.Amount == 0)
            {
                unitLabel.Visible = false;
                amountBox.Visible = false;
                toBasketButton.Text = "Brak na stanie";
                toBasketButton.Enabled = false;
            }
        }
        private void SetBasketData()
        {
            MainWindowForm mainForm = (MainWindowForm)Application.OpenForms["MainWindowForm"];
            inBasketLabel.Text = mainForm.GetBasketAmount(productDataObject.ProductID).ToString();
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
        private async void GenerateCategoryLabelChain()
        {
            try
            {
                InterfaceToDataBaseCategoryMethods Methods = new InterfaceToDataBaseCategoryMethods();
                Category category = await Methods.GetCategory(productDataObject.CategoryID);
                currentCategoryLabel.Text = ">" + category.Name;
            }
            catch (NullReferenceException)
            {
                currentCategoryLabel.Visible = false;
            }
            currentObjectLabel.Text = ">" + productDataObject.ProductName;
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
            decimal amount;
            if(decimal.TryParse(amountBox.Text,out amount))
            {
                if (productDataObject.UnitType == 0 && amount % 1 != 0)
                    MessageBox.Show("Możesz dodać tylko całkowitą liczbę sztuk!");
                else
                {
                    if (amount <= 0)
                        MessageBox.Show("Możesz dodać tylko dodatnią ilość!");
                    else
                    {
                        if(amount>productDataObject.Amount)
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
            amountLabel.Text = ProductAmountInforFormat(productDataObject.Amount, productDataObject.UnitType);
            MainWindowForm mainForm = (MainWindowForm)Application.OpenForms["MainWindowForm"];
            mainForm.AddBasket(productDataObject.ProductID, amount, productDataObject.Amount);
            SetBasketData();
            MessageBox.Show("Dodano do koszyka.");
        }

        private void categoryRootLabel_Click(object sender, EventArgs e)
        {
            (ParentForm as MainWindowForm).CreateProductsCatalog();
        }

        private void currentCategoryLabel_Click(object sender, EventArgs e)
        {
            (ParentForm as MainWindowForm).CreateProductsCatalog(productDataObject.CategoryID);
        }
    }
}
