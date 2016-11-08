using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSM1
{
    public class Order
    {
        public Order(long SaleID, int ProductID, decimal Amount, decimal Price)
        {
            this.OrderID = -1;
            this.SaleID = SaleID;
            this.ProductID = ProductID;
            this.Amount = Amount;
            this.Price = Price;
        }

        public Order(long SaleID, Basket BasketToOrder, decimal Price)
        {
            this.OrderID = -1;
            this.SaleID = SaleID;
            this.ProductID = BasketToOrder.ProductID;
            this.Amount = BasketToOrder.Amount;
            this.Price = Price;
        }

        private long orderID;
        public long OrderID
        {
            get
            {
                return orderID;
            }
            set
            {
                orderID = value;
            }
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
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                saleID = value;
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
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
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

        private decimal price;
        public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                price = value;
            }
        }
    }
}
