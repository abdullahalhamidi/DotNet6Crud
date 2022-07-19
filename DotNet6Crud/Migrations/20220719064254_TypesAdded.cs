using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNet6Crud.Migrations
{
    public partial class TypesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BorrowedDate",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "BorrowedItem",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DaysBorrowed",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ItemReturnDate",
                table: "Items",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BorrowedDate",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "BorrowedItem",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "DaysBorrowed",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "ItemReturnDate",
                table: "Items");
        }
    }
}
