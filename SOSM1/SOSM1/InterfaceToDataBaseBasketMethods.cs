﻿using System;
using System.Collections.Generic;
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
                using (var dbContextTransaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        foreach (Basket basket in basketsList)
                        {
                            var basketEntity = new Baskets();
                            basketEntity.UserID = basket.BasketOwner.UserID;
                            basketEntity.ProductID = basket.ProductInBasket.ProductID;
                            basketEntity.Amount = basket.Amount;
                            basketEntity.Date = basket.Date;

                            context.Baskets.Add(basketEntity);
                        }
                        context.SaveChanges();

                        dbContextTransaction.Commit();
                        return true;
                    }
                    catch (Exception)
                    {
                        dbContextTransaction.Rollback();
                        return false;
                    }
                }
            }
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
