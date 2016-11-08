using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSM1
{
    class InterfaceToDataBaseCategoryMethods
    {
        /// <summary>
        /// Crates a brand new, ready for action Category. 
        /// </summary>
        /// <param name="Name">Name of Category, like 'Vegetables' or 'Elder scrolls'</param>
        /// <param name="Description">Description of category.</param>
        /// <returns>Category object.</returns>
        public static Category CreateCategory(string Name, string Description)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes unwanted, surely made by mistake, Category.
        /// </summary>
        /// <param name="Name">Name of Category.</param>
        /// <returns>True if operation succeded, false otherwise.</returns>
        public static bool DeleteCategory(string Name)
        {
            throw new NotImplementedException();
        }
    }
}
