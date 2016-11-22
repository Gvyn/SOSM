using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOSM1
{
    class InterfaceToDataBaseCategoryMethods
    {
        SOSMEntities context;

        public InterfaceToDataBaseCategoryMethods()
        {
            context = new SOSMEntities();
        }

        /// <summary>
        /// Crates a brand new, ready for action Category. 
        /// </summary>
        /// <param name="Name">Name of Category, like 'Vegetables' or 'Elder scrolls'</param>
        /// <param name="Description">Description of category.</param>
        /// <returns>Category object.</returns>
        public async Task<Category> AddCategory(Category newCategory)
        {
            string name = newCategory.Name;
            if ((await context.Categories.FirstOrDefaultAsync(x => x.Name == name)) != null)
                return null;
            Categories dbCategory = new Categories();
            dbCategory.Name = newCategory.Name;
            dbCategory.Description = newCategory.Description;

            context.Categories.Add(dbCategory);
            await context.SaveChangesAsync();

            newCategory.CategoryID = dbCategory.CategoryID;
            return newCategory;
        }

        /// <summary>
        /// Get category data by ID.
        /// </summary>
        /// <param name="CategoryID">ID of wanted category.</param>
        /// <returns>Category object or null.</returns>
        public async Task<Category> GetCategory(long CategoryID)
        {
            var dbCategory = await context.Categories.FindAsync(CategoryID);
            if (dbCategory == null)
                return null;

            Category category = new Category(
                dbCategory.Name,
                dbCategory.Description
            );
            category.CategoryID = dbCategory.CategoryID;
            return category;
        }

        /// <summary>
        /// Returns all categories in database.
        /// </summary>
        /// <returns>List of Category objects.</returns>
        public async Task<List<Category>> GetAllCategories()
        {
            var dbCategories = await context.Categories.ToListAsync();
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
        /// <summary>
        /// Deletes unwanted, surely made by mistake, Category.
        /// </summary>
        /// <param name="Name">Name of Category.</param>
        /// <returns>True if operation succeded, false otherwise.</returns>
        public async Task<bool> DeleteCategory(string Name)
        {
            var category = await context.Categories.FirstOrDefaultAsync(x => x.Name == Name);
            if (category == null)
                return false;

            context.Categories.Remove(category);
            await context.SaveChangesAsync();
            return true;
        }
    }
}
