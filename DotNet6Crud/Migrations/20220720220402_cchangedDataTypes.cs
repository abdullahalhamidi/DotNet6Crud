using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNet6Crud.Migrations
{
    public partial class cchangedDataTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DaysBorrowed",
                table: "Items",
                newName: "ItemBorrowedPrice");

            migrationBuilder.RenameColumn(
                name: "BorrowedItemPrice",
                table: "Items",
                newName: "ItemBorrowed");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemBorrowedPrice",
                table: "Items",
                newName: "DaysBorrowed");

            migrationBuilder.RenameColumn(
                name: "ItemBorrowed",
                table: "Items",
                newName: "BorrowedItemPrice");
        }
    }
}
