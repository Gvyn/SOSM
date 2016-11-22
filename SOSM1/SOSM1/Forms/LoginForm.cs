using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOSM1
{
    public partial class LoginForm : Form
    {
        private User loggedUserData;
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (userNameBox.Text.Length == 0)
            {
                MessageBox.Show("Wpisz nazwę użytkownika!");
                return;

            }
            if (passwordBox.Text.Length == 0)
            {
                MessageBox.Show("Wpisz hasło!");
                return;
            }

            String hash = passwordBox.Text + "PseudoSaltWhateverAKB48<3!" + userNameBox.Text;
            byte[] data = Encoding.ASCII.GetBytes(hash);
            data = new System.Security.Cryptography.SHA512Managed().ComputeHash(data);
            hash = Encoding.ASCII.GetString(data);

            InterfaceToDataBaseUserMethods Method = new InterfaceToDataBaseUserMethods();
            loggedUserData = await Method.LogIn(userNameBox.Text, hash);
            if (loggedUserData != null)
            {
                ToMain();
            }
            else
            {
                MessageBox.Show("Nieprawidłowe dane logowania!");
                return;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.logo;
        }

        private void signButton_Click(object sender, EventArgs e)
        {
            ToSignUp();

        }

        private void ToMain()
        {
            this.Visible = false;
            (new MainWindowForm(loggedUserData)).ShowDialog();
            Close();
        }

        private void ToSignUp()
        {
            this.Visible = false;
            (new SignUp()).ShowDialog();
            Close();

        }
    }
}
