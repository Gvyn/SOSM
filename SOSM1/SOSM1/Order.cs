using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSM1
{
    public class Order
    {
        public Order(int SaleID, Product OrderedProduct, decimal Amount, decimal Price)
        {
            this.OrderID = -1;
            this.SaleID = SaleID;
            this.OrderedProduct = OrderedProduct;
            this.Amount = Amount;
            this.Price = Price;
        }

        public Order(int SaleID, Basket BasketToOrder, decimal ActualPrice = -1)
        {
            this.OrderID = -1;
            this.SaleID = SaleID;
            this.OrderedProduct = BasketToOrder.ProductInBasket;
            this.Amount = BasketToOrder.Amount;
            if (ActualPrice == -1)
                ActualPrice = BasketToOrder.ProductInBasket.Price;
            this.Price = ActualPrice;
        }

        private int orderID;
        public int OrderID
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

        private int saleID;
        public int SaleID
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

        private Product orderedProduct;
        public Product OrderedProduct
        {
            get
            {
                return orderedProduct;
            }
            set
            {
                if (value.ProductID < 0)
                    throw new ArgumentException();
                orderedProduct = value;
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
                if (orderedProduct.UnitType == 0 && value % 1 != 0)
                    throw new ArgumentOutOfRangeException();
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
