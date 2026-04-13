using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace EmployeeManagementAPI.Models
{
    public class User
    {
        [Key]
        [Column("UserId",TypeName ="Numeric(18,0)")]
        public int Id { get; set; }
        [Column("UserEmail", TypeName = "Nvarchar(100)")]
        public string? Email { get; set; }
        [Column("UserPassword", TypeName = "Nvarchar(100)")]
        public string? Password { get; set; }
        [Column("UserName", TypeName = "Nvarchar(100)")]
        public string? Name { get; set; }
        [Column("UserType", TypeName = "Numeric(18,0)")]
        public Decimal UserType { get; set; }
    }
}
