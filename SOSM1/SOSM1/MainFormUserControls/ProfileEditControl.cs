using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

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

            DescLabel.Text= typeBox.SelectedItem.ToString();
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

        private async void changeButton_Click(object sender, EventArgs e)
        {
            bool correctData;
            //correctData= await VerifyName();
            correctData = VerifyMail();// && correctData;
            if (correctData && MakeSure())
            {
                InterfaceToDataBaseUserMethods Methods = new InterfaceToDataBaseUserMethods();
                if (adminPrivilege)
                {
                    correctData = await Methods.ChangeType(userData.UserID, ReverseTypeString(typeBox.SelectedItem.ToString()));
                }
                if (correctData)
                {
                    await Methods.UserModification(userData.UserID, null, mailBox.Text);
                    mailLabel.Text = mailBox.Text;
                    userData.Mail = mailLabel.Text;
                    if(adminPrivilege)
                    {
                        typeLabel.Text = typeBox.SelectedItem.ToString();
                        userData.Type = ReverseTypeString(typeBox.SelectedItem.ToString());
                    }
                    MessageBox.Show("Pomyślnie dokonano zmian.");
                }
                else
                {
                    MessageBox.Show("Jesteś ostatim administratorem, nie możesz sobie odebrać uprawnień!");
                }

            }
        }
        private async Task<bool> VerifyName()
        {
            if (nameBox.Text.Length < 1)
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
        private bool VerifyMail()
        {
           if( (new EmailAddressAttribute().IsValid(mailBox.Text)))
            {
                return true;
            }
           else
            {
                MessageBox.Show("To nie jest poprawny adres e-mail.");
                return false;
            }
        }

        private bool VerifyPasswords()
        {
            bool result = false;
            if (newPasBox.Text.Length == 0)
            {
                MessageBox.Show("Wprowadź nowe hasło!");
            }
            else if (newPasBox.Text.Length < 6)
            {
                MessageBox.Show("Hasło musi mieć przynajmniej 6 znaków.");
            }
            else if (newPas2Box.Text.Length == 0) 
            {
                MessageBox.Show("Powtórz hasło!");
            }
            else if (newPasBox.Text != newPas2Box.Text) 
            {
                MessageBox.Show("Hasła muszą się zgadzać!");
            }
            else
            {
                result = true;
            }
            return result;
        }
        private async void passwordButton_Click(object sender, EventArgs e)
        {

            if (VerifyPasswords() && MakeSure()) 
            {
                String hash = newPasBox.Text + "PseudoSaltWhateverAKB48<3!" + userData.UserName;
                byte[] data = Encoding.ASCII.GetBytes(hash);
                data = new System.Security.Cryptography.SHA512Managed().ComputeHash(data);
                hash = Encoding.ASCII.GetString(data);

                InterfaceToDataBaseUserMethods Methods = new InterfaceToDataBaseUserMethods();
                await Methods.UserModification(userData.UserID, null, null,hash);
                newPasBox.Text = null;
                newPas2Box.Text = null;
                MessageBox.Show("Pomyślnie zmieniono hasło.");


            }
        }

        private async void deleteButton_Click(object sender, EventArgs e)
        {
            if (MakeSure())
            {
                InterfaceToDataBaseUserMethods Methods = new InterfaceToDataBaseUserMethods();
                if (await Methods.DeleteUser(userData.UserID))
                {
                    MessageBox.Show("Bardzo nam przykro.");
                    MainWindowForm mainForm = (MainWindowForm)Application.OpenForms["MainWindowForm"];
                    mainForm.Logout();
                }
                else
                {
                    MessageBox.Show("Jesteś ostatim administratorem, nie możesz usunąć swojego konta.");
                }
            }
        }
        private bool MakeSure()
        {
            DialogResult dialogResult = MessageBox.Show("Czy na pewno chcesz dokonać tych zmian?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
        
    }
}
