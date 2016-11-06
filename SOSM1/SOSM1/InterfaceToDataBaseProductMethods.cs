using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SOSM1
{
    static class InterfaceToDataBaseProductMethods
    {
        /// <summary>
        /// Adds new product to database created from the Product data object
        /// </summary>
        /// <param name="newProduct">Product data object for creating new product.</param>
        /// <returns>True if it could add, false otherwise.</returns>
        public static bool AddProduct(Product newProduct)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Changes the state of a specified product in database.
        /// If product state is Active, sets him as Archival.
        /// If product state is Created, sets him as Active.
        /// If product state is Archival, does nothing.
        /// </summary>
        /// <param name="productName">Product name of the product we want to modify.</param>
        /// <returns>True if success, false otherwise.</returns>
        public static bool DeleteProduct(string productName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates Product data object from the product with specified ID in the database.
        /// </summary>
        /// <param name="productID">ID of the product we want to get data from.</param>
        /// <returns>Product data object if product exists, null otherwise.</returns>
        public static Product GetProductData(int productID)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets list of products who match terms specified by arguments.
        /// If the argument is null, it's not checked.
        /// </summary>
        /// <param name="searchArgument">Product contains searchArgument in name or description.</param>
        /// <param name="categoryID">Product is of specified category.</param>
        /// <param name="state">Product is of specified state.</param>
        /// <returns>List of Product data objects who match the terms.</returns>
        public static List<Product> CatalogProducts(string searchArgument = null, int? categoryID = null, int? state = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Attempts to modify data of product with specified product ID.
        /// If argument is null it's not modified.
        /// </summary>
        /// <param name="productID">Specifies a product.</param>
        /// <param name="productName">New product name.</param>
        /// <param name="prise">New prise.</param>
        /// <param name="priceType">New price type.</param>
        /// <param name="discount">New discount.</param>
        /// <param name="amount">New amount.</param>
        /// <param name="description">New description.</param>
        /// <param name="picture">New picture.</param>
        /// <param name="categoryID">New categoryID.</param>
        /// <returns>Returns true, if operation could be completed, false otherwise.</returns>
        public static bool ProductModification(int productID, string productName = null, decimal? prise = null, int? priceType = null, decimal? discount = null, decimal? amount = null, string description = null, Bitmap picture = null, int? categoryID = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Attempts to modify data of product with specified product ID.
        /// </summary>
        /// <param name="productID">Specifies a product.</param>
        /// <param name="ProductData">Contains data of modified product.</param>
        /// <returns>Returns true, if operation could be completed, false otherwise.</returns>
        public static bool ProductModificationFromProductData(int productID, Product ProductData)
        {
            throw new NotImplementedException();
        }


        ///// <summary>
        ///// Creates Product data object from the product with specified name in the database.
        ///// </summary>
        ///// <param name="productName">Name of the product we want to get data from.</param>
        ///// <returns>Product data object if product exists, null otherwise.</returns>
        //public static Product GetProductData(string productName)
        //{
        //    throw new NotImplementedException();
        //}

        ///// <summary>
        ///// Checks if product with product name equal to ProductName exists in database and is Active or Created.
        ///// </summary>
        ///// <param name="productName">String with product name that we want to check.</param>
        ///// <returns>True if exists, false otherwise.</returns>
        //public static bool ProductExists(string productName)
        //{
        //    throw new NotImplementedException();
        //}


        ///// <summary>
        ///// Gets list of products with specified (or not) category.
        ///// </summary>
        ///// <param name="categoryName">Specified category. If null all categories.</param>
        ///// <returns>List of products</returns>
        //public static List<Product> GetProductsList(string categoryName = null)
        //{
        //    throw new NotImplementedException();
        //}

        ///// <summary>
        ///// Gets list of products which include searchArgument in their name or description, and of specified category if needed.
        ///// </summary>
        ///// <param name="searchArgument">Our search argument.</param>
        ///// <param name="categoryName">Specified category. If null all categories.</param>
        ///// <returns>List of products.</returns>
        //public static List<Product> SearchProduct(string searchArgument, string categoryName = null)
        //{
        //    throw new NotImplementedException();
        //}

    }
}
