using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoLong_API.Migrations
{
    public partial class AddHotlineForTableTruongHoc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Hotline",
                table: "TruongMua",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hotline",
                table: "TruongMua");
        }
    }
}
