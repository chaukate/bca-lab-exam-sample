using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BcaLabExam2024.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AnnualIncome = table.Column<decimal>(type: "decimal(14,4)", precision: 14, scale: 4, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AnnualIncome", "DateOfBirth", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 100000m, new DateTime(1969, 3, 17, 14, 11, 8, 85, DateTimeKind.Local).AddTicks(3835), "", "Tony", "Stark", "9876333345" },
                    { 2, 100000m, new DateTime(1974, 3, 17, 14, 11, 8, 85, DateTimeKind.Local).AddTicks(3854), "", "Thor", "Odinson", "9887633333" },
                    { 3, 100000m, new DateTime(1980, 3, 17, 14, 11, 8, 85, DateTimeKind.Local).AddTicks(3857), "", "Bruce", "Banner", "9876333344" },
                    { 4, 100000m, new DateTime(2004, 3, 17, 14, 11, 8, 85, DateTimeKind.Local).AddTicks(3858), "", "Peter", "Parker", "9873444452" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
