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
    public partial class BasketUserControl : UserControl
    {
        private decimal sum = 0;
        List<Basket> loggedUserBasket;
        public BasketUserControl(ref User loggedUserData)
        {
            InitializeComponent();
            basketsFlowPanel.Controls.Add(new BasketDataUserControl());
            InterfaceToDataBaseBasketMethods Methods = new InterfaceToDataBaseBasketMethods();
            loggedUserBasket = Methods.RetrieveBaskets(loggedUserData.UserID).Result;
            if (loggedUserBasket.Count != 0)
            {
                foreach (Basket basket in loggedUserBasket)
                {
                    BasketDataUserControl newBasket = new BasketDataUserControl(basket);
                    basketsFlowPanel.Controls.Add(newBasket);
                    sum += newBasket.sum;
                }
                sumPriceLabel.Text = "Łączny koszt transakcji: " + sum + "zł";
            }
            else
            {
                sumPriceLabel.Visible = false;
                finishTransactionButton.Text = "Koszyk pusty";
                finishTransactionButton.Enabled = false;
            }
        }

        private void finishTransactionButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Upewnij się, że dane są poprawne.\nCzy na pewno chcesz potwierdzić transakcję?", "Potwierdzenie transakcji", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                (ParentForm as MainWindowForm).CommitSale();
            }
        }
    }
}
