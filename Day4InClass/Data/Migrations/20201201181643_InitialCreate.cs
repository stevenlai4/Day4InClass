﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Day4InClass.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ToDos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(nullable: true),
                    IsComplete = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToDos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "Description", "IsComplete" },
                values: new object[] { 1, "Bake Cookies", false });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "Description", "IsComplete" },
                values: new object[] { 2, "Eat the cookies", false });

            migrationBuilder.InsertData(
                table: "ToDos",
                columns: new[] { "Id", "Description", "IsComplete" },
                values: new object[] { 3, "Run around the block", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ToDos");
        }
    }
}
