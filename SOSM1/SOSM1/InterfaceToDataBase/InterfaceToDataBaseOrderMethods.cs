using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSM1
{
    public class InterfaceToDataBaseOrderMethods
    {
        SOSMEntities context;

        public InterfaceToDataBaseOrderMethods()
        {
            context = new SOSMEntities();
        }

        /// <summary>
        /// Returns all orders included in a single transaction/sale.
        /// </summary>
        /// <param name="SaleID">SaleID, huh.</param>
        /// <returns>List of Order objects.</returns>
        public async Task<List<Order>> GetOrdersFromSale(long SaleID)
        {
            var dbOrders = await context.Orders.Where(x => x.SaleID == SaleID).ToListAsync();

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
        /// Get Order from database by its ID
        /// </summary>
        /// <param name="OrderID">Ze ID.</param>
        /// <returns>Order object or null.</returns>
        public async Task<Order> GetOrder(long OrderID)
        {
            var dbOrder = await context.Orders.FindAsync(OrderID);
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
