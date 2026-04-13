using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementAPI.Models
{
    public class EmpDbcontext : DbContext
    {
        public EmpDbcontext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmpDepartment> EmpDepartments { get; set; }
    }
}
