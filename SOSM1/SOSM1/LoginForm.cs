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
        public LoginForm()
        {
            InitializeComponent();
        }

        private int exit = 0;
        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            switch (exit)
            {
                case 1:
                    this.Visible = false;
                    (new Form1()).ShowDialog();
                    break;
            }

        }

        private User loggedUser;
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
            byte[] data = System.Text.Encoding.ASCII.GetBytes(passwordBox.Text);
            data = new System.Security.Cryptography.SHA256Managed().ComputeHash(data);
            String hash = System.Text.Encoding.ASCII.GetString(data);
            InterfaceToDataBaseUserMethods.LogIn(userNameBox.Text, passwordBox.Text, out loggedUser);
            exit = 1;
            Close();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.logo;
        }
    }
}
