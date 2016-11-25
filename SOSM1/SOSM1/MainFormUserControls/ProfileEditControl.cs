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
    public partial class ProfileEditControl : UserControl
    {
        User userData;
        bool adminPrivilege;

        public ProfileEditControl(User userData)
        {
            InitializeComponent();
            Init(userData, userData.Type == 1);
        }

        public ProfileEditControl(User userData, bool adminPrivilege)
        {
            InitializeComponent();
            Init(userData, adminPrivilege);

        }
        private void Init(User userData, bool adminPrivilege)
        {
            if (userData.State == 2)
                throw new ArgumentException();
            this.userData = userData;
            this.adminPrivilege = adminPrivilege;
            SetData();

        }

        private void SetData()
        {
            nameLabel.Text = userData.UserName;
            nameBox.Text = userData.UserName;

            mailLabel.Text = userData.Mail;
            mailBox.Text = userData.Mail;

            stateLabel.Text = StateString(userData.State);

            typeLabel.Text = TypeString(userData.Type);

            if(adminPrivilege)
            {
                List<String> types = new List<string>();
                types.Add(TypeString(0));
                types.Add(TypeString(1));

                typeBox.DataSource = types;
                typeBox.SelectedItem = typeLabel.Text;
            }
            else
            {
                typeBox.Visible = false;
            }


        }

        private long ReverseTypeString(string userType)
        {
            if (userType == "Użytkownik standardowy")
                return 0;
            else if (userType == "Administrator")
                return 1;
            throw new ArgumentException();


        }
        private string TypeString(long userType)
        {
            string result;
            if (userType == 0)
            {
                result = "Użytkownik standardowy";
            }
            else if (userType == 1)
            {
                result = "Administrator";
            }
            else
            {
                throw new ArgumentException();
            }
            return result;
        }
        private string StateString(long userState)
        {
            string result;
            if (userState == 0)
            {
                result = "Użytkownik stworzony.";
            }
            else if (userState == 1)
            {
                result = "Użytkownik aktywny.";
            }
            else if (userState == 2)
            {
                result = "Użytkownik archiwalny.";
            }
            else
            {
                throw new ArgumentException();
            }
            return result;
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            
        }
        private async Task<bool> VerifyName()
        {
            if(nameBox.Text.Length<1)
            {
                MessageBox.Show("Nazwa użytkownika nie może być pusta!");
                return false;
            }

            if (userData.UserName == nameBox.Text)
                return true;
            InterfaceToDataBaseUserMethods Methods = new InterfaceToDataBaseUserMethods();
            if (await Methods.NameExists(nameBox.Text))
            {
                MessageBox.Show("Nazwa użytkownika jest zajęta.");
                return false;
            }
            return true;
        }

        private void passwordButton_Click(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }
        
    }
}
