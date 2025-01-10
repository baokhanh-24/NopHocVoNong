using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoLong_API.Migrations
{
    public partial class RemoveLopOfTableSinhVien : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lop",
                table: "Sinh vien truong mua");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Lop",
                table: "Sinh vien truong mua",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
