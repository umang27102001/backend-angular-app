using backend.Abstraction.Models;
using backend.Abstraction.Result;
namespace Repository
{
    public interface ISqlRepository
    {
        Task<IResult<List<Product>>> GetAllProductsAsync(CancellationToken token);
        Task<bool> DeleteProductAsync(int id, CancellationToken token);
        Task<bool> AddProductAsync(Product prd, CancellationToken token);
        Task<bool> UpdateProductAsync(Product prd, CancellationToken token);
    }
}
