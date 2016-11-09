using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace SOSM1
{
    public static class InterfaceToDataBaseProductMethods
    {
        /// <summary>
        /// Adds new product to database created from the Product data object
        /// </summary>
        /// <param name="newProduct">Product data object for creating new product.</param>
        /// <returns>True if it could add, false otherwise.</returns>
        public static bool AddProduct(ref Product newProduct)
        {
            using (var context = new SOSMEntities())
            {
                string name = newProduct.ProductName;
                var products = context.Products.Where(
                    x => x.Name == name
                    && (x.State == 0 || x.State == 1)
                ).ToList();
                if (products.Count != 0)
                    return false;
                Products dbProduct = new Products();
                dbProduct.Amount = newProduct.Amount;
                dbProduct.CategoryID = newProduct.CategoryID;
                dbProduct.Description = newProduct.Description;
                dbProduct.Discount = newProduct.Discount;
                dbProduct.Name = newProduct.ProductName;
                dbProduct.Picture = (byte[])new ImageConverter().ConvertTo(newProduct.Picture, typeof(byte[]));
                dbProduct.Price = newProduct.Price;
                dbProduct.State = newProduct.State;
                dbProduct.Unit_type = newProduct.UnitType;

                context.Products.Add(dbProduct);
                context.SaveChanges();
                newProduct.ProductID = dbProduct.ProductID;
                return true;
            }
        }

        /// <summary>
        /// Changes the state of a specified product in database.
        /// If product state is Active, sets him as Archival.
        /// If product state is Created, CRUSH IT! SMASH, TEAR, RIP.
        /// If product state is Archival, does nothing.
        /// </summary>
        /// <param name="productName">Product name of the product we want to modify.</param>
        /// <returns>True if success, false otherwise.</returns>
        public static bool DeleteProduct(string productName)
        {
            using (var context = new SOSMEntities())
            {
                var dbProduct = context.Products.FirstOrDefault(
                    x => x.Name == productName
                    && (x.State == 0 || x.State == 1)
                );
                if (dbProduct == null)
                    return false;
                switch (dbProduct.State)
                {
                    case 0: //created, can be annihilated, and so its swarms in baskets
                        {
                            context.Products.Remove(dbProduct);
                            var baskets = context.Baskets.Where(x => x.ProductID == dbProduct.ProductID).ToList();
                            foreach (var basket in baskets)
                                context.Baskets.Remove(basket);
                            context.SaveChanges();
                            return true;
                        }
                    case 1: //active, must be archived
                        {
                            dbProduct.State = 2;
                            context.Entry(dbProduct).Property(e => e.State).IsModified = true;
                            context.SaveChanges();
                            return true;
                        }
                }
                return false;
            }
        }

        /// <summary>
        /// Creates Product data object from the product with specified ID in the database.
        /// </summary>
        /// <param name="productID">ID of the product we want to get data from.</param>
        /// <returns>Product data object if product exists, null otherwise.</returns>
        public static Product GetProductData(long productID)
        {
            using (var context = new SOSMEntities())
            {
                var product = context.Products.Find(productID);
                if (product == null)
                    return null;
                Bitmap image;
                try
                {
                    MemoryStream stream = new MemoryStream(product.Picture);
                    image = new Bitmap(Image.FromStream(stream));
                    stream.Dispose();
                }
                // no image provided or is corrupted
                catch (Exception ex) when (ex is ArgumentException || ex is ArgumentNullException)
                {
                    image = null;
                }

                Product p = new Product(
                    product.Name,
                    product.Price,
                    product.Unit_type,
                    product.Discount,
                    product.Amount,
                    product.Description,
                    image,
                    product.State,
                    product.CategoryID
                );
                return p;
            }
        }

        /// <summary>
        /// Gets list of products who match terms specified by arguments.
        /// If the argument is null, it's not checked.
        /// </summary>
        /// <param name="searchArgument">Product contains searchArgument in name or description.</param>
        /// <param name="categoryID">Product is of specified category.</param>
        /// <param name="state">Product is of specified state.</param>
        /// <returns>List of Product data objects who match the terms.</returns>
        public static List<Product> CatalogProducts(string searchArgument = null, long? categoryID = null, long? state = null)
        {
            using (var context = new SOSMEntities())
            {
                var products = context.Products.Where(x => 1 == 1);
                if (searchArgument != null)
                    products = products.Where(x => x.Name.Contains(searchArgument));
                if (categoryID != null)
                    products = products.Where(x => x.CategoryID == categoryID);
                if (state != null)
                    products = products.Where(x => x.State == state);

                var dbProductsList = products.ToList();
                List<Product> productsList = new List<Product>();
                foreach (Products dbProduct in dbProductsList)
                {
                    Bitmap image;
                    try
                    {
                        MemoryStream stream = new MemoryStream(dbProduct.Picture);
                        image = new Bitmap(Image.FromStream(stream));
                        stream.Dispose();
                    }
                    // no image provided or is corrupted
                    catch (Exception ex) when (ex is ArgumentException || ex is ArgumentNullException)
                    {
                        image = null;
                    }
                    
                    Product product = new Product(
                        dbProduct.Name,
                        dbProduct.Price,
                        dbProduct.Unit_type,
                        dbProduct.Discount,
                        dbProduct.Amount,
                        dbProduct.Description,
                        image,
                        dbProduct.State,
                        dbProduct.CategoryID
                    );
                    product.ProductID = dbProduct.ProductID;
                    productsList.Add(product);
                }
                return productsList;
            }
        }

        /// <summary>
        /// Attempts to modify data of product with specified product ID.
        /// If argument is null it's not modified.
        /// </summary>
        /// <param name="productID">Specifies a product.</param>
        /// <param name="productName">New product name.</param>
        /// <param name="price">New prise.</param>
        /// <param name="unitType">New unit type.</param>
        /// <param name="discount">New discount.</param>
        /// <param name="amount">New amount.</param>
        /// <param name="description">New description.</param>
        /// <param name="picture">New picture.</param>
        /// <param name="categoryID">New categoryID.</param>
        /// <returns>Returns true, if operation could be completed, false otherwise.</returns>
        public static bool ProductModification(long productID, string productName = null, decimal? price = null, long? unitType = null, decimal? discount = null, decimal? amount = null, string description = null, Bitmap picture = null, long? categoryID = null)
        {
            using (var context = new SOSMEntities())
            {
                Products product = context.Products.Find(productID);
                if (product == null)
                    return false;
                if (productName != null)
                {
                    product.Name = productName;
                    context.Entry(product).Property(e => e.Name).IsModified = true;
                }
                if (price != null)
                {
                    product.Price = (decimal)price;
                    context.Entry(product).Property(e => e.Price).IsModified = true;
                }
                if (unitType != null)
                {
                    product.Unit_type = (long)unitType;
                    context.Entry(product).Property(e => e.Unit_type).IsModified = true;
                }
                if (discount != null)
                {
                    product.Discount = discount;
                    context.Entry(product).Property(e => e.Discount).IsModified = true;
                }
                if (amount != null)
                {
                    product.Amount = (decimal)amount;
                    context.Entry(product).Property(e => e.Amount).IsModified = true;
                }
                if (description != null)
                {
                    product.Description = description;
                    context.Entry(product).Property(e => e.Description).IsModified = true;
                }
                if (picture != null)
                {
                    product.Picture = (byte[])new ImageConverter().ConvertTo(picture, typeof(byte[]));
                    context.Entry(product).Property(e => e.Picture).IsModified = true;
                }
                if (categoryID != null)
                {
                    product.CategoryID = (long)categoryID;
                    context.Entry(product).Property(e => e.CategoryID).IsModified = true;
                }
                context.SaveChanges();
                return true;
            }
        }

        /// <summary>
        /// Changes the state of product with productID from Created to Active.
        /// </summary>
        /// <param name="productID">Specifies a product.</param>
        /// <returns>Returns true, if operation could be completed, false otherwise.</returns>
        public static bool Activate(long productID)
        {
            using (var context = new SOSMEntities())
            {
                Products product = context.Products.FirstOrDefault(
                    x => x.ProductID == productID
                    && x.State == 0
                );
                if (product == null)
                    return false;

                product.State = 1;
                context.Entry(product).Property(e => e.State).IsModified = true;
                return true;
            }
        }

        /// <summary>
        /// Finds the product ON A SALE, MORTAL! And returns it's Product data object.
        /// If there are multiple discounted products, returns one of them.
        /// And adds BONUS DUCKS!
        /// </summary>
        /// <param name="ProductData">Data object of the product with biggest sale.</param>
        /// <returns>True if there was at least one product with sale, false otherwise.</returns>
        public static bool GetRandomtSale(out Product ProductData)
        {
            using (var context = new SOSMEntities())
            {
                var sales = context.Products.Where(x => x.Price > x.Discount).ToList();
                if (sales.Count == 0)
                {
                    ProductData = null;
                    return false;
                }
                Random rand = new Random();
                int rand_index = rand.Next(0, sales.Count);
                Products dbProduct = sales[rand_index];

                Bitmap image;
                try
                {
                    MemoryStream stream = new MemoryStream(dbProduct.Picture);
                    image = new Bitmap(Image.FromStream(stream));
                    stream.Dispose();
                }
                // no image provided or is corrupted
                catch (Exception ex) when (ex is ArgumentException || ex is ArgumentNullException)
                {
                    image = null;
                }
                
                Product product = new Product(
                    dbProduct.Name,
                    dbProduct.Price,
                    dbProduct.Unit_type,
                    dbProduct.Discount,
                    dbProduct.Amount,
                    dbProduct.Description,
                    image,
                    dbProduct.State,
                    dbProduct.CategoryID
                );
                product.ProductID = dbProduct.ProductID;
                ProductData = product;
            }
            return true;
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
