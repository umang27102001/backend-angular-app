using backend.Abstraction.Models;

namespace backend.Business.Interface
{
    public interface IProductBusiness
    {
        Task<List<Product>> GetProducts();
    }
}
