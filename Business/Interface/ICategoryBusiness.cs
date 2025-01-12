using backend.Abstraction.Models;

namespace backend.Business.Interface
{
    public interface ICategoryBusiness
    {
        Task<List<Category>> GetAllCategories();
        Task<Category?> GetAllCategoryById(int id);
    }
}
