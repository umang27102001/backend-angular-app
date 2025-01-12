
using backend.Abstraction.Models;
using backend.Abstraction.Result;
using Microsoft.EntityFrameworkCore;
using Repository.Context;

namespace Repository
{
    public class SqlRepository : ISqlRepository
    {
        private readonly AppDbContext dbContext;
        public SqlRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IResult<List<Product>>> GetAllProductsAsync(CancellationToken token)
        {
            using var context = this.dbContext;
            var products = await context.products.ToListAsync(token);
            return new Result<List<Product>>
            {
                Value = products
            };
        }
        public async Task<bool> DeleteProductAsync(int id, CancellationToken token)
        {
            try
            {
                using var context = this.dbContext;
                var product = context.products.FirstOrDefault(p => p.Id == id);
                if (product == null) 
                {
                    return false;
                }
                context.Remove(product);
                await context.SaveChangesAsync(token);
            }
            catch (Exception ex) 
            {
                return false;
            }
            return true;
        }

        public async Task<bool> AddProductAsync(Product prd, CancellationToken token)
        {
            try
            {
                using var context = this.dbContext;
                context.Add(prd);
                await context.SaveChangesAsync(token);
            }
            catch
            {
                return false;
            }
            return true;
        }

        public async Task<bool> UpdateProductAsync(Product prd, CancellationToken token)
        {
            try
            {
                var context = this.dbContext;
                var fromDB = context.products.FirstOrDefault(e=> e.Id == prd.Id);
                if (fromDB == null) 
                {
                    return false;
                }
                context.Entry(fromDB).State = EntityState.Detached;
                var test = context.Update(prd);
                await context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
