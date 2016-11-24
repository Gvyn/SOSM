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
        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
    }
}
