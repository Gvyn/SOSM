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
        private List<Basket> loggedUserBasket;
        public MainWindowForm(User loggedUserData)
        {
            InitializeComponent();
            this.loggedUserData = loggedUserData;
            profileButton.Text = this.loggedUserData.UserName;
            if (this.loggedUserData.Type == 1)
                adminButton.Visible = true;
            InterfaceToDataBaseBasketMethods Methods = new InterfaceToDataBaseBasketMethods();
            loggedUserBasket = Methods.RetrieveBaskets(loggedUserData.UserID).Result;
            bool deleted = Methods.DeleteBaskets(loggedUserData.UserID).Result;
            basketSizeLabel.Text = loggedUserBasket.Count.ToString();
            SetHomeUserControl();
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.logo;
        }

        protected override async void OnClosed(EventArgs e)
        {
            InterfaceToDataBaseBasketMethods Methods = new InterfaceToDataBaseBasketMethods();
            await Methods.SaveBaskets(loggedUserBasket);
            base.OnClosed(e);
        }

        private void SwapUserControl(UserControl newUserControl)
        {
            if (newUserControl == null)
                throw new ArgumentNullException();
            if (userControlPanel.Controls.Count == 1 && newUserControl.GetType().Equals(userControlPanel.Controls[0].GetType()))
                return;
            newUserControl.Dock = DockStyle.Fill;
            
            List<Control> ctrls = new List<Control>();
            foreach (Control c in userControlPanel.Controls)
                ctrls.Add(c);
            userControlPanel.Controls.Clear();
            foreach (Control c in ctrls)
                c.Dispose();

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
            SwapUserControl(new ProductsUserControl());
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
            SwapUserControl(new BasketUserControl(loggedUserBasket));
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            SetProfileUserControl();
        }

        private void SetProfileUserControl()
        {
            sectionLabel.Text = "Profil użytkownika";
            SwapUserControl(new ProfileUserControl(ref loggedUserData));
        }

        public void CreateProductWindow(Product ProductDataObject)
        {
            sectionLabel.Text = ProductDataObject.ProductName;
            SwapUserControl(new ProductWindowUserControl(ProductDataObject));
        }
        
        public void CreateProductsCatalog()
        {
            SetProductsUserControl();
        }

        public void CreateProductsCatalog(long CategoryID)
        {
            sectionLabel.Text = "Katalog produktów";
            SwapUserControl(new ProductsUserControl(CategoryID));
        }

        public void CreateProductsCatalog(string SearchArgument)
        {
            sectionLabel.Text = "Katalog produktów";
            SwapUserControl(new ProductsUserControl(SearchArgument));
        }
        
        public decimal GetBasketAmount(long ProductID)
        {
            Basket found = loggedUserBasket.Find(x => x.ProductID == ProductID);
            if (found != null)
                return found.Amount;
            return 0;
        }
        public async void addBasket(long ProductID, decimal Amount, decimal newAmount)
        {
            Basket found = loggedUserBasket.Find(x => x.ProductID == ProductID);
            if (found != null)
            {
                found.Amount += Amount;
            }
            else
            {
                loggedUserBasket.Add(new Basket(loggedUserData.UserID, ProductID, Amount));
                basketSizeLabel.Text = loggedUserBasket.Count.ToString();
            }
            InterfaceToDataBaseProductMethods Methods = new InterfaceToDataBaseProductMethods();

            await Methods.ProductModification(ProductID, null, null, null, null, newAmount);
        }
        public async void ModifyBasket(Basket basketDataObject, decimal newAmount, Product modifiedProduct = null)
        {
            InterfaceToDataBaseProductMethods Methods = new InterfaceToDataBaseProductMethods();
            if (modifiedProduct == null)
                modifiedProduct = await Methods.GetProductData(basketDataObject.ProductID);
            await Methods.ProductModification(basketDataObject.ProductID, null, null, null, null, modifiedProduct.Amount + basketDataObject.Amount - newAmount);
            int index = loggedUserBasket.FindIndex(x => x.BasketID == basketDataObject.BasketID);
            loggedUserBasket[index].Amount = newAmount;
            loggedUserBasket[index].Date = DateTime.Now;
            ForceBasketRefresh();
        }

        public async void RemoveBasket(Basket basketDataObject, Product modifiedProduct = null)
        {
            InterfaceToDataBaseProductMethods Methods = new InterfaceToDataBaseProductMethods();
            if (modifiedProduct == null)
                modifiedProduct = await Methods.GetProductData(basketDataObject.ProductID);
            await Methods.ProductModification(basketDataObject.ProductID, null, null, null, null, basketDataObject.Amount + modifiedProduct.Amount);
            loggedUserBasket.Remove(basketDataObject);
            basketSizeLabel.Text = loggedUserBasket.Count.ToString();
            ForceBasketRefresh();
        }

        private void ForceBasketRefresh()
        {
            BasketUserControl newUserControl = new BasketUserControl(loggedUserBasket);
            newUserControl.Dock = DockStyle.Fill;
            userControlPanel.Controls.Clear();
            userControlPanel.Controls.Add(newUserControl);
        }
        public async void CommitSale()
        {
            InterfaceToDataBaseSaleMethods Methods = new InterfaceToDataBaseSaleMethods();
            await Methods.CreateSale(loggedUserBasket);
            loggedUserBasket.Clear();
            basketSizeLabel.Text = loggedUserBasket.Count.ToString();
            SetHomeUserControl();
        }
    }
}
