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
        private void SetContactInfo()
        {
            try
            {
                contactLabel.Text = InterfaceToDataBaseOtherMethods.GetContactInfo();
            }
            catch (NotImplementedException)//kick when implemented (empty contact info is their choice)
            {
                contactLabel.Text = Properties.Resources.DefaultContactInfo;
            }
            contactLabel.Text += "\n\n" + Properties.Resources.SOSMContactInfo;

        }
    }
}
