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
    public partial class SalesAdminControl : UserControl
    {
        public SalesAdminControl()
        {
            InitializeComponent();
            SetCategory();
            SetHistory();
        }


        private void SetHistory()
        {
            HistoryUserControl history = new HistoryUserControl(true);
            history.Dock = DockStyle.Fill;
            histPanel.Controls.Add(history);
        }

        private void CleanHistory()
        {
            if (histPanel.Controls.Count > 0)
                histPanel.Controls[0].Dispose();
            histPanel.Controls.Clear();
        }

        private void allButton_Click(object sender, EventArgs e)
        {
            CleanHistory();
            SetHistory();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchBox.Text.Length < 1) 
            {
                MessageBox.Show("Wprowadź atrybut wyszukiwania");
                return;
            }
            if (VerifyAttribute())
            {
                CleanHistory();
                SearchHistory();
            }

        }
        private void SetCategory()
        {
            List<String> list = new List<string>();
            for (int i = 0; i < 6; i++)
            {
                list.Add(ConverseCategory(i));
            }
            categoryBox.DataSource = list;
            categoryBox.SelectedIndex = 0;
        }

        private int ReverseCategory(string category)
        {
            if (category == "ID użytkownika")
                return 0;
            else if (category == "Nazwie użytkownika")
                return 1;
            else if (category == "ID produktu")
                return 2;
            else if (category == "Nazwie produktu")
                return 3;
            else if (category == "Dacie(rok)")
                return 4;
            else if (category == "Dacie(miesiąc)")
                return 5;
            else if (category == "Dacie(dzień)")
                return 6;
            else if (category == "Dacie(godzina)")
                return 7;
            else if (category == "Dacie(minuta)")
                return 8;
            throw new ArgumentException();


        }
        private string ConverseCategory(int category)
        {
            string result = null;
            switch (category)
            {
                case 0:
                    result = "ID użytkownika";
                    break;
                case 1:
                    result = "Nazwie użytkownika";
                    break;
                case 2:
                    result = "ID produktu";
                    break;
                case 3:
                    result = "Nazwie produktu";
                    break;
                case 4:
                    result = "Dacie(rok)";
                    break;
                case 5:
                    result = "Dacie(miesiąc)";
                    break;
                case 6:
                    result = "Dacie(dzień)";
                    break;
                case 7:
                    result = "Dacie(godzina)";
                    break;
                case 8:
                    result = "Dacie(minuta)";
                    break;
            }
            if(result == null)
            {
                throw new ArgumentException();
            }
            return result;
        }
        private void SearchHistory()
        {
            throw new NotImplementedException();
        }

        private bool VerifyAttribute()
        {
            return false;
        }
        private void categoryBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int category = ReverseCategory(categoryBox.SelectedItem.ToString());
            
        }
    }
}
