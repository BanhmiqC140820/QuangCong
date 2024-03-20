using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLCoffee.Migrations
{
    /// <inheritdoc />
    public partial class inii2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_NhanVien_nhanvienMaKH",
                table: "HoaDon");

            migrationBuilder.RenameColumn(
                name: "MaKH",
                table: "NhanVien",
                newName: "MaNV");

            migrationBuilder.RenameColumn(
                name: "nhanvienMaKH",
                table: "HoaDon",
                newName: "nhanvienMaNV");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDon_nhanvienMaKH",
                table: "HoaDon",
                newName: "IX_HoaDon_nhanvienMaNV");

            migrationBuilder.AddColumn<DateTime>(
                name: "Ngaysinh",
                table: "NhanVien",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_NhanVien_nhanvienMaNV",
                table: "HoaDon",
                column: "nhanvienMaNV",
                principalTable: "NhanVien",
                principalColumn: "MaNV",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_NhanVien_nhanvienMaNV",
                table: "HoaDon");

            migrationBuilder.DropColumn(
                name: "Ngaysinh",
                table: "NhanVien");

            migrationBuilder.RenameColumn(
                name: "MaNV",
                table: "NhanVien",
                newName: "MaKH");

            migrationBuilder.RenameColumn(
                name: "nhanvienMaNV",
                table: "HoaDon",
                newName: "nhanvienMaKH");

            migrationBuilder.RenameIndex(
                name: "IX_HoaDon_nhanvienMaNV",
                table: "HoaDon",
                newName: "IX_HoaDon_nhanvienMaKH");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_NhanVien_nhanvienMaKH",
                table: "HoaDon",
                column: "nhanvienMaKH",
                principalTable: "NhanVien",
                principalColumn: "MaKH",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
