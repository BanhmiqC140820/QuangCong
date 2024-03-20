using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogApp.Migrations
{
    /// <inheritdoc />
    public partial class Inserts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "id", "DateCreated", "DateUpdate", "name" },
                values: new object[,]
                {
                    { 1L, new DateTime(2023, 11, 18, 15, 56, 48, 946, DateTimeKind.Local).AddTicks(3030), null, "Technology" },
                    { 2L, new DateTime(2023, 11, 18, 15, 56, 48, 946, DateTimeKind.Local).AddTicks(3040), null, "Science" }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "Author", "Content", "DateCreated", "DateUpdate", "IdCategory", "Title" },
                values: new object[,]
                {
                    { 1L, "John Doe", "Entity Framework Core is an ORM framework...", new DateTime(2023, 11, 18, 15, 56, 48, 946, DateTimeKind.Local).AddTicks(3113), null, 1L, "Introduction to EF Core" },
                    { 2L, "Jane Smith", "Artificial Intelligence is reshaping industries...", new DateTime(2023, 11, 18, 15, 56, 48, 946, DateTimeKind.Local).AddTicks(3115), null, 2L, "Advancements in AI" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "id",
                keyValue: 2L);
        }
    }
}
