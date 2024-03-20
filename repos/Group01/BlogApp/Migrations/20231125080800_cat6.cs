using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogApp.Migrations
{
    /// <inheritdoc />
    public partial class cat6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 15, 8, 0, 176, DateTimeKind.Local).AddTicks(3180));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 15, 8, 0, 176, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 3L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 15, 8, 0, 176, DateTimeKind.Local).AddTicks(3184));

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "Author", "Content", "DateCreated", "DateUpdate", "IdCategory", "Title" },
                values: new object[,]
                {
                    { 4L, "Jane Smith", "Artificial Intelligence is reshaping industries...", new DateTime(2023, 11, 25, 15, 8, 0, 176, DateTimeKind.Local).AddTicks(3185), null, 4L, "Advancements" },
                    { 5L, "Jane Smith", "Artificial Intelligence is reshaping industries...", new DateTime(2023, 11, 25, 15, 8, 0, 176, DateTimeKind.Local).AddTicks(3186), null, 5L, "Advancements" }
                });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 15, 8, 0, 176, DateTimeKind.Local).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "id",
                keyValue: 2L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 15, 8, 0, 176, DateTimeKind.Local).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "id",
                keyValue: 3L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 15, 8, 0, 176, DateTimeKind.Local).AddTicks(3035));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "id",
                keyValue: 4L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 15, 8, 0, 176, DateTimeKind.Local).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "id",
                keyValue: 5L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 15, 8, 0, 176, DateTimeKind.Local).AddTicks(3037));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 14, 33, 25, 609, DateTimeKind.Local).AddTicks(1267));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 14, 33, 25, 609, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 3L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 14, 33, 25, 609, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 14, 33, 25, 609, DateTimeKind.Local).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "id",
                keyValue: 2L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 14, 33, 25, 609, DateTimeKind.Local).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "id",
                keyValue: 3L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 14, 33, 25, 609, DateTimeKind.Local).AddTicks(1185));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "id",
                keyValue: 4L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 14, 33, 25, 609, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "id",
                keyValue: 5L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 14, 33, 25, 609, DateTimeKind.Local).AddTicks(1187));
        }
    }
}
