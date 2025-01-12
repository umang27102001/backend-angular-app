using System.Text.Json;
using backend.Abstraction.Models;
using backend.Business.Interface;
using Repository;

namespace backend.Business
{
    public class ProductBuisness: IProductBusiness
    {
        private readonly ISqlRepository repository;
        
        public ProductBuisness(ISqlRepository repository)
        {
            this.repository = repository;
        }

        public async Task<bool> DeleteProduct(int productId)
        {
            return await this.repository.DeleteProductAsync(productId, CancellationToken.None);
        }

        public async Task<List<Product>> GetProducts()
        {
            try
            {
               return (await this.repository.GetAllProductsAsync(CancellationToken.None)).Value;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<bool> AddProduct(Product product)
        {
            try
            {
               return await this.repository.AddProductAsync(product, CancellationToken.None);
            }
            catch 
            {
                return false;
            }
        }

        public async Task<bool> UpdateProduct(Product prod)
        {
            try
            {
                return await this.repository.UpdateProductAsync(prod, CancellationToken.None);
            }
            catch
            {
                return false;
            }
        }
    }
}