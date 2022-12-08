using APIApps.models;
using APIApps.Services;
using Microsoft.EntityFrameworkCore;

namespace APIApps.Services
{

    public class ProductDataAccessService : IDbAccessService<Product, int>
    {
        ShoppingAppContext shoppingAppContext;
        public ProductDataAccessService(ShoppingAppContext shopContext)
        {
            this.shoppingAppContext = shopContext;
        }

        async Task<Product> IDbAccessService<Product, int>.CreateAsync(Product entity)
        {
            var res = await shoppingAppContext.Products.AddAsync(entity);
            await shoppingAppContext.SaveChangesAsync();
            return res.Entity;

        }

      
        async Task<bool> IDbAccessService<Product, int>.DeleteAsync(int id)
        {


            var rec = await shoppingAppContext.Products.FindAsync(id);
            if (rec != null)
            {
                shoppingAppContext.Products.Remove(rec);
                await shoppingAppContext.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        async Task<IEnumerable<Product>> IDbAccessService<Product, int>.GetAsync()
        {
            return await shoppingAppContext.Products.ToListAsync();
        }

        async Task<Product> IDbAccessService<Product, int>.GetAsync(int id)
        {
            return await shoppingAppContext.Products.FindAsync(id);
        }

        async Task<Product> IDbAccessService<Product, int>.UpdateAsync(int id, Product entity)
        {

            try
            {
                // USing Id to search for the ENtity
                // the deptTOUpdate will be already holding the entity 
                var cat = await shoppingAppContext.Products.FindAsync(id);
                if (cat != null)
                {
                    // the Update() Method will be using the same 
                    // entity to First Serach (internaly) and then
                    // Update
                    var res = shoppingAppContext.Update<Product>(cat);
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


