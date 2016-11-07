using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSM1
{
    public class User
    {
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
