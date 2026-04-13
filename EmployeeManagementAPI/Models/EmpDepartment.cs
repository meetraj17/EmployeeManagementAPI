using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeManagementAPI.Models
{
    public class EmpDepartment
    {
        [Key]
        [Column("EmpDep_Id",TypeName ="Numeric(18,0)")]
        public int EmpDepId { get; set; }
        [Column("EmpDep_Name",TypeName ="Nvarchar(100)")]
        public String EmpDepName { get; set; }
        [Column("EmpDep_Status", TypeName = "Int")]
        public int EmpDepStatus { get; set; }
    }
}
