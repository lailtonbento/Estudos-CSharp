using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaVendas.Migrations
{
    public partial class DepartmentIdForeighKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "birthDate",
                table: "Seller",
                newName: "BirthDate");

            migrationBuilder.RenameColumn(
                name: "baseSalary",
                table: "Seller",
                newName: "BaseSalary");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BirthDate",
                table: "Seller",
                newName: "birthDate");

            migrationBuilder.RenameColumn(
                name: "BaseSalary",
                table: "Seller",
                newName: "baseSalary");
        }
    }
}
