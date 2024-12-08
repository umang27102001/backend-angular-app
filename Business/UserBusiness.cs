using System.Text.Json;
using backend.Abstraction.Models;
using backend.Business.Interface;

namespace backend.Business
{
    public class UserBusiness : IUserBusiness
    {
        public async Task<bool> AddUser(User user)
        {
            var filePath = @"C:\Users\UmangKanchan\source\repos\backend\Data\Users.json";
            string jsonContent = await File.ReadAllTextAsync(filePath);
            var data = string.IsNullOrEmpty(jsonContent) ? new List<User>() : JsonSerializer.Deserialize<List<User>>(jsonContent);
            user.Id = (data?.Count() ?? 0) + 1;
            data?.Add(user);
            string newFile = JsonSerializer.Serialize(data);
            File.WriteAllText(filePath, newFile);
            return true;
        }
        public async Task<bool> DeleteUser(int userId)
        {
            var filePath = @"C:\Users\UmangKanchan\source\repos\backend\Data\Users.json";
            string jsonContent = await File.ReadAllTextAsync(filePath);
            var data = JsonSerializer.Deserialize<List<User>>(jsonContent)?.Where(e=>e.Id != userId);
            string newFile = JsonSerializer.Serialize(data);
            File.WriteAllText(filePath, newFile);
            return true;
        }
        public async Task<List<User>> GetAllUsers()
        {
            var filePath = @"C:\Users\UmangKanchan\source\repos\backend\Data\Users.json";
            string jsonContent = await File.ReadAllTextAsync(filePath);
            var data = JsonSerializer.Deserialize<List<User>>(jsonContent);
            return data ?? new List<User>();
        }
        public async Task<bool> UpdateUser(User user)
        {
            var filePath = @"C:\Users\UmangKanchan\source\repos\backend\Data\Users.json";
            string jsonContent = await File.ReadAllTextAsync(filePath);
            var data = JsonSerializer.Deserialize<List<User>>(jsonContent);
            if(data == null)
            {
                return false;
            }
            data = data.Where(e=>e.Id != user.Id).ToList();
            data.Add(user);
            data = data.OrderBy(e=>e.Id).ToList();
            string newFile = JsonSerializer.Serialize(data);
            File.WriteAllText(filePath, newFile);
            return true;
        }
        public async Task<(bool, string)> LoginUser(User user)
        {
            var filePath = @"C:\Users\UmangKanchan\source\repos\backend\Data\Users.json";
            string jsonContent = await File.ReadAllTextAsync(filePath);
            var data = JsonSerializer.Deserialize<List<User>>(jsonContent);
            if (data == null)
            {
                return (false, "");
            }
            var userFromDb = data.Find(e => e.Id == user.Id);
            if (userFromDb == null) 
            {
                return (false, "");
            }

            return (false, "");
        }
    }
}
