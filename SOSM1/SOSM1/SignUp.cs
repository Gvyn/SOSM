﻿using System;
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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.logo;
        }

        private int exit = 0;
        private void SignUp_FormClosed(object sender, FormClosedEventArgs e)
        {
            switch (exit)
            {
                case 1:
                    this.Visible = false;
                    (new LoginForm()).ShowDialog();
                    break;
            }
        }

        private void signButton_Click(object sender, EventArgs e)
        {
            if (userNameBox.Text.Length == 0)
            {
                MessageBox.Show("Wpisz nazwę użytkownika!");
                return;

            }
            if (mailBox.Text.Length == 0) 
            {
                MessageBox.Show("Wpisz adres e-mail!");
            }

            if (passwordBox.Text.Length == 0)
            {
                MessageBox.Show("Wpisz hasło!");
                return;
            }
            if (passwordBox.Text.Length < 6) 
            {
                MessageBox.Show("Hasło musi mieć przynajmniej 6 znaków.");
                return;
            }
            if (repeatPasswordBox.Text.Length == 0)
            {
                MessageBox.Show("Powtórz hasło!");
                return;
            }
            
            if(!passwordBox.Text.Equals(repeatPasswordBox.Text))
            {
                MessageBox.Show("Hasła muszą się zgadzać!");
                return;
            }
            try
            {
                User newUser = new User(userNameBox.Text, mailBox.Text, 0, 0);

                String hash = passwordBox.Text + "PseudoSaltWhateverAKB48<3!" + userNameBox.Text;
                byte[] data = Encoding.ASCII.GetBytes(hash);
                data = new System.Security.Cryptography.SHA512Managed().ComputeHash(data);
                hash = Encoding.ASCII.GetString(data);

                if (InterfaceToDataBaseUserMethods.AddUser(newUser, hash))
                {
                    exit = 1;
                    Close();
                }
                else
                {
                    MessageBox.Show("Istnieje już użytkownik o tej nazwie.");
                    return;
                }
            }
            catch (Exception ex) when ( ex is ArgumentNullException)
            {
                MessageBox.Show("Wpisz nazwę użytkownika!");
                return;
            }
            catch (Exception ex) when (ex is ArgumentException)
            {
                MessageBox.Show("Wpisz prawidłowy adres email!");
                return;
            }
            catch (Exception ex) when (ex is ArgumentOutOfRangeException)
            {
                MessageBox.Show("Typ lub stan użytkownika nie jest prawidłowy.");
                return;
            }
        }
    }
}
