using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiForCompany.Migrations
{
    /// <inheritdoc />
    public partial class organish1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Company_CompanyId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_CompanyId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Employee");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_Company_Id",
                table: "Employee",
                column: "Company_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Company_Company_Id",
                table: "Employee",
                column: "Company_Id",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Company_Company_Id",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_Company_Id",
                table: "Employee");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_CompanyId",
                table: "Employee",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Company_CompanyId",
                table: "Employee",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
