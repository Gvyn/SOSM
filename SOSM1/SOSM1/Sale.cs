using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSM1
{
    public class Sale
    {
        public Sale(long UserID)
        {
            SaleID = -1;
            this.UserID = UserID;
            Date = DateTime.Now;
        }

        private long saleID;
        public long SaleID
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

        private long userID;
        public long UserID
        {
            get
            {
                return userID;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
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
