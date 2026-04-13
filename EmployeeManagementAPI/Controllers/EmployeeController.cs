using EmployeeManagementAPI.Models;
using EmployeeManagementAPI.Repository.Implementation;
using EmployeeManagementAPI.Repository.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository repo;

        public EmployeeController(IEmployeeRepository repo)
        {
            this.repo = repo;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var data = await repo.GetAll();
            return Ok(data);
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetDataById(int Id)
        {
            var data = await repo.GetById(Id);
            return Ok(data);
        }
        [HttpPost]
        public async Task<IActionResult> Add(Employee emp)
        {
            await repo.Add(emp);
            return Ok("Employee Added");
        }
        [HttpPut]
        public async Task<IActionResult> Update(Employee emp)
        {
            await repo.Update(emp);
            return Ok("Employee Updated");
        }
        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            await repo.Delete(Id);
            return Ok("Employee Removed");
        }

    }
}
