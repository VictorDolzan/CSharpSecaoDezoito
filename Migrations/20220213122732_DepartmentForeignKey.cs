using Microsoft.EntityFrameworkCore.Migrations;

namespace CSharpSecaoDezoito.Migrations
{
    public partial class DepartmentForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_DepartmentSId",
                table: "Seller");

            migrationBuilder.DropIndex(
                name: "IX_Seller_DepartmentSId",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "DepartmentSId",
                table: "Seller");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Seller",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Seller_DepartmentId",
                table: "Seller",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_DepartmentId",
                table: "Seller");

            migrationBuilder.DropIndex(
                name: "IX_Seller_DepartmentId",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Seller");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentSId",
                table: "Seller",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seller_DepartmentSId",
                table: "Seller",
                column: "DepartmentSId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_DepartmentSId",
                table: "Seller",
                column: "DepartmentSId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
