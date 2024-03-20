using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace QLCoffee.Migrations
{
    /// <inheritdoc />
    public partial class iniV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
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
                    table.PrimaryKey("PK_Customers", x => x.MaKH);
                });

            migrationBuilder.CreateTable(
                name: "Loai",
                columns: table => new
                {
                    MaLoai = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    TenLoai = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loai", x => x.MaLoai);
                });

            migrationBuilder.CreateTable(
                name: "UserAdmin",
                columns: table => new
                {
                    TenDN = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Pass = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Quyen = table.Column<bool>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAdmin", x => x.TenDN);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHD = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaKH = table.Column<long>(type: "INTEGER", nullable: false),
                    NgayMua = table.Column<DateTime>(type: "date", nullable: true),
                    DaMua = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK_HoaDon_Customers_MaKH",
                        column: x => x.MaKH,
                        principalTable: "Customers",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Coffe",
                columns: table => new
                {
                    MaSanPham = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    TenSanPHam = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    MoTa = table.Column<string>(type: "TEXT", maxLength: 500, nullable: false),
                    Gia = table.Column<long>(type: "INTEGER", nullable: true),
                    SoLuong = table.Column<long>(type: "INTEGER", nullable: true),
                    XuatXu = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    MaLoai = table.Column<string>(type: "TEXT", nullable: false),
                    LinkAnh = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coffe", x => x.MaSanPham);
                    table.ForeignKey(
                        name: "FK_Coffe_Loai_MaLoai",
                        column: x => x.MaLoai,
                        principalTable: "Loai",
                        principalColumn: "MaLoai",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHD",
                columns: table => new
                {
                    MaChiTietHD = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MaSanPham = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    SoLuongMua = table.Column<long>(type: "INTEGER", nullable: true),
                    MaHD = table.Column<long>(type: "INTEGER", nullable: false),
                    DaMua = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHD", x => x.MaChiTietHD);
                    table.ForeignKey(
                        name: "FK_ChiTietHD_Coffe_MaSanPham",
                        column: x => x.MaSanPham,
                        principalTable: "Coffe",
                        principalColumn: "MaSanPham",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHD_HoaDon_MaHD",
                        column: x => x.MaHD,
                        principalTable: "HoaDon",
                        principalColumn: "MaHD",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Loai",
                columns: new[] { "MaLoai", "TenLoai" },
                values: new object[,]
                {
                    { "COFFE01", "Cà phê phin giấy" },
                    { "COFFE02", "Cà phê Rang xay" }
                });

            migrationBuilder.InsertData(
                table: "Coffe",
                columns: new[] { "MaSanPham", "Gia", "LinkAnh", "MaLoai", "MoTa", "SoLuong", "TenSanPHam", "XuatXu" },
                values: new object[,]
                {
                    { "CS00001", 125000L, "image_product/CS00001.jpg", "COFFE01", "Cà phê phin lọc giấy con sóc đen, hộp đôi 20 phin lọc giấy + 20 đường que Khối lượng tịnh: 200gr Cafe + 120gr đường", 100L, "CÀ PHÊ CON SÓC ĐEN (HỘP ĐÔI)", "Doanh Nghiệp TNX Trường Sơn" },
                    { "CS00002", 158000L, "image_product/CS00002.jpg", "COFFE01", "CÀ PHÊ CON SÓC NÂU BỘT HỘP 500 gram 99,99% Arabica và Hazelut tổng hợp Khối lượng tịnh: 500gr Dạng thành phẩm: bao nhôm màu đen. Đặc tính: hạt cà phê nhỏ, mịn, màu nâu, mùi thơm nồng, vị nhẹ. Chỉ tiêu chất lượng: Độ ẩm <= 5% Chất tan trong nước >= 25% Cafein >= 1 %", 100L, "CÀ PHÊ CON SÓC NÂU BỘT HỘP 500 GR", "TNX CN Trường Sơn" },
                    { "CS00003", 125000L, "image_product/CS00003.jpg", "COFFE01", "Cà Phê Con Sóc Nâu Hộp Đôi có hương vị cân bằng giữa đậm đà và hương thơm thanh,dịu với thành phần: Arabica 49,95% Robusta 49,95% Hương hazelut tổng hợp 0,01% 20 phin lọc giấy + 20 đường que Khối lượng tịnh: 200gr Cafe + 120gr đường Sản phẩm phù hợp để làm quà biếu tặng", 100L, "Cà Phê Con Sóc Nâu Hộp Đôi", "Doanh Nghiệp TNX Trường Sơn" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHD_MaHD",
                table: "ChiTietHD",
                column: "MaHD");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHD_MaSanPham",
                table: "ChiTietHD",
                column: "MaSanPham");

            migrationBuilder.CreateIndex(
                name: "IX_Coffe_MaLoai",
                table: "Coffe",
                column: "MaLoai");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaKH",
                table: "HoaDon",
                column: "MaKH");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietHD");

            migrationBuilder.DropTable(
                name: "UserAdmin");

            migrationBuilder.DropTable(
                name: "Coffe");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "Loai");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
