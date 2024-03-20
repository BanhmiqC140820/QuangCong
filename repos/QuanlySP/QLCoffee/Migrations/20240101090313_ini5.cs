using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLCoffee.Migrations
{
    /// <inheritdoc />
    public partial class ini5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_NhanVien_nhanvienMaNV",
                table: "HoaDon");

            migrationBuilder.DropIndex(
                name: "IX_HoaDon_nhanvienMaNV",
                table: "HoaDon");

            migrationBuilder.DropColumn(
                name: "nhanvienMaNV",
                table: "HoaDon");

            migrationBuilder.AlterColumn<string>(
                name: "MaNV",
                table: "HoaDon",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaNV",
                table: "HoaDon",
                column: "MaNV");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_NhanVien_MaNV",
                table: "HoaDon",
                column: "MaNV",
                principalTable: "NhanVien",
                principalColumn: "MaNV",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_NhanVien_MaNV",
                table: "HoaDon");

            migrationBuilder.DropIndex(
                name: "IX_HoaDon_MaNV",
                table: "HoaDon");

            migrationBuilder.AlterColumn<long>(
                name: "MaNV",
                table: "HoaDon",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AddColumn<string>(
                name: "nhanvienMaNV",
                table: "HoaDon",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_nhanvienMaNV",
                table: "HoaDon",
                column: "nhanvienMaNV");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_NhanVien_nhanvienMaNV",
                table: "HoaDon",
                column: "nhanvienMaNV",
                principalTable: "NhanVien",
                principalColumn: "MaNV",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
