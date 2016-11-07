using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSM1
{
    public static class InterfaceToDataBaseBasketMethods
    {
        /// <summary>
        /// Creates basket owned by logged in user with specified product.
        /// Baskets should be kept in program memory and saved to 
        /// database only in case of user logout without empty basket.
        /// </summary>
        /// <param name="user">Logged in user object.</param>
        /// <param name="produkt">Product object added to basket.</param>
        /// <param name="amount">Amount of added product. Size 10, precision 2.</param>
        /// <returns>New Basket class object.</returns>
        public static Basket CreateBasket(User user, Product product, decimal amount)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Saves list of baskets, should be used to save users' buys in case
        /// hes logging out.
        /// </summary>
        /// <param name="basketsList">List of basket objects.</param>
        /// <returns>True if could save, false otherwise.</returns>
        public static bool SaveBaskets(List<Basket> basketsList)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// If user quited without empty basket, last session buys should
        /// be retrieved.
        /// </summary>
        /// <param name="user">User object whose baskets will be retrieved.</param>
        /// <returns>List of baskets. Null if user has no buys.</returns>
        public static List<Basket> RetrieveBaskets(User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes all baskets in database owned by specified user.
        /// </summary>
        /// <param name="user">User object whose baskets should be deleted.</param>
        /// <returns>True if succeded, false otherwise</returns>
        public static bool DeleteBaskets(User user)
        {
            throw new NotImplementedException();
        }
    }
}
