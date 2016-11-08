using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSM1
{
    public static class InterfaceToDataBaseBasketMethods
    {
        /// <summary>
        /// Saves list of baskets, should be used to save users' buys in case
        /// hes logging out.
        /// </summary>
        /// <param name="basketsList">List of basket objects.</param>
        /// <returns>True if could save, false otherwise.</returns>
        public static bool SaveBaskets(List<Basket> basketsList)
        {
            using (var context = new SOSMEntities())
            {
                foreach (Basket basket in basketsList)
                {
                    var basketEntity = new Baskets();
                    basketEntity.UserID = basket.UserID;
                    basketEntity.ProductID = basket.ProductID;
                    basketEntity.Amount = basket.Amount;
                    basketEntity.Date = basket.Date;

                    context.Baskets.Add(basketEntity);
                }
                context.SaveChanges();

                return true;
            }
        }

        /// <summary>
        /// If user quited without empty basket, last session buys should
        /// be retrieved.
        /// </summary>
        /// <param name="user">User object whose baskets will be retrieved.</param>
        /// <returns>List of baskets. Empty list if user has no buys.</returns>
        public static List<Basket> RetrieveBaskets(User user)
        {
            using (var context = new SOSMEntities())
            {
                var basketsToRetrieve = context.Baskets.Where(x => x.UserID == user.UserID);

                List<Basket> basketList = new List<Basket>();
                foreach (var basket in basketsToRetrieve)
                    basketList.Add(new Basket(
                        basket.UserID,
                        basket.ProductID,
                        basket.Amount,
                        basket.Date)
                    );

                return basketList;
            }
        }

        /// <summary>
        /// Deletes all baskets in database owned by specified user.
        /// </summary>
        /// <param name="user">User object whose baskets should be deleted.</param>
        /// <returns>True if succeded, false otherwise</returns>
        public static bool DeleteBaskets(User user)
        {
            using (var context = new SOSMEntities())
            {
                var basketsToDelete = context.Baskets.Where(x => x.UserID == user.UserID);
                foreach (var basket in basketsToDelete)
                    context.Baskets.Remove(basket);

                context.SaveChanges();

                return true;
            }
        }
    }
}
