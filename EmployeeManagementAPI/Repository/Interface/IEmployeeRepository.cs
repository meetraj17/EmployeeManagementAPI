using EmployeeManagementAPI.Models;

namespace EmployeeManagementAPI.Repository.Interface
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAll();
        Task<Employee> GetById(int Id);
        Task Add(Employee Emp);
        Task Update(Employee Emp);
        Task Delete(int Id);
    }
}
