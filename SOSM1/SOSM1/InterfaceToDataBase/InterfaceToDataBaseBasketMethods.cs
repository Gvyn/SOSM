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
        /// Saves a basket
        /// </summary>
        /// <param name="basket">Basket object.</param>
        /// <returns>True if could save, false otherwise.</returns>
        public async Task<Basket> AddBasket(Basket basket)
        {
            var basketEntity = new Baskets();
            basketEntity.UserID = basket.UserID;
            basketEntity.ProductID = basket.ProductID;
            basketEntity.Amount = basket.Amount;
            basketEntity.Date = basket.Date;

            context.Baskets.Add(basketEntity);
            await context.SaveChangesAsync();
            basket.BasketID = basketEntity.BasketID;

            return basket;
        }


        public async Task<bool> MoveProductToBasket(long UserID, long ProductID, decimal Amount)
        {
            var product = await context.Products.FindAsync(ProductID);
            if (product == null)
                return false;
            if (Amount > product.Amount)
                return false;
            var basket = await context.Baskets.FirstOrDefaultAsync(x => x.UserID == UserID && x.ProductID == ProductID);
            if (basket == null)
            {
                basket = new Baskets();
                basket.Amount = Amount;
                basket.Date = DateTime.Now;
                basket.ProductID = ProductID;
                basket.UserID = UserID;
                context.Baskets.Add(basket);
            }
            else
            {
                basket.Amount += Amount;
                product.Amount -= Amount;
            }
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<decimal> AmountOfProductInUserBaskets(long UserID, long ProductID)
        {
            var baskets = await context.Baskets.Where(x => x.UserID == UserID && x.ProductID == ProductID).ToListAsync();
            if (baskets.Count == 0)
                return 0;
            decimal number = 0;
            foreach (var basket in baskets)
                number += basket.Amount;

            return number;
        }


        public async Task<bool> ModifyBasket(long BasketID, decimal amount)
        {
            var basketEntity = await context.Baskets.FindAsync(BasketID);
            if (basketEntity == null)
                return false;
            basketEntity.Amount = amount;
            basketEntity.Date = DateTime.Now;
            context.Entry(basketEntity).Property(x => x.Amount).IsModified = true;
            await context.SaveChangesAsync();
            return true;
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

        public async Task<int> CountBaskets(long UserID)
        {
            var count = await context.Baskets.Where(x => x.UserID == UserID).CountAsync();
            return count;
        }


        /// <summary>
        /// Deletes basket in database by it's id.
        /// </summary>
        /// <param name="BasketID">Specifies user object whose baskets should be deleted.</param>
        /// <returns>True if succeded, false otherwise</returns>
        public async Task<bool> DeleteBasket(long BasketID)
        {
            var basketToDelete = await context.Baskets.FindAsync(BasketID);
            if (basketToDelete == null)
                return false;
            context.Baskets.Remove(basketToDelete);

            await context.SaveChangesAsync();

            return true;
        }

        /// <summary>
        /// Deletes all baskets in database owned by specified user.
        /// </summary>
        /// <param name="UserID">Specifies user object whose baskets should be deleted.</param>
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
