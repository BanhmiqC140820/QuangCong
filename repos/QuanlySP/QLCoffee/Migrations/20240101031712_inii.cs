using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLCoffee.Migrations
{
    /// <inheritdoc />
    public partial class inii : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "nhanvienMaKH",
                table: "HoaDon",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaKH = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Hovaten = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    DiaChi = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    SDT = table.Column<string>(type: "TEXT", maxLength: 10, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    TenDN = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Pass = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaKH);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_nhanvienMaKH",
                table: "HoaDon",
                column: "nhanvienMaKH");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDon_NhanVien_nhanvienMaKH",
                table: "HoaDon",
                column: "nhanvienMaKH",
                principalTable: "NhanVien",
                principalColumn: "MaKH",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDon_NhanVien_nhanvienMaKH",
                table: "HoaDon");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropIndex(
                name: "IX_HoaDon_nhanvienMaKH",
                table: "HoaDon");

            migrationBuilder.DropColumn(
                name: "nhanvienMaKH",
                table: "HoaDon");
        }
    }
}
