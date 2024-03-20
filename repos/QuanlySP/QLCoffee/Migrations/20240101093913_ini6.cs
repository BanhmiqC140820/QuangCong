using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLCoffee.Migrations
{
    /// <inheritdoc />
    public partial class ini6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "TongTien",
                table: "HoaDon",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TongTien",
                table: "HoaDon");
        }
    }
}
