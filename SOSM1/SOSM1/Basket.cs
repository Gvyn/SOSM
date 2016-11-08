using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSM1
{
    public class Basket
    {
        public Basket(User BasketOwner, Product ProductInBasket, decimal Amount)
        {
            this.BasketID = -1;
            this.BasketOwner = BasketOwner;
            this.ProductInBasket = ProductInBasket;
            this.Amount = Amount;
            this.Date = System.DateTime.Now;
        }

        private int basketID;
        public int BasketID
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
        private User basketOwner;
        public User BasketOwner
        {
            get
            {
                return basketOwner;
            }
            set
            {
                if (value.UserID < 0)
                    throw new ArgumentOutOfRangeException(); 
                basketOwner = value;
            }
        }

        private Product productInBasket;
        public Product ProductInBasket
        {
            get
            {
                return productInBasket;
            }
            set
            {
                productInBasket = value;
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
                // UnitType 0 is 'pieces', amount must integer number
                if (productInBasket.UnitType == 0 && value % 1 != 0)
                    throw new ArgumentOutOfRangeException();
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
