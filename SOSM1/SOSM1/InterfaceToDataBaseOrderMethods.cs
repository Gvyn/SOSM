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
        /// Creates list of Orders from Baskets. Should be used by function finalizing
        /// users' transaction.
        /// </summary>
        /// <param name="basketList">List of Basket object.</param>
        /// <param name="sale">Sale which the orders are elements of. 
        /// Should be already saved in database, because it is a foreign key.</param>
        /// <returns>List of Order objects.</returns>
        public static List<Order> BasketListToOrderList(List<Basket> basketList, Sale sale)
        {
            throw new NotImplementedException();
        }
    }
}
