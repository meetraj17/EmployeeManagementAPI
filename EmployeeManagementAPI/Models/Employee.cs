using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementAPI.Models
{
    public class Employee
    {
        [Key]
        [Column("EmpId",TypeName ="Numeric(18,0)")]
        public int Id { get; set; }
        [Column("EmpName", TypeName = "Nvarchar(100)")]
        public string? Name { get; set; }
        [Column("EmpEmail", TypeName = "Nvarchar(100)")]
        public string? Email { get; set; }
        [Column("EmpDepartment", TypeName = "Nvarchar(100)")]
        public string? Department { get; set; }
        [Column("EmpImage", TypeName = "Nvarchar(100)")]
        public string? ImagePath { get; set; }
        [Column("EmpMobileNo", TypeName = "Nvarchar(100)")]
        public string? MobileNo { get; set; }
        [Column("EmpCity", TypeName = "varchar(100)")]
        public string? City { get; set; }
        public DateTime EmpDateOfBirth { get; set; }
    }
}
