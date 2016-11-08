using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSM1
{
    public static class InterfaceToDataBaseSaleMethods
    {
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
        public static bool CreateSale(List<Baskets> basketsList)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns list of users' purchases.
        /// </summary>
        /// <param name="user">User object.</param>
        /// <returns>List of Sale object. Null if user has no purchases.</returns>
        public static List<Sale> GetSalesHistory(User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns list of orders which the sale consist of.
        /// </summary>
        /// <param name="sale">Sale object.</param>
        /// <returns>List of Order objects.</returns>
        public static List<Order> GetSaleOrders(Sale sale)
        {
            throw new NotImplementedException();
        }
    }
}
