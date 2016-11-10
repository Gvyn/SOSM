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
    public partial class ProductsUserControl : UserControl
    {
        private string searchArgument = null;
        private long? categoryID = null;
        public ProductsUserControl()
        {
            InitializeComponent();
            SetCategoryTree();
            SearchCatalog();
        }
        public ProductsUserControl(long CategoryID)
        {
            InitializeComponent();
            categoryID = CategoryID;
            SetCategoryTree(categoryID);
            SearchCatalog();
        }
        public ProductsUserControl(string SearchArgument)
        {
            InitializeComponent();
            SetCategoryTree();
            searchArgument = SearchArgument;
            SearchCatalog();
        }

        private void SetCategoryTree(long? MarkedId = null)
        {
            RadioButtonWithID all = new RadioButtonWithID(null);
            all.Checked = true;
            all.Text = "Wszystkie";
            all.CheckedChanged += All_CheckedChanged;
            categoryFlowPanel.Controls.Add(all);
            List<Category> Categories = InterfaceToDataBaseCategoryMethods.GetAllCategories();
            foreach (Category category in Categories)
            {
                RadioButtonWithID add = new RadioButtonWithID(category.CategoryID);
                if (category.CategoryID == MarkedId)
                {
                    all.Checked = false;
                    add.Checked = true;
                }
                else
                    add.Checked = false;
                add.Text = category.Name;
                add.CheckedChanged += All_CheckedChanged;
                categoryFlowPanel.Controls.Add(add);

            }
        }
        
        private void All_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButtonWithID).Checked == true)
            {
                categoryID = (sender as RadioButtonWithID).ID;
                SearchCatalog();
                searchButton.Text = categoryID.ToString();
            }
        }

        private void SearchCatalog()
        {
            productsFlowPanel.Controls.Clear();
            List<Product> products = InterfaceToDataBaseProductMethods.CatalogProducts(searchArgument, categoryID, 1);
            foreach(Product product in products)
            {
                productsFlowPanel.Controls.Add(new ProductDataUserControl(product));
            }
        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            setSearchWatermarkOff();
        }
        private void setSearchWatermarkOff()
        {
            if (searchTextBox.ForeColor != SystemColors.WindowText)
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
            if (searchTextBox.ForeColor == SystemColors.WindowText && searchTextBox.Text != "")
            {
                searchArgument = searchTextBox.Text;
                SearchCatalog();
            }
        }

    }

    class RadioButtonWithID :RadioButton
    {
        public RadioButtonWithID(long? id) : base()
        {
            ID = id;
            AutoSize = true;
            Font = new Font("Arial", 14);
        }
        private long? id;
        public long? ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
    }
}
