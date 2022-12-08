using APIApps.models;
using APIApps.Services;
using Microsoft.EntityFrameworkCore;

namespace APIApps.Services

{
    public class CategoryDataAccessService : IDbAccessService<Category, int>
    {
        ShoppingAppContext shoppingAppContext;
        public CategoryDataAccessService(ShoppingAppContext shoppingAppContext)
        {
            this.shoppingAppContext = shoppingAppContext;
        }

        async Task<Category> IDbAccessService<Category, int>.CreateAsync(Category entity)
        {
            try
            {
                var res = await shoppingAppContext.Categories.AddAsync(entity);
                await shoppingAppContext.SaveChangesAsync();
                return res.Entity;
            }
            catch (Exception)
            {
                throw;
            }
        }


        async Task<bool> IDbAccessService<Category, int>.DeleteAsync(int id)
        {
            var rec = await shoppingAppContext.Categories.FindAsync(id);
            if (rec != null)
            {
                shoppingAppContext.Categories.Remove(rec);
                await shoppingAppContext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        async Task<Category> IDbAccessService<Category, int>.GetAsync(int id)
        {
            return await shoppingAppContext.Categories.FindAsync(id);
        }

        async Task<IEnumerable<Category>> IDbAccessService<Category, int>.GetAsync()
        {
            return await shoppingAppContext.Categories.ToListAsync();
        }

        async Task<Category> IDbAccessService<Category, int>.UpdateAsync(int id, Category entity)
        {


            try
            {
                // USing Id to search for the ENtity
                // the deptTOUpdate will be already holding the entity 
                var cat = await shoppingAppContext.Categories.FindAsync(id);
                if (cat != null)
                {
                    cat.BasePrice = entity.BasePrice;
                    cat.CategoryId = entity.CategoryId;
                    cat.CategoryName = entity.CategoryName;
                    await shoppingAppContext.SaveChangesAsync();
                    return cat;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
