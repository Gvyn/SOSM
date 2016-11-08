using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSM1
{
    public class User
    {
        public User(string UserName, string Mail, long Type, long State)
        {
            UserID = -1;
            this.UserName = UserName;
            this.Mail = Mail;
            this.Type = Type;
            this.State = State;
        }

        private long userID;
        public long UserID
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
                if (!(new EmailAddressAttribute().IsValid(value)))
                    throw new ArgumentException();
                mail = value;
            }
        }

        /// <summary>
        /// 0 - normal
        /// 1 - admin
        /// </summary>
        private long type;
        /// <summary>
        /// 0 - normal
        /// 1 - admin
        /// </summary>
        public long Type
        {
            get
            {
                return type;
            }
            set
            {
                if (value < 0 || value > 1)
                    throw new ArgumentOutOfRangeException();
                type = value;
            }
        }

        /// <summary>
        /// 0 - Created
        /// 1 - Active
        /// 2 - Archival
        /// </summary>
        private long state;
        /// <summary>
        /// 0 - Created
        /// 1 - Active
        /// 2 - Archival
        /// </summary>
        public long State
        {
            get
            {
                return state;
            }
            set
            {
                if (value < 0 || value > 2)
                    throw new ArgumentOutOfRangeException();
                state = value;
            }
        }

    }
}
