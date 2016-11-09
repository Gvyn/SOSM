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
            priceLabel.Text ="Cena: "+productDataObject.Discount+ "zł za ";
            switch (productDataObject.UnitType)
            {
                case 0:
                    priceLabel.Text += "sztukę";
                    break;
                case 1:
                    priceLabel.Text += "kilogram";
                    break;
                case 2:
                    priceLabel.Text += "litr";
                    break;
            }
        }
    }
}
