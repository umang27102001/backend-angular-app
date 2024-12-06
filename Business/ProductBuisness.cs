using System.Text.Json;
using backend.Abstraction.Models;
using backend.Business.Interface;

namespace backend.Business
{
    public class ProductBuisness: IProductBusiness
    {
        public async Task<bool> DeleteProduct(int productId)
        {
            var filePath = @"C:\Users\UmangKanchan\source\repos\backend\Data\Product.json";
            string jsonContent = await File.ReadAllTextAsync(filePath);
            var data = JsonSerializer.Deserialize<List<Product>>(jsonContent)?.Where(data => data.Id!=productId);
            string newFile = JsonSerializer.Serialize(data);
            File.WriteAllText(filePath, newFile);
            return true;
        }

        public async Task<List<Product>> GetProducts()
        {
            var filePath = @"C:\Users\UmangKanchan\source\repos\backend\Data\Product.json";
            string jsonContent = await File.ReadAllTextAsync(filePath);
            bool a = jsonContent is string;
            return JsonSerializer.Deserialize<List<Product>>(jsonContent)??new ();
        }
        public async Task<bool> SetProduct(Product product)
        {
            try
            {
                var filePath = @"C:\Users\UmangKanchan\source\repos\backend\Data\Product.json";
                string jsonContent = await File.ReadAllTextAsync(filePath);
                var data = JsonSerializer.Deserialize<List<Product>>(jsonContent);
                data!.Add(product);
                string newFile = JsonSerializer.Serialize(data);
                File.WriteAllText(filePath, newFile);
                return true;
            }
            catch 
            {
                return false;
            }
        }
    }
}
