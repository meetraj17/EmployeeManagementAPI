using EmployeeManagementAPI.Models;
using EmployeeManagementAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementAPI.Repository.Implementation
{
    public class EmployeeDepartment : IEmployeeDepartment
    {
        private readonly EmpDbcontext context;

        public EmployeeDepartment(EmpDbcontext context)
        {
            this.context = context;
        }
        public async Task Add(EmpDepartment Edt)
        {
            await context.AddAsync(Edt);
            await context.SaveChangesAsync();
        }
        public async Task<List<EmpDepartment>> GetAll()
        {
            var Departments = await context.EmpDepartments.ToListAsync();
            return Departments;
        }
        public async Task<List<EmpDepartment>> ActiveDepartments()
        {
            var Departments = await context.EmpDepartments.Where(x => x.EmpDepStatus == 1).ToListAsync();
            return Departments;
        }
        public async Task<EmpDepartment> GetDepartmentById(int Id)
        {
            return await context.EmpDepartments.FindAsync(Id);
        }

    }
}
