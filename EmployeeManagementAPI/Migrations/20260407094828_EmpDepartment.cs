using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class EmpDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmpDepartments",
                columns: table => new
                {
                    EmpDep_Id = table.Column<decimal>(type: "Numeric(18,0)", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmpDep_Name = table.Column<string>(type: "Nvarchar(100)", nullable: false),
                    EmpDep_Status = table.Column<int>(type: "Int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpDepartments", x => x.EmpDep_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmpDepartments");
        }
    }
}
