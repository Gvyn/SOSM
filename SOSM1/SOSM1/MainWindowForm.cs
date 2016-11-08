using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOSM1
{
    public partial class MainWindowForm : Form
    {
        private User loggedUserData;
        public MainWindowForm(User loggedUserData)
        {
            InitializeComponent();
            this.loggedUserData = loggedUserData;
            profileButton.Text = this.loggedUserData.UserName;
            if (this.loggedUserData.Type == 1)
                adminButton.Visible = true;
            SetHomeUserControl();
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.logo;
        }



        private void homeButton_Click(object sender, EventArgs e)
        {
            SetHomeUserControl();
        }

        private void SetHomeUserControl()
        {
            sectionLabel.Text = "Strona główna";
        }


        private void productsButton_Click(object sender, EventArgs e)
        {
            SetProductsUserControl();
        }
        private void SetProductsUserControl()
        {
            sectionLabel.Text = "Katalog produktów";
        }


        private void adminButton_Click(object sender, EventArgs e)
        {
            SetAdminsUserControl();
        }
        private void SetAdminsUserControl()
        {
            sectionLabel.Text = "Panel administracyjny";
        }


        private void contactButton_Click(object sender, EventArgs e)
        {
            SetContactsUserControl();
        }
        private void SetContactsUserControl()
        {
            sectionLabel.Text = "Kontakt";
        }


        private void logoutButton_Click(object sender, EventArgs e)
        {
            Logout();
        }
        private void Logout()
        {
            this.Visible = false;
            loggedUserData = null;
            (new LoginForm()).ShowDialog();
            Close();
        }

    }
}
