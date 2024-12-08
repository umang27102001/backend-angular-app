using System.Text.Json;
using backend.Abstraction.Models;
using backend.Business.Interface;

namespace backend.Business
{
    public class CategoryBusiness : ICategoryBusiness
    {
        public async Task<List<Category>> GetAllCategories()
        {
            var filePath = @"C:\Users\UmangKanchan\source\repos\backend\Data\Categories.json";
            string jsonContent = await File.ReadAllTextAsync(filePath);
            return JsonSerializer.Deserialize<List<Category>>(jsonContent) ?? new();
        }
    }
}
