using EmployeeManagementAPI.Models;
using EmployeeManagementAPI.Repository.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class EmpDepartmentController : ControllerBase
    {
        private readonly IEmployeeDepartment repo;

        public EmpDepartmentController(IEmployeeDepartment repo)
        {
            this.repo = repo;
        }

        [HttpPost]
        public async Task<IActionResult> Add(EmpDepartment Edt)
        {
            await repo.Add(Edt);
            return Ok("Employee Department Added");
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await repo.GetAll();
            return Ok(data);
        }
        [HttpGet("ActiveDepartments")]
        public async Task<IActionResult> ActiveDepartments()
        {
            var data = await repo.ActiveDepartments();
            return Ok(data);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetDataById(int Id)
        {
            var data = await repo.GetDepartmentById(Id);
            return Ok(data);
        }
    }
}

