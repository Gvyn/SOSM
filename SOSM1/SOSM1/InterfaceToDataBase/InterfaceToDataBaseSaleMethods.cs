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
            await context.SaveChangesAsync();
            var itdbbm = new InterfaceToDataBaseBasketMethods();
            await itdbbm.DeleteBaskets(userID);

            return true;
    }

        /// <summary>
        /// Returns list of users' purchases.
        /// </summary>
        /// <param name="user">UserID. Like 666 or 420.</param>
        /// <returns>List of Sale object. Null if user has no purchases.</returns>
        public async Task<List<Sale>> GetSalesHistory(long userID)
        {
            var dbSales = await context.Sale_history.Where(x => x.UserID == userID).ToListAsync();

            List<Sale> sales = new List<Sale>();
            foreach (var dbSale in dbSales)
            {
                Sale sale = new Sale(userID);
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
    }
}
