using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNet6Crud.Migrations
{
    public partial class changedDataType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BorrowedItem",
                table: "Items",
                newName: "BorrowedItemPrice");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BorrowedItemPrice",
                table: "Items",
                newName: "BorrowedItem");
        }
    }
}
