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
        List<Category> categoriesList = new List<Category>();
        InterfaceToDataBaseProductMethods kek2;

        public ProductDataAdminControl(Product productDataObject)
        {
            InitializeComponent();
            kek2 = new InterfaceToDataBaseProductMethods();
            this.product = productDataObject;
            GetCategories();
            SetProductData();
        }

        private void SetProductData()
        {
            nameTextbox.Text = product.ProductName;
            amountTextbox.Text = product.Amount.ToString();
            priceTextbox.Text = product.Price.ToString();
            textBox1.Text = product.Discount.ToString();
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
                    stateLabel.Text = "NIEAKTYWNY";
                    break;
                case 1:
                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;
                    radioButton3.Enabled = false;
                    activateButton.Visible = false;
                    break;
                case 2:
                    stateLabel.Text = "ARCHIWALNY";
                    radioButton1.Enabled = false;
                    radioButton2.Enabled = false;
                    radioButton3.Enabled = false;
                    saveChangesButton.Visible = false;
                    nameTextbox.Enabled = false;
                    priceTextbox.Enabled = false;
                    amountTextbox.Enabled = false;
                    descriptionTextBox.Enabled = false;
                    textBox1.Enabled = false;
                    categoryComboBox.Enabled = false;
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
            Category selectedCategory = null;
            InterfaceToDataBaseCategoryMethods kek = new InterfaceToDataBaseCategoryMethods();
            var categories = await kek.GetAllCategories();
            foreach (var category in categories)
            {
                Category new_category = new Category(category.Name, category.Description);
                new_category.CategoryID = category.CategoryID;
                categoriesList.Add(new_category);
                if (category.CategoryID == product.CategoryID)
                    selectedCategory = category;
            }
            List<string> asd = new List<string>();
            foreach (var x in categoriesList)
                asd.Add(x.Name);
            categoryComboBox.DataSource = asd;
            categoryComboBox.SelectedItem = selectedCategory.Name;
        }

        async private void deleteButton_Click(object sender, EventArgs e)
        {
            await kek2.DeleteProduct(product.ProductName);
            if (product.State == 0)
            {
                InterfaceToDataBaseProductMethods methods = new InterfaceToDataBaseProductMethods();
                List<Product> products = await methods.CatalogProducts();
                foreach (var product in products)
                    this.Parent.Controls.Add(new ProductMiniDataAdminControl(product));
                this.Parent.Controls.Remove(this);
            }
            if (product.State == 1)
            {
                product.State = 2;
                radioButton1.Checked = false;
                radioButton2.Checked = true;
                deleteButton.Visible = false;
                this.stateLabel.Text = "ARCHIWALNY";
            }
        }

        async private void activateButton_Click(object sender, EventArgs e)
        {
            await kek2.Activate(product.ProductID);
            stateLabel.Text = "AKTYWNY";
            activateButton.Visible = false;
        }

        private void imageButton_Click(object sender, EventArgs e)
        {

        }

        async private void saveChangesButton_Click(object sender, EventArgs e)
        {
            int state;
            Bitmap image;
            if (productPictureBox.Image == Properties.Resources.NoPicture)
                image = null;
            else
                image = (Bitmap)productPictureBox.Image;
            if (radioButton1.Checked)
                state = 0;
            else if (radioButton2.Checked)
                state = 1;
            else
                state = 2;
            decimal discount;
            decimal? discoun2 = null;
            if (decimal.TryParse(textBox1.Text, out discount))
                discoun2 = discount;
            long cat_id = categoriesList.Find(x => x.Name == categoryComboBox.SelectedItem.ToString()).CategoryID;
            await kek2.ProductModification(
                product.ProductID,
                nameTextbox.Text,
                decimal.Parse(priceTextbox.Text),
                state,
                discoun2,
                decimal.Parse(amountTextbox.Text),
                descriptionTextBox.Text,
                image,
                cat_id
            );

            InterfaceToDataBaseProductMethods methods = new InterfaceToDataBaseProductMethods();
            List<Product> products = await methods.CatalogProducts();
            foreach (var product in products)
                this.Parent.Controls.Add(new ProductMiniDataAdminControl(product));
            this.Parent.Controls.Remove(this);
        }
    }
}
