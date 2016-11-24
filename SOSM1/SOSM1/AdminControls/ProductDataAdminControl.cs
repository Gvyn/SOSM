using System;
using System.Data.Entity;
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
        private Product product;
        List<string> categoriesList = new List<string>();

        public ProductDataAdminControl(Product productDataObject)
        {
            InitializeComponent();
            this.product = productDataObject;
            GetCategories();
            SetProductData();
        }

        private void SetProductData()
        {
            nameTextbox.Text = product.ProductName;
            amountTextbox.Text = product.Amount.ToString();
            priceTextbox.Text = product.Price.ToString();
            switch(product.UnitType)
            {
                case 0:
                    radioButton1.Select();
                    break;
                case 1:
                    radioButton2.Select();
                    break;
                case 2:
                    radioButton3.Select();
                    break;
            }
            switch (product.State)
            {
                case 0:
                    stateLabel.Text = "NIE AKTYWNY";
                    break;
                case 1:
                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;
                    radioButton3.Enabled = false;
                    activateButton.Visible = false;
                    break;
                case 2:
                    stateLabel.Text = "ARCHIWALNY";
                    activateButton.Visible = false;
                    deleteButton.Visible = false;
                    break;
            }
            if (product.Picture != null)
                productPictureBox.Image = product.Picture;
            else
                productPictureBox.Image = Properties.Resources.NoPicture;
            descriptionTextBox.Text = product.Description;

        }

        async private void GetCategories()
        {
            string selectedCategory = null;
            InterfaceToDataBaseCategoryMethods kek = new InterfaceToDataBaseCategoryMethods();
            var categories = await kek.GetAllCategories();
            foreach (var category in categories)
            {
                categoriesList.Add(category.Name);
                if (category.CategoryID == product.CategoryID)
                    selectedCategory = category.Name;
            }
            categoryComboBox.DataSource = categoriesList;
            categoryComboBox.SelectedItem = selectedCategory;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void activateButton_Click(object sender, EventArgs e)
        {

        }

        private void imageButton_Click(object sender, EventArgs e)
        {

        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {

        }
    }
}
