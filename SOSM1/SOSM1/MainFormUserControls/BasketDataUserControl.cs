using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOSM1
{
    public partial class BasketDataUserControl : UserControl
    {
        Basket basketDataObject = null;
        Product productDataObject = null;
        public decimal sum = 0;
        public BasketDataUserControl()
        {
            InitializeComponent();
            MakeLegend();
        }
        public BasketDataUserControl(Basket basketDataObject)
        {
            InitializeComponent();
            this.basketDataObject = basketDataObject;
            InterfaceToDataBaseProductMethods Methods = new InterfaceToDataBaseProductMethods();
            productDataObject = Methods.GetProductData(basketDataObject.ProductID).Result;
            SetData();
            amountBox.TextChanged += amountBox_TextChanged;
        }


        private void MakeLegend()
        {
            productNameLabel.Text = "Produkt";
            productPriceLabel.Text = "Cena";
            productPriceLabel.Font = new Font("Arial", 14);
            sumPriceLabel.Text = "Łączny koszt";
            removeButton.Visible = false;
            amountBox.ReadOnly = true;
            ActiveControl = null;
            amountBox.Text = "Ilość";
            amountBox.TextAlign = HorizontalAlignment.Center;
            amountBox.Location = new Point(amountBox.Location.X, amountBox.Location.Y + 3);
            amountBox.GotFocus += AmountLabel_GotFocus;
            amountBox.ForeColor = SystemColors.WindowText;
            amountBox.BackColor = SystemColors.Control;
            amountBox.BorderStyle = BorderStyle.None;
        }

        private void AmountLabel_GotFocus(object sender, EventArgs e)
        {
            ActiveControl = null;
        }

        private void SetData()
        {
            productNameLabel.Text = productDataObject.ProductName;
            productPriceLabel.Text = ProductPriceInfoFormat(productDataObject.Discount, productDataObject.UnitType);
            amountBox.Text = basketDataObject.Amount.ToString();
            sum = productDataObject.Discount * basketDataObject.Amount;
            sumPriceLabel.Text = sum.ToString();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            removeProduct();
            //DialogResult dialogResult = MessageBox.Show("Czy jesteś pewny(a), że chcesz usunąć ten produkt z koszyka?","", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    (ParentForm as MainWindowForm).RemoveBasket(basketDataObject,productDataObject);
            //}
        }
        private string ProductPriceInfoFormat(decimal price, long unitType)
        {
            string result = price + "zł za ";
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

        private void productNameLabel_Click(object sender, EventArgs e)
        {
            (ParentForm as MainWindowForm).CreateProductWindow(productDataObject);

        }

        private void removeProduct()
        {
            DialogResult dialogResult = MessageBox.Show("Czy jesteś pewny(a), że chcesz usunąć ten produkt z koszyka?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MainWindowForm mainForm = (MainWindowForm)Application.OpenForms["MainWindowForm"];
                mainForm.RemoveBasket(basketDataObject, productDataObject);
            }

        }
        private void amountBox_TextChanged(object sender, EventArgs e)
        {
            ChangeAmountVerify();
        }
        private void ChangeAmountVerify()
        {
            decimal amount;
            if (decimal.TryParse(amountBox.Text, out amount))
            {
                if (amount == productDataObject.Amount)
                    return;
                if (productDataObject.UnitType == 0 && amount % 1 != 0)
                {
                    MessageBox.Show("Możesz ustawić tylko całkowitą liczbę sztuk!");
                    amountBox.Text = basketDataObject.Amount.ToString();
                }
                else
                {
                    if (amount < 0)
                    {
                        MessageBox.Show("Możesz ustawić tylko nieujemną ilość!");
                        amountBox.Text = basketDataObject.Amount.ToString();
                    }
                    else
                    {
                        if (amount == 0)
                        {
                            removeProduct();
                        }
                        else
                        {
                            decimal amountChange = amount - basketDataObject.Amount;
                            if (amountChange > productDataObject.Amount)
                            {
                                if (productDataObject.Amount == 0)
                                {
                                    MessageBox.Show("Nie ma już więcej na stanie.");
                                    amountBox.Text = basketDataObject.Amount.ToString();

                                }
                                else
                                {

                                    string question = "Maksymalnie dostępnych jeszcze  ";

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
                                        ChangeAmount(productDataObject.Amount);
                                    }
                                    else
                                    {
                                        amountBox.Text = basketDataObject.Amount.ToString();
                                    }
                                }
                            }
                            else
                            {
                                DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz zmienić ilość tego produktu?", "", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    ChangeAmount(amountChange);
                                }
                                else
                                {
                                    amountBox.Text = basketDataObject.Amount.ToString();

                                }
                            }
                        }
                    }

                }

            }
            else
            {
                MessageBox.Show("Wprowadź prawidłową ilość produktu!");
                amountBox.Text = basketDataObject.Amount.ToString();

            }
        }
        private void ChangeAmount(decimal Amount)//newAmount)
        {
            MainWindowForm mainForm = (MainWindowForm)Application.OpenForms["MainWindowForm"];
            //mainForm.ModifyBasket(basketDataObject, newAmount, productDataObject);
            mainForm.MoveProductsToFromBasket(basketDataObject.ProductID, Amount);
        }

    }
}
