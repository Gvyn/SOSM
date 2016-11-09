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
        public static bool AddCategory(ref Category newCategory)
        {
            using (var context = new SOSMEntities())
            {
                string name = newCategory.Name;
                if (context.Categories.FirstOrDefault(x => x.Name == name) != null)
                    return false;
                Categories dbCategory = new Categories();
                dbCategory.Name = newCategory.Name;
                dbCategory.Description = newCategory.Description;

                context.Categories.Add(dbCategory);
                context.SaveChanges();

                newCategory.CategoryID = dbCategory.CategoryID;
                return true;
            }
        }

        /// <summary>
        /// Get category data by ID.
        /// </summary>
        /// <param name="CategoryID">ID of wanted category.</param>
        /// <returns>Category object or null.</returns>
        public static Category GetCategory(long CategoryID)
        {
            using (var context = new SOSMEntities())
            {
                var dbCategory = context.Categories.Find(CategoryID);
                if (dbCategory == null)
                    return null;

                Category category = new Category(
                    dbCategory.Name,
                    dbCategory.Description
                );
                category.CategoryID = dbCategory.CategoryID;
                return category;
            }
        }

        /// <summary>
        /// Returns all categories in database.
        /// </summary>
        /// <returns>List of Category objects.</returns>
        public static List<Category> GetAllCategories()
        {
            using (var context = new SOSMEntities())
            {
                var dbCategories = context.Categories.ToList();
                List<Category> categories = new List<Category>();
                foreach (var dbCategory in dbCategories)
                {
                    Category category = new Category(
                    dbCategory.Name,
                    dbCategory.Description
                    );
                    category.CategoryID = dbCategory.CategoryID;
                    categories.Add(category);
                }
                return categories;
            }
        }
        /// <summary>
        /// Deletes unwanted, surely made by mistake, Category.
        /// </summary>
        /// <param name="Name">Name of Category.</param>
        /// <returns>True if operation succeded, false otherwise.</returns>
        public static bool DeleteCategory(string Name)
        {
            using (var context = new SOSMEntities())
            {
                var category = context.Categories.FirstOrDefault(x => x.Name == Name);
                if (category == null)
                    return false;

                context.Categories.Remove(category);
                context.SaveChanges();
                return true;
            }
        }
    }
}
