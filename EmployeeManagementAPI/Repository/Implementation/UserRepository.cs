using EmployeeManagementAPI.Models;
using EmployeeManagementAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementAPI.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly EmpDbcontext context;

        public UserRepository(EmpDbcontext context)
        {
            this.context = context;
        }
        public async Task<User> GetUserByEmail(string email)
        {
            return await context.Users.FirstOrDefaultAsync(x => x.Email == email);
        }
        public async Task AddUser(User user)
        {
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();
        }
    }
}
