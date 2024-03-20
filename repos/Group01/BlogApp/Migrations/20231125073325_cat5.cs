using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlogApp.Migrations
{
    /// <inheritdoc />
    public partial class cat5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "id", "DateCreated", "DateUpdate", "name" },
                values: new object[,]
                {
                    { 4L, new DateTime(2023, 11, 25, 14, 33, 25, 609, DateTimeKind.Local).AddTicks(1186), null, "Secret" },
                    { 5L, new DateTime(2023, 11, 25, 14, 33, 25, 609, DateTimeKind.Local).AddTicks(1187), null, "Sound effect" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 14, 20, 34, 79, DateTimeKind.Local).AddTicks(8977));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 2L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 14, 20, 34, 79, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 3L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 14, 20, 34, 79, DateTimeKind.Local).AddTicks(8981));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "id",
                keyValue: 1L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 14, 20, 34, 79, DateTimeKind.Local).AddTicks(8875));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "id",
                keyValue: 2L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 14, 20, 34, 79, DateTimeKind.Local).AddTicks(8884));

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "id",
                keyValue: 3L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 14, 20, 34, 79, DateTimeKind.Local).AddTicks(8885));
        }
    }
}
