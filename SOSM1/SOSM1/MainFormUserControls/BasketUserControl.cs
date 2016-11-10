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
        public BasketUserControl(List<Basket> loggedUserBasket)
        {
            InitializeComponent();
            basketsFlowPanel.Controls.Add(new BasketDataUserControl());
            foreach (Basket basket in loggedUserBasket)
            {
                BasketDataUserControl newBasket = new BasketDataUserControl(basket);
                basketsFlowPanel.Controls.Add(newBasket);
                sum += newBasket.sum;
            }
            sumPriceLabel.Text = sum + "zł";
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
