using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSM1
{
    public class Basket
    {
        public Basket(long UserID, long ProductID, decimal Amount, System.DateTime? date = null)
        {
            this.BasketID = -1;
            this.UserID = UserID;
            this.ProductID = ProductID;
            this.Amount = Amount;
            if (date != null)
                this.Date = (System.DateTime)date;
            else
                this.Date = System.DateTime.Now;
        }

        private long basketID;
        public long BasketID
        {
            get
            {
                return basketID;
            }
            set
            {
                basketID = value;
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

        private long productID;
        public long ProductID
        {
            get
            {
                return productID;
            }
            set
            {
                productID = value;
            }
        }

        private decimal amount;
        public decimal Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }

        private System.DateTime date;
        public System.DateTime Date
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

        public decimal TotalCost()
        {
            throw new NotImplementedException();
        }
    }
}
