using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSM1
{
    public static class InterfaceToDataBaseOrderMethods
    {
        /// <summary>
        /// Returns all orders included in a single transaction/sale.
        /// </summary>
        /// <param name="SaleID">SaleID, huh.</param>
        /// <returns>List of Order objects.</returns>
        public static List<Order> GetOrdersFromSale(long SaleID)
        {
            using (var context = new SOSMEntities())
            {
                var dbOrders = context.Orders.Where(x => x.SaleID == SaleID).ToList();

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

        /// <summary>
        /// Get Order from database by its ID
        /// </summary>
        /// <param name="OrderID">Ze ID.</param>
        /// <returns>Order object or null.</returns>
        public static Order GetOrder(long OrderID)
        {
            using (var context = new SOSMEntities())
            {
                var dbOrder = context.Orders.Find(OrderID);
                if (dbOrder == null)
                    return null;
                Order order = new Order(
                    dbOrder.SaleID,
                    dbOrder.ProductID,
                    dbOrder.Amount,
                    dbOrder.Price
                );
                order.OrderID = dbOrder.OrderID;

                return order;
            }
        }
    }
}
