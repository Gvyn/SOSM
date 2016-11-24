using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SOSM1.AdminControls;

namespace SOSM1
{
    public partial class AdminUserControl : UserControl
    {
        public AdminUserControl()
        {
            InitializeComponent();
        }

        private void SwapAdminControl(UserControl newAdminControl)
        {
            if (newAdminControl == null)
                throw new ArgumentNullException();
            if (adminControlPanel.Controls.Count == 1 && newAdminControl.GetType().Equals(adminControlPanel.Controls[0].GetType()))
                return;
            newAdminControl.Dock = DockStyle.Fill;

            List<Control> ctrls = new List<Control>();
            foreach (Control c in adminControlPanel.Controls)
                ctrls.Add(c);
            adminControlPanel.Controls.Clear();
            foreach (Control c in ctrls)
                c.Dispose();

            adminControlPanel.Controls.Add(newAdminControl);
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            SwapAdminControl(new ProductsAdminControl());
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            SwapAdminControl(new UsersAdminControl());
        }

        private void buttonSales_Click(object sender, EventArgs e)
        {
            SwapAdminControl(new SalesAdminControl());
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SwapAdminControl(new SettingsAdminControl());
        }
    }
}
