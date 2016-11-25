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
    public partial class ContactUserControl : UserControl
    {
        public ContactUserControl()
        {
            InitializeComponent();
            SetContactInfo();
        }
        private async void SetContactInfo()
        {
            InterfaceToDataBaseOtherMethods Method = new InterfaceToDataBaseOtherMethods();
            contactLabel.Text = await Method.GetContactInfo();
            if (contactLabel.Text == null)
                contactLabel.Text = Properties.Resources.DefaultContactInfo;
            contactLabel.Text += "\n\n" + Properties.Resources.SOSMContactInfo;

        }
    }
}
