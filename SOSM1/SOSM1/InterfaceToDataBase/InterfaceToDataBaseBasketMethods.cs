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

        ///// <summary>
        ///// Saves a basket
        ///// </summary>
        ///// <param name="basket">Basket object.</param>
        ///// <returns>True if could save, false otherwise.</returns>
        //public async Task<Basket> AddBasket(Basket basket)
        //{
        //    var basketEntity = new Baskets();
        //    basketEntity.UserID = basket.UserID;
        //    basketEntity.ProductID = basket.ProductID;
        //    basketEntity.Amount = basket.Amount;
        //    basketEntity.Date = basket.Date;

        //    context.Baskets.Add(basketEntity);
        //    await context.SaveChangesAsync();
        //    basket.BasketID = basketEntity.BasketID;

        //    return basket;
        //}

        /// <summary>
        /// Moves the specified amount of specified product to the basket of specified user.
        /// </summary>
        /// <param name="UserID">Specifies user</param>
        /// <param name="ProductID">Specifies product</param>
        /// <param name="Amount">Specifies amount</param>
        /// <returns>True if could complete operation, false otherwise.</returns>
        public async Task<bool> MoveProductToBasket(long UserID, long ProductID, decimal Amount)
        {
            if (Amount <= 0)
                return false;
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
                basket.Date = DateTime.Now;
            }
            product.Amount -= Amount;
            // ok, problem jest taki, że zmieniamy basket i product, tylko, że zmieniamy lokalną zmienną chyba, a nie w samej kolekcji i to trzeba sfiksować
            await context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Moves the specified amount of specified user's basket back to the storage.
        /// </summary>
        /// <param name="UserID">Specifies user</param>
        /// <param name="ProductID">Specifies product</param>
        /// <param name="Amount">Specifies amount</param>
        /// <returns>True if could complete operation, false otherwise.</returns>
        public async Task<bool> MoveProductFromBasket(long UserID, long ProductID, decimal Amount)
        {
            if (Amount <= 0)
                return false;
            var basket = await context.Baskets.FirstOrDefaultAsync(x => x.UserID == UserID && x.ProductID == ProductID);
            if (basket == null)
            {
                return false;
            }

            var product = await context.Products.FindAsync(ProductID);
            if (product == null)
                return false;

            if (Amount > basket.Amount)
                return false;

            if (basket.Amount == Amount)
            {
                context.Baskets.Remove(basket);
            }
            else
            {
                basket.Amount -= Amount;
                basket.Date = DateTime.Now;
            }
            product.Amount += Amount;
            await context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Checks the amount of specified product in user's basket.
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="ProductID"></param>
        /// <returns>The amount of specified product in user's basket.</returns>
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

        ///// <summary>
        ///// Modifies the amount of items in user's basket.
        ///// </summary>
        ///// <param name="BasketID">Specifies basket</param>
        ///// <param name="amount">Specifies amount</param>
        ///// <returns>True if could complete operation, false otherwise.</returns>
        //public async Task<bool> ModifyBasket(long BasketID, decimal amount)
        //{
        //    var basketEntity = await context.Baskets.FindAsync(BasketID);
        //    if (basketEntity == null)
        //        return false;
        //    basketEntity.Amount = amount;
        //    basketEntity.Date = DateTime.Now;
        //    context.Entry(basketEntity).Property(x => x.Amount).IsModified = true;
        //    await context.SaveChangesAsync();
        //    return true;
        //}

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
        /// Retrieves user's baskets
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
        /// Counts user's baskets.
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns>The number of products(types) in user's basket.</returns>
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
