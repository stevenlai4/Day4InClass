using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Day4InClass.Data.Migrations
{
    public partial class UpdateToDo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "ToDos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "ToDos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "ToDos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "Priority" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 5, 25, 390, DateTimeKind.Local).AddTicks(9577), 1 });

            migrationBuilder.UpdateData(
                table: "ToDos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "Priority" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 5, 25, 400, DateTimeKind.Local).AddTicks(96), 1 });

            migrationBuilder.UpdateData(
                table: "ToDos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "Priority" },
                values: new object[] { new DateTime(2020, 12, 1, 11, 5, 25, 400, DateTimeKind.Local).AddTicks(186), 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "ToDos");

            migrationBuilder.DropColumn(
                name: "Priority",
                table: "ToDos");
        }
    }
}
