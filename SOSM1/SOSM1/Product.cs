using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSM1
{
    public class Product
    {
        Product(string ProductName, decimal Price, int UnitType, decimal Discount, Bitmap Picture, int State, int CategoryID)
        {
            ProductID = -1;
            this.ProductName = ProductName;
            this.Price = Price;
            this.UnitType = UnitType;
            this.Discount = Discount;
            this.Picture = Picture;
            this.State = State;
            this.CategoryID = CategoryID;
        }

        private int productID;
        public int ProductID
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

        private string productName;
        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
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


        private int unitType;
        public int UnitType
        {
            get
            {
                return unitType;
            }
            set
            {
                unitType = value;
            }
        }

        private decimal discount;
        public decimal Discount
        {
            get
            {
                return discount;
            }
            set
            {
                discount = value;
            }
        }

        private string description;
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                description = value;
            }
        }

        private Bitmap picture;
        public Bitmap Picture
        {
            get
            {
                return picture;
            }
            set
            {
                picture = value;
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

        private int categoryID;
        public int CategoryID
        {
            get
            {
                return categoryID;
            }
            set
            {
                categoryID = value;
            }
        }
    }
}
