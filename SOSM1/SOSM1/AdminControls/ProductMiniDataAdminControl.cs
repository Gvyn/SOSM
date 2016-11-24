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
    public partial class ProductMiniDataAdminControl : UserControl
    {
        Product product;
        public ProductMiniDataAdminControl(Product _product)
        {
            InitializeComponent();
            product = _product;
            label1.Text = product.ProductName;
            if (product.Picture != null)
                pictureBox1.Image = product.Picture;
            else
                pictureBox1.Image = Properties.Resources.NoPicture;
            switch (product.State)
            {
                case 0:
                    label1.Text = "NIEAKTYWNY";
                    break;
                case 1:
                    label2.Text = "AKTYWNY";
                    break;
                case 2:
                    deleteButton.Hide();
                    label3.Text = "ARCHIWALNY";
                    break;
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Parent.Controls)
                if (c != this)
                    this.Parent.Controls.Remove(c);
            this.Parent.Controls.Add(new ProductDataAdminControl(product));
            this.Parent.Controls.Remove(this);
        }

        async private void deleteButton_Click(object sender, EventArgs e)
        {
            InterfaceToDataBaseProductMethods kek = new InterfaceToDataBaseProductMethods();
            await kek.DeleteProduct(product.ProductName);
            product = await kek.GetProductData(product.ProductID);

            if (product == null)
                this.Parent.Controls.Remove(this);
            if (product.State == 1)
                label3.Text = "AKTYWNY";
            if (product.State == 2)
                label3.Text = "ARCHIWALNY";
        }
    }
}
