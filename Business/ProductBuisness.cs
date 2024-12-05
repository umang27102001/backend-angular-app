using System.Text.Json;
using backend.Abstraction.Models;
using backend.Business.Interface;

namespace backend.Business
{
    public class ProductBuisness: IProductBusiness
    {
        public async Task<List<Product>> GetProducts()
        {
            var filePath = @"C:\Users\UmangKanchan\source\repos\backend\Data\Product.json";
            string jsonContent = await File.ReadAllTextAsync(filePath);
            return JsonSerializer.Deserialize<List<Product>>(jsonContent)??new ();
        }
    }
}
