using System.Text.Json;
using backend.Abstraction.Models;

namespace backend.Business.Interface
{
    public interface IUserBusiness
    {
        Task<bool> AddUser(User user);
        Task<bool> DeleteUser(int userId);
        Task<List<User>> GetAllUsers();
        Task<bool> UpdateUser(User user);
        Task<(bool, string)> LoginUser(User user);
    }
}
