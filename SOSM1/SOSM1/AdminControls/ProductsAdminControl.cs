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
    public partial class ProductsAdminControl : UserControl
    {
        InterfaceToDataBaseProductMethods methods;
        public ProductsAdminControl()
        {
            InitializeComponent();
            methods = new InterfaceToDataBaseProductMethods();
        }

        private async void ProductsAdminControl_Load(object sender, EventArgs e)
        {
            List<Product> products = await methods.CatalogProducts();
            foreach (var product in products)
                flowLayoutPanel1.Controls.Add(new ProductMiniDataAdminControl(product));
        }
    }
}
