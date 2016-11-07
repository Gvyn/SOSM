using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSM1
{
    public class Sale
    {
        public Sale(int UserID)
        {
            saleID = -1;
            this.UserID = UserID;
            Date = DateTime.Now;
        }

        private int saleID;
        public int SaleID
        {
            get
            {
                return saleID;
            }
            set
            {
                saleID = value;
            }
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

        private DateTime date;
        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
            }
        }

    }
}
