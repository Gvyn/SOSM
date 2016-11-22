using System;
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
        public static bool CreateSale(List<Basket> basketsList)
        {
            if (basketsList.Count == 0)
                return false;
            long userID = basketsList[0].UserID;

            foreach (Basket basket in basketsList) //one user to rule all the baskets
                if (basket.UserID != userID)
                    return false;

            using (var context = new SOSMEntities())
            {
                Sale_history transaction = new Sale_history();
                transaction.UserID = userID;
                transaction.Date = System.DateTime.Now;
                context.Sale_history.Add(transaction);
                context.SaveChanges();
                long saleID = transaction.SaleID;

                foreach (Basket basket in basketsList)
                {
                    Orders dbOrder = new Orders();
                    dbOrder.SaleID = saleID;
                    dbOrder.ProductID = basket.ProductID;
                    dbOrder.Price = context.Products.Find(basket.ProductID).Price;
                    dbOrder.Amount = basket.Amount;

                    context.Orders.Add(dbOrder);
                }
                context.SaveChanges();
                InterfaceToDataBaseBasketMethods.DeleteBaskets(userID);

                return true;
            }
        }

        /// <summary>
        /// Returns list of users' purchases.
        /// </summary>
        /// <param name="user">UserID. Like 666 or 420.</param>
        /// <returns>List of Sale object. Null if user has no purchases.</returns>
        public static List<Sale> GetSalesHistory(long userID)
        {
            using (var context = new SOSMEntities())
            {
                var dbSales = context.Sale_history.Where(x => x.UserID == userID).ToList();

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
        }

        /// <summary>
        /// Returns list of orders which the sale consist of.
        /// </summary>
        /// <param name="sale">SaleID.</param>
        /// <returns>List of Order objects.  Null if there is no such sale or it has
        /// no orders(???)</returns>
        public static List<Order> GetSaleOrders(long saleID)
        {
            using (var context = new SOSMEntities())
            {
                var dbOrders = context.Orders.Where(x => x.SaleID == saleID).ToList();
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
}
