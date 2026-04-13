using EmployeeManagementAPI.DTOs;
using EmployeeManagementAPI.Helpers;
using EmployeeManagementAPI.Models;
using EmployeeManagementAPI.Repository.Interface;
using EmployeeManagementAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagementAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository repo;
        private readonly JwtService jwtService;

        public UserController(IUserRepository repo, JwtService jwtService)
        {
            this.repo = repo;
            this.jwtService = jwtService;
        }
        [HttpPost("add")]
        public async Task<IActionResult> AddUser(User user)
        {
            await repo.AddUser(user);
            return Ok("User Added");
        }
        [HttpGet("{email}")]
        public async Task<IActionResult> GetUser(string email)
        {
            var user = await repo.GetUserByEmail(email);
            return Ok(user);
        }
        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto dto)
        {
            var existingUser = await repo.GetUserByEmail(dto.Email);
            if (existingUser != null)
                return BadRequest("User already exists");

            // Hash password
            var user = new User
            {
                Email = dto.Email,
                Password = PasswordHelper.HashPassword(dto.Password),
                Name=dto.Name,
                UserType=dto.UserType
            };

            await repo.AddUser(user);

            return Ok("User Registered Successfully");
        }
        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            var user = await repo.GetUserByEmail(dto.Email);

            if (user == null || !PasswordHelper.VerifyPassword(user.Password, dto.Password))
                return Unauthorized("Invalid credentials");

            var token = jwtService.GenerateToken(user);

            return Ok(new { Token = token });
        }
    }
}
