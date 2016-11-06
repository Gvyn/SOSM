using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SOSM1
{
    static class InterfaceToDataBaseProductMethods
    {

        /// <summary>
        /// Creates Product data object from the product with specified name in the database.
        /// </summary>
        /// <param name="ProductName">Name of the product we want to get data from.</param>
        /// <returns>Product data object if product exists, null otherwise.</returns>
        public static Product GetProductData(string ProductName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Checks if product with product name equal to ProductName exists in database and is Active or Created.
        /// </summary>
        /// <param name="ProductName">String with product name that we want to check.</param>
        /// <returns>True if exists, false otherwise.</returns>
        public static bool ProductExists(string ProductName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds new product to database created from the Product data object
        /// </summary>
        /// <param name="NewProduct">Product data object for creating new product.</param>
        /// <returns>True if it could add, false otherwise.</returns>
        public static bool AddProduct(Product NewProduct)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Changes the state of a specified product in database.
        /// If product state is Active, sets him as Archival.
        /// If product state is Created, sets him as Active.
        /// If product state is Archival, does nothing.
        /// </summary>
        /// <param name="ProductName">Product name of the product we want to modify.</param>
        /// <returns>True if success, false otherwise.</returns>
        public static bool DeleteProduct(string ProductName)
        {
            throw new NotImplementedException();
        }

    }
}
