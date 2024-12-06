using backend.Abstraction.Models;

namespace backend.Business.Interface
{
    public interface IProductBusiness
    {
        Task<List<Product>> GetProducts();
        Task<bool> SetProduct(Product product);
        Task<bool> DeleteProduct(int productId);
    }
}
