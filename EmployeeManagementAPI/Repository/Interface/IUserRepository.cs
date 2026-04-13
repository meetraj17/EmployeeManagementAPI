using EmployeeManagementAPI.Models;

namespace EmployeeManagementAPI.Repository.Interface
{
    public interface IUserRepository
    {
        Task<User> GetUserByEmail (string email);
        Task AddUser(User user);
    }
}
