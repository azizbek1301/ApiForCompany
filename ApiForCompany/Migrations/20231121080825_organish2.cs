using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiForCompany.Migrations
{
    /// <inheritdoc />
    public partial class organish2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeStaff_Employee_EmployeeId",
                table: "EmployeeStaff");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeStaff_Staff_StaffId",
                table: "EmployeeStaff");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeStaff_EmployeeId",
                table: "EmployeeStaff");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeStaff_StaffId",
                table: "EmployeeStaff");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "EmployeeStaff");

            migrationBuilder.DropColumn(
                name: "StaffId",
                table: "EmployeeStaff");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeStaff_Employee_Id",
                table: "EmployeeStaff",
                column: "Employee_Id");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeStaff_Staff_Id",
                table: "EmployeeStaff",
                column: "Staff_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeStaff_Employee_Employee_Id",
                table: "EmployeeStaff",
                column: "Employee_Id",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeStaff_Staff_Staff_Id",
                table: "EmployeeStaff",
                column: "Staff_Id",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeStaff_Employee_Employee_Id",
                table: "EmployeeStaff");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeStaff_Staff_Staff_Id",
                table: "EmployeeStaff");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeStaff_Employee_Id",
                table: "EmployeeStaff");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeStaff_Staff_Id",
                table: "EmployeeStaff");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "EmployeeStaff",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StaffId",
                table: "EmployeeStaff",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeStaff_EmployeeId",
                table: "EmployeeStaff",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeStaff_StaffId",
                table: "EmployeeStaff",
                column: "StaffId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeStaff_Employee_EmployeeId",
                table: "EmployeeStaff",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeStaff_Staff_StaffId",
                table: "EmployeeStaff",
                column: "StaffId",
                principalTable: "Staff",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
