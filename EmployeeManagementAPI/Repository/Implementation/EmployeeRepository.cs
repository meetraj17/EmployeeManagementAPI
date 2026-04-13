using EmployeeManagementAPI.Models;
using EmployeeManagementAPI.Repository.Interface;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementAPI.Repository.Implementation
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmpDbcontext context;

        public EmployeeRepository(EmpDbcontext context)
        {
            this.context = context;
        }
        public async Task<List<Employee>> GetAll()
        {
            var Employees = await context.Employees.ToListAsync();
            return Employees;
        }
        public async Task<Employee> GetById(int Id)
        {
            return await context.Employees.FindAsync(Id);
        }
        public async Task Add(Employee Emp)
        {
            await context.Employees.AddAsync(Emp);
            await context.SaveChangesAsync();
        }
        public async Task Update(Employee Emp)
        {
            context.Employees.Update(Emp);
            await context.SaveChangesAsync();
        }
        public async Task Delete(int Id)
        {
            var emp = await context.Employees.FindAsync(Id);
            if (emp != null)
            {
                context.Employees.Remove(emp);
                await context.SaveChangesAsync();
            }


        }
    }
}