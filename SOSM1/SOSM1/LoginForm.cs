using System;
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

        private void button1_Click(object sender, EventArgs e)
        {
            exit = 1;
            Close();
        }
    }
}
