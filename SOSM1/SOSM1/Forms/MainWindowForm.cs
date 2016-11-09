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
        private int basketSize;
        public MainWindowForm(User loggedUserData)
        {
            InitializeComponent();
            this.loggedUserData = loggedUserData;
            profileButton.Text = this.loggedUserData.UserName;
            if (this.loggedUserData.Type == 1)
                adminButton.Visible = true;
            basketSize = 0; //insert Userc basket count
            basketSizeLabel.Text = basketSize.ToString();
            SetHomeUserControl();
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.logo;
        }


        private void SwapUserControl(UserControl newUserControl)
        {
            if (newUserControl == null)
                throw new ArgumentNullException();
            if (userControlPanel.Controls.Count == 1 && newUserControl.GetType().Equals(userControlPanel.Controls[0].GetType()))
                return;
            newUserControl.Dock = DockStyle.Fill;
            userControlPanel.Controls.Clear();
            userControlPanel.Controls.Add(newUserControl);
        }
        private void homeButton_Click(object sender, EventArgs e)
        {
            SetHomeUserControl();
        }

        private void SetHomeUserControl()
        {
            sectionLabel.Text = "Strona główna";
            SwapUserControl(new HomeUserControl());
        }


        private void productsButton_Click(object sender, EventArgs e)
        {
            SetProductsUserControl();
        }
        private void SetProductsUserControl()
        {
            sectionLabel.Text = "Katalog produktów";
            SwapUserControl(new ProductUserControl());
        }


        private void adminButton_Click(object sender, EventArgs e)
        {
            SetAdminUserControl();
        }
        private void SetAdminUserControl()
        {
            sectionLabel.Text = "Panel administracyjny";
            SwapUserControl(new AdminUserControl());
        }


        private void contactButton_Click(object sender, EventArgs e)
        {
            SetContactsUserControl();
        }
        private void SetContactsUserControl()
        {
            sectionLabel.Text = "Kontakt";
            SwapUserControl(new ContactUserControl());
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

        private void basketButton_Click(object sender, EventArgs e)
        {
            SetBasketUserControl();
        }

        private void SetBasketUserControl()
        {
            sectionLabel.Text = "Koszyk";
            SwapUserControl(new BasketUserControl());
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            SetProfileUserControl();
        }

        private void SetProfileUserControl()
        {
            sectionLabel.Text = "Profil";
            SwapUserControl(new ProfileUserControl());
        }

        public void CreatePoductWindow(Product ProductDataObject)
        {
            SetProductWindowUserControl(ProductDataObject);
        }
        private void SetProductWindowUserControl(Product ProductDataObject)
        {
            sectionLabel.Text = ProductDataObject.ProductName;
            SwapUserControl(new ProductWindowUserControl(ProductDataObject));
        }
        
        public void IncreaceBasketSize()
        {
            basketSize++;
            basketSizeLabel.Text = basketSize.ToString();
        }
    }
}
