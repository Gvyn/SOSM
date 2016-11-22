using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSM1
{

    public class InterfaceToDataBaseBasketMethods
    {
        SOSMEntities context;

        public InterfaceToDataBaseBasketMethods()
        {
            context = new SOSMEntities();
        }

        /// <summary>
        /// Saves list of baskets, should be used to save users' buys in case
        /// hes logging out.
        /// </summary>
        /// <param name="basketsList">List of basket objects.</param>
        /// <returns>True if could save, false otherwise.</returns>
        public async Task<bool> SaveBaskets(List<Basket> basketsList)
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
            await context.SaveChangesAsync();

            return true;
        }

        /// <summary>
        /// If user quited without empty basket, last session buys should
        /// be retrieved.
        /// </summary>
        /// <param name="user">Specifies user object whose baskets will be retrieved.</param>
        /// <returns>List of baskets. Empty list if user has no buys.</returns>
        public async Task<List<Basket>> RetrieveBaskets(long UserID)
        {
            var basketsToRetrieve = await context.Baskets.Where(x => x.UserID == UserID).ToListAsync();

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

        /// <summary>
        /// Deletes all baskets in database owned by specified user.
        /// </summary>
        /// <param name="user">Specifies user object whose baskets should be deleted.</param>
        /// <returns>True if succeded, false otherwise</returns>
        public async Task<bool> DeleteBaskets(long UserID)
        {
            var basketsToDelete = await context.Baskets.Where(x => x.UserID == UserID).ToListAsync();
            foreach (var basket in basketsToDelete)
                context.Baskets.Remove(basket);

            await context.SaveChangesAsync();

            return true;
        }
    }
}
