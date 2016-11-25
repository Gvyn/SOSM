using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSM1
{
    public class InterfaceToDataBaseSaleMethods
    {
        SOSMEntities context;

        public InterfaceToDataBaseSaleMethods()
        {
            context = new SOSMEntities();
        }

        /// <summary>
        /// Finilaize users' transaction, saves new Sale_history object in
        /// database and Orders objects accordingly to baskets from argument.
        /// First it should save new Sale in database, then orders
        /// with proper foreign keys.
        /// Needed user info is in basketsList and should be consistent
        /// through the list. This method should also delete any user baskets
        /// in database.
        /// </summary>
        /// <param name="baskets">List of basket object</param>
        /// <returns>True if purchase succeded, false otherwise.</returns>
        public async Task<bool> CreateSale(long UserID)
        {
            var basketsList = await context.Baskets.Where(x => x.UserID == UserID).ToListAsync();

            if (basketsList.Count == 0)
                return false;
            long userID = basketsList[0].UserID;

            Sale_history transaction = new Sale_history();
            transaction.UserID = userID;
            transaction.Date = System.DateTime.Now;
            context.Sale_history.Add(transaction);
            await context.SaveChangesAsync();
            long saleID = transaction.SaleID;

            foreach (Baskets basket in basketsList)
            {
                Orders dbOrder = new Orders();
                dbOrder.SaleID = saleID;
                dbOrder.ProductID = basket.ProductID;
                dbOrder.Price = (await context.Products.FindAsync(basket.ProductID)).Price;
                dbOrder.Amount = basket.Amount;

                context.Orders.Add(dbOrder);
            }

            var baskets = await context.Baskets.Where(x => x.UserID == UserID).ToListAsync();
            foreach (var basket in baskets)
                context.Baskets.Remove(basket);
            await context.SaveChangesAsync();
            return true;
    }

        /// <summary>
        /// Returns list of sales.
        /// </summary>
        /// <returns>List of Sale object. Null if user has no purchases.</returns>
        public async Task<List<Sale>> GetProductSalesHistory()
        {
            var dbSales = await context.Sale_history.ToListAsync();

            List<Sale> sales = new List<Sale>();
            foreach (var dbSale in dbSales)
            {
                Sale sale = new Sale(dbSale.UserID);
                sale.SaleID = dbSale.SaleID;
                sale.Date = dbSale.Date;
                sales.Add(sale);
            }

            return sales;
        }
        /// <summary>
        /// Returns list of users' purchases.
        /// </summary>
        /// <param name="user">UserID.</param>
        /// <returns>List of Sale object. Null if user has no purchases.</returns>
        public async Task<List<Sale>> GetUserSalesHistory(long userID)
        {
            var dbSales = await context.Sale_history.Where(x => x.UserID == userID).ToListAsync();

            List<Sale> sales = new List<Sale>();
            foreach (var dbSale in dbSales)
            {
                Sale sale = new Sale(dbSale.UserID);
                sale.SaleID = dbSale.SaleID;
                sale.Date = dbSale.Date;
                sales.Add(sale);
            }

            return sales;
        }


        /// <summary>
        /// Returns list of sales specified product.
        /// </summary>
        /// <param name="user">ProductID.</param>
        /// <returns>List of Sale object. Null if user has no purchases.</returns>
        public async Task<List<Sale>> GetProductSalesHistory(long productID)
        {

            List<long> salesWithProduct = new List<long>();
            var ordersWithProduct = await (context.Orders.Where(x => x.ProductID == productID).ToListAsync());
            foreach(var order in ordersWithProduct)
            {
                salesWithProduct.Add(order.SaleID);
            }

            List<Sale_history> dbSales = new List<Sale_history>();
            foreach(long saleId in salesWithProduct)
            {
                dbSales.Concat(await context.Sale_history.Where(x => x.SaleID == saleId).ToListAsync());
            }

            List<Sale> sales = new List<Sale>();
            foreach (var dbSale in dbSales)
            {
                Sale sale = new Sale(dbSale.UserID);
                sale.SaleID = dbSale.SaleID;
                sale.Date = dbSale.Date;
                sales.Add(sale);
            }

            return sales;
        }
        /// <summary>
        /// Returns list of sales specified product.
        /// </summary>
        /// <param name="user">Date of sale.</param>
        /// <returns>List of Sale object. Null if user has no purchases.</returns>
        public async Task<List<Sale>> GetDateSalesHistory(DateTime Date, int comparePositions = 3)
        {
            if (comparePositions < 1 || comparePositions > 5)
                throw new ArgumentOutOfRangeException();
            var dbSales = await context.Sale_history.Where(x => (comparePositions<1 || x.Date.Year == Date.Year)
                            && (comparePositions < 2 || x.Date.Month == Date.Month)
                            && (comparePositions < 3 || x.Date.Day == Date.Day)
                            && (comparePositions < 4 || x.Date.Hour == Date.Hour)
                            && (comparePositions < 5 || x.Date.Minute == Date.Minute)).ToListAsync();

            List<Sale> sales = new List<Sale>();
            foreach (var dbSale in dbSales)
            {
                Sale sale = new Sale(dbSale.UserID);
                sale.SaleID = dbSale.SaleID;
                sale.Date = dbSale.Date;
                sales.Add(sale);
            }

            return sales;
        }


        /// <summary>
        /// Returns list of orders which the sale consist of.
        /// </summary>
        /// <param name="sale">SaleID.</param>
        /// <returns>List of Order objects.  Null if there is no such sale or it has
        /// no orders(???)</returns>
        public async Task<List<Order>> GetSaleOrders(long saleID)
        {
            var dbOrders = await context.Orders.Where(x => x.SaleID == saleID).ToListAsync();
            if (dbOrders.Count == 0)
                return null;

            List<Order> orders = new List<Order>();
            foreach (var dbOrder in dbOrders)
            {
                Order order = new Order(
                    dbOrder.SaleID,
                    dbOrder.ProductID,
                    dbOrder.Amount,
                    dbOrder.Price
                );
                order.OrderID = dbOrder.OrderID;
                orders.Add(order);
            }
            return orders;
        }

        /// <summary>
        /// Calculates the summed price of every item in sale.
        /// </summary>
        /// <param name="saleID">SaleID.</param>
        /// <returns>Sale value.</returns>
        public async Task<Decimal> GetSaleValue(long saleID)
        {
            var dbOrders = await context.Orders.Where(x => x.SaleID == saleID).ToListAsync();
            if (dbOrders.Count == 0)
                return 0;
            decimal sum = 0;
            foreach (var dbOrder in dbOrders)
            {
                sum += dbOrder.Price * dbOrder.Amount;
            }
            return sum;

        }
    }
}
