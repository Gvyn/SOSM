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
    public partial class SettingsAdminControl : UserControl
    {
        private InterfaceToDataBaseOtherMethods methods;

        public SettingsAdminControl()
        {
            InitializeComponent();
            methods = new InterfaceToDataBaseOtherMethods();
            contactInfoTextbox.Text = methods.GetContactInfo().Result;
            welcomeMessageTextbox.Text = methods.GetWelcomeMessage().Result;
        }

        private async void welcomeMessageButton_Click(object sender, EventArgs e)
        {
            await methods.SetWelcomeMessage(welcomeMessageTextbox.Text);
            MessageBox.Show("Zmieniono wiadomość powitalną");
        }

        private async void contactInfoButton_Click(object sender, EventArgs e)
        {
            await methods.SetContactInfo(contactInfoTextbox.Text);
            MessageBox.Show("Zmieniono dane kontaktowe");
        }
    }
}
