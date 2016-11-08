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
        private int exit = 0;
        private User loggedUserData;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            switch (exit)
            {
                case 1:
                    this.Visible = false;
                    (new Form1()).ShowDialog();//Put main form with User loggedUserData
                    break;
                case 2:
                    this.Visible = false;
                    (new SignUp()).ShowDialog();
                    break;
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(userNameBox.Text.Length==0)
            {
                MessageBox.Show("Wpisz nazwę użytkownika!");
                return;

            }
            if(passwordBox.Text.Length==0)
            {
                MessageBox.Show("Wpisz hasło!");
                return;
            }
            passwordBox.Text += "PseudoSaltWhateverAKB48<3!";
            byte[] data = Encoding.ASCII.GetBytes(passwordBox.Text);
            data = new System.Security.Cryptography.SHA512Managed().ComputeHash(data);
            String hash = Encoding.ASCII.GetString(data);

            if(InterfaceToDataBaseUserMethods.LogIn(userNameBox.Text, hash, out loggedUserData))
            {
                exit = 1;
                Close();
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
            exit = 2;
            Close();

        }
    }
}
