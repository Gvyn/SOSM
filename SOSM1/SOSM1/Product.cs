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
        Product(string ProductName, decimal Price, int UnitType, decimal Discount,decimal Amount, Bitmap Picture, int State, int CategoryID)
        {
            ProductID = -1;
            this.ProductName = ProductName;
            this.Price = Price;
            this.UnitType = UnitType;
            this.Discount = Discount;
            this.Amount = Amount;
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
                if (value == null)
                    throw new ArgumentNullException();
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
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                price = value;
            }
        }

        /// <summary>
        /// 0 - pieces
        /// 1 - kg
        /// 2 - litres
        /// </summary>
        private int unitType;
        /// <summary>
        /// 0 - pieces
        /// 1 - kg
        /// 2 - litres
        /// </summary>
        public int UnitType
        {
            get
            {
                return unitType;
            }
            set
            {
                if (value < 0 || value > 2)
                    throw new ArgumentOutOfRangeException();
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
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                discount = value;
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
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                if (UnitType == 0 && value%1 != 0)
                    throw new ArgumentOutOfRangeException();
                amount = value;
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
                if (value == null)
                    throw new ArgumentNullException();
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

        /// <summary>
        /// 0 - Created
        /// 1 - Active
        /// 2 - Archival
        /// </summary>
        private int state;
        /// <summary>
        /// 0 - Created
        /// 1 - Active
        /// 2 - Archival
        /// </summary>
        public int State
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

        private int categoryID;
        public int CategoryID
        {
            get
            {
                return categoryID;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException();
                categoryID = value;
            }
        }
    }
}
