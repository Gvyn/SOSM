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
            SetDefaultSearch();
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
            Search();
        }
        private void Search()
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
            else
            {
                SetDefaultSearch();
            }

        }
        private void SetCategory()
        {
            List<String> list = new List<string>();
            list.Add(ConverseCategory(1));
            for (int i = 3; i < 9; i++)
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
        private async void SearchHistory()
        {
            HistoryUserControl history;

            int category = ReverseCategory(categoryBox.SelectedItem.ToString());
            if (category == 0)
            {
                InterfaceToDataBaseUserMethods Methods = new InterfaceToDataBaseUserMethods();
                User userData = await Methods.GetUserData(long.Parse(searchBox.Text));
                if (userData != null)
                    history = new HistoryUserControl(userData, true);
                else
                    history = null;
            }
            else if (category == 1)
            {
                InterfaceToDataBaseUserMethods Methods = new InterfaceToDataBaseUserMethods();
                User userData = await Methods.GetUserData(searchBox.Text);
                if (userData != null);
                history = new HistoryUserControl(userData, true);
            }
            else if (category == 2)
            {
                history = new HistoryUserControl(long.Parse(searchBox.Text), true);
            }
            else if (category == 3)
            {
                InterfaceToDataBaseProductMethods Methods = new InterfaceToDataBaseProductMethods();
                history = new HistoryUserControl(await Methods.GetProductId(searchBox.Text), true);
            }
            else if(category >3 && category < 9)
            {
                history = new HistoryUserControl(MakeDate(category - 3), category - 3, true);
            }
            else
            {
                throw new ArgumentException();
            }
            history.Dock = DockStyle.Fill;
            histPanel.Controls.Add(history);
        }

        private bool VerifyAttribute()
        {
            int category = ReverseCategory(categoryBox.SelectedItem.ToString());
            bool result = false;
            if (category == 0 || category == 2 )
            {
                result = VerifyID();
            }
            else if(category == 1 || category == 3)
            {
                result = true;
            }
            else
            {
                result = VerifyDate(category - 3);
            }

            return result;
        }
        private bool VerifyID()
        {
            long value;
            bool result = long.TryParse(searchBox.Text, out value);
            if(!result)
            {
                MessageBox.Show("ID musi być liczbą całkowitą!");
            }
            if (result && value < 0)
            {
                MessageBox.Show("ID musi być nieujemne!");
                result = false;
            }
            return result;
        }
        private bool VerifyDate(int comparePosition)
        {
            bool result = false;
            string input = searchBox.Text;

            if (input.Length != 4 + 3 * (comparePosition - 1))
            {
                MessageBox.Show("Długość daty jest nieprawidłowa!");
                return false;
            }

            if (comparePosition > 0)
            {
                int check;
                result = int.TryParse(input.Substring(0, 4), out check);
            }
            if (result && comparePosition > 1)
            {
                int check;
                result = int.TryParse(input.Substring(5, 2), out check);
            }
            if (result && comparePosition > 2)
            {
                int check;
                result = int.TryParse(input.Substring(8, 2), out check);
            }
            if (result && comparePosition > 3)
            {
                int check;
                result = int.TryParse(input.Substring(11, 2), out check);
            }
            if (result && comparePosition > 4)
            {
                int check;
                result = int.TryParse(input.Substring(14, 2), out check);
            }
            if (result)
            {
                try
                {
                    MakeDate(comparePosition);
                }
                catch(ArgumentOutOfRangeException)
                {
                    result = false;
                }
            }
            if(!result)
            {
                MessageBox.Show("To nie jest poprawna data!");
            }
            return result;
        }
        private DateTime MakeDate( int comparePosition = 3)
        {
            if (comparePosition < 1 || comparePosition > 5)
                throw new ArgumentException();
            

            string input = searchBox.Text;
            int year, month, day, hour, minute;

            year = DateTime.Now.Year;
            month = DateTime.Now.Month;
            day = DateTime.Now.Day;
            hour = DateTime.Now.Hour;
            minute = DateTime.Now.Minute;
            if (comparePosition > 0) 
            {
                year = int.Parse(input.Substring(0, 4));
            }
            if (comparePosition > 1)
            {
                month = int.Parse(input.Substring(5, 2));
            }
            if (comparePosition > 2)
            {
                day = int.Parse(input.Substring(8, 2));
            }
            if (comparePosition > 3)
            {
                hour = int.Parse(input.Substring(11, 2));
            }
            if (comparePosition > 4)
            {
                minute = int.Parse(input.Substring(14, 2));
            }

            return new DateTime(year, month, day, hour, minute, DateTime.Now.Second);
        }

        private void categoryBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SetDefaultSearch();
        }
        private void SetDefaultSearch()
        {
            int category = ReverseCategory(categoryBox.SelectedItem.ToString());
            switch (category)
            {
                case 0:
                    searchBox.Text = "UserID";
                    break;
                case 1:
                    searchBox.Text = "UserName";
                    break;
                case 2:
                    searchBox.Text = "ProductID";
                    break;
                case 3:
                    searchBox.Text = "ProductName";
                    break;
                case 4:
                    searchBox.Text = "YYYY";
                    break;
                case 5:
                    searchBox.Text = "YYYY:MM";
                    break;
                case 6:
                    searchBox.Text = "YYYY:MM:DD";
                    break;
                case 7:
                    searchBox.Text = "YYYY:MM:DD:hh";
                    break;
                case 8:
                    searchBox.Text = "YYYY:MM:DD:hh:mm";
                    break;
            }

        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                Search();
                e.Handled = true;
            }
        }
    }
}
