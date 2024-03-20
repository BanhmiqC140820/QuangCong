using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogApp.Migrations
{
    /// <inheritdoc />
    public partial class cat4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 14, 19, 40, 778, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 14, 19, 40, 778, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "Author", "Content", "DateCreated", "DateUpdate", "IdCategory", "Title" },
                values: new object[] { 3L, "Jane Smith", "Artificial Intelligence is reshaping industries...", new DateTime(2023, 11, 25, 14, 19, 40, 778, DateTimeKind.Local).AddTicks(8860), null, 2L, "Advancements in AI" });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 14, 19, 40, 778, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "id",
                keyValue: 2L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 14, 19, 40, 778, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "id", "DateCreated", "DateUpdate", "name" },
                values: new object[] { 3L, new DateTime(2023, 11, 25, 14, 19, 40, 778, DateTimeKind.Local).AddTicks(8780), null, "Media" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 18, 15, 56, 48, 946, DateTimeKind.Local).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 18, 15, 56, 48, 946, DateTimeKind.Local).AddTicks(3115));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 18, 15, 56, 48, 946, DateTimeKind.Local).AddTicks(3030));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "id",
                keyValue: 2L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 18, 15, 56, 48, 946, DateTimeKind.Local).AddTicks(3040));
        }
    }
}
