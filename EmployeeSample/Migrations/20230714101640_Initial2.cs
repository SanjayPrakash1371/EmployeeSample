using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeSample.Migrations
{
    /// <inheritdoc />
    public partial class Initial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeesRoles_Employees_RoleOfEmployee",
                table: "EmployeesRoles");

            migrationBuilder.DropIndex(
                name: "IX_EmployeesRoles_RoleOfEmployee",
                table: "EmployeesRoles");

            migrationBuilder.DropColumn(
                name: "RoleOfEmployee",
                table: "EmployeesRoles");

            migrationBuilder.AddColumn<string>(
                name: "empId",
                table: "EmployeesRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "empId",
                table: "EmployeesRoles");

            migrationBuilder.AddColumn<int>(
                name: "RoleOfEmployee",
                table: "EmployeesRoles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeesRoles_RoleOfEmployee",
                table: "EmployeesRoles",
                column: "RoleOfEmployee");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeesRoles_Employees_RoleOfEmployee",
                table: "EmployeesRoles",
                column: "RoleOfEmployee",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
