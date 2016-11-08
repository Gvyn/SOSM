using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSM1
{
    public class User
    {
        User(string UserName, string Mail, int Type, int State)
        {
            UserID = -1;
            this.UserName = UserName;
            this.Mail = Mail;
            this.Type = Type;
            this.State = State;
        }

        private int userID;
        public int UserID
        {
            get
            {
                return userID;
            }
            set
            {
                userID = value;
            }
        }

        private string userName;
        public string UserName
        {
            get
            {
                return userName;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();
                userName = value;
            }
        }

        private string mail;
        public string Mail
        {
            get
            {
                return mail;
            }
            set
            {
                mail = value;
            }
        }

        private int type;
        public int Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }

        private int state;
        public int State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }

    }
}
