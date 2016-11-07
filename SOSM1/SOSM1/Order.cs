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
                price = value;
            }
        }
    }
}
