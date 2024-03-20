using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogApp.Migrations
{
    /// <inheritdoc />
    public partial class c44 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 3L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 14, 19, 40, 778, DateTimeKind.Local).AddTicks(8860));

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

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "id",
                keyValue: 3L,
                column: "DateCreated",
                value: new DateTime(2023, 11, 25, 14, 19, 40, 778, DateTimeKind.Local).AddTicks(8780));
        }
    }
}
