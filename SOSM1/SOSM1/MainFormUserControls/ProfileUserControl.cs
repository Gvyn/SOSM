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
    public partial class ProfileUserControl : UserControl
    {
        User userData;
        public ProfileUserControl(ref User userData)
        {
            InitializeComponent();
            this.userData = userData;
            SetLabels();
            
        }

        private void SetLabels()
        {
            nameLabel.Text = userData.UserName;
            mailLabel.Text = userData.Mail;
            typeLabel.Text = TypeString(userData.Type);
            stateLabel.Text = StateString(userData.State);

        }
        private string TypeString(long userType)
        {
            string result;
            if(userType==0)
            {
                result = "Użytkownik standardowy.";
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

        private void historyButton_Click(object sender, EventArgs e)
        {
            (ParentForm as MainWindowForm).CreateHistoryControl(userData);
        }
    }
}
