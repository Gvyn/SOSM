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
    public partial class MainWindowForm : Form
    {
        private User loggedUserData;
        public MainWindowForm(User loggedUserData)
        {
            InitializeComponent();
            this.loggedUserData = loggedUserData;
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            Icon = Properties.Resources.logo;
        }
    }
}
