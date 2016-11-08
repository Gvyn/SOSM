using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSM1
{
    public class Product
    {
        public Product(string ProductName, decimal Price, long UnitType, decimal? Discount,decimal Amount, Bitmap Picture, long State, long? CategoryID)
        {
            if (Discount == null || CategoryID == null)
                throw new NoNullAllowedException();
            ProductID = -1;
            this.ProductName = ProductName;
            this.Price = Price;
            this.UnitType = UnitType;
            this.Discount = (decimal)Discount;
            this.Amount = Amount;
            this.Picture = Picture;
            this.State = State;
            this.CategoryID = (long)CategoryID;
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
        private long unitType;
        /// <summary>
        /// 0 - pieces
        /// 1 - kg
        /// 2 - litres
        /// </summary>
        public long UnitType
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

        private long categoryID;
        public long CategoryID
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
