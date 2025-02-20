using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoLong_API.Migrations
{
    public partial class abc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TruongMua",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Establish = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TruongMua", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LopMua",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    TruongHocId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopMua", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LopMua_TruongMua_TruongHocId",
                        column: x => x.TruongHocId,
                        principalTable: "TruongMua",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SinhVienTruongMua",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LopId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhVienTruongMua", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SinhVienTruongMua_LopMua_LopId",
                        column: x => x.LopId,
                        principalTable: "LopMua",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LopMua_TruongHocId",
                table: "LopMua",
                column: "TruongHocId");

            migrationBuilder.CreateIndex(
                name: "IX_SinhVienTruongMua_LopId",
                table: "SinhVienTruongMua",
                column: "LopId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinhVienTruongMua");

            migrationBuilder.DropTable(
                name: "LopMua");

            migrationBuilder.DropTable(
                name: "TruongMua");
        }
    }
}
