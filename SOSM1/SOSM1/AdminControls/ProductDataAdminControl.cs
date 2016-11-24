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
    public partial class ProductDataAdminControl : UserControl
    {
        private Product productDataObject;

        public ProductDataAdminControl(Product productDataObject)
        {
            InitializeComponent();
            this.productDataObject = productDataObject;
            SetProductData();
        }

        private void SetProductData()
        {
            
        }

    }
}
