using EmployeeManagementAPI.Models;

namespace EmployeeManagementAPI.Repository.Interface
{
    public interface IEmployeeDepartment
    {
        Task Add(EmpDepartment Edt);
        Task<List<EmpDepartment>> GetAll();

        Task<List<EmpDepartment>> ActiveDepartments();

        Task<EmpDepartment> GetDepartmentById(int Id);
    }
}
