using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoLong_API.Migrations
{
    public partial class AddKeySinhVienSubject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ScoreOnePeriod = table.Column<double>(type: "float", nullable: false),
                    FifteenMinutesPoint = table.Column<double>(type: "float", nullable: false),
                    OralTestScores = table.Column<double>(type: "float", nullable: false),
                    SemesterExamScore = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SinhVienSubject",
                columns: table => new
                {
                    SinhVienId = table.Column<int>(type: "int", nullable: false),
                    SubjectId = table.Column<int>(type: "int", nullable: false),
                    ScoreOnePeriod = table.Column<double>(type: "float", nullable: false),
                    FifteenMinutesPoint = table.Column<double>(type: "float", nullable: false),
                    OralTestScores = table.Column<double>(type: "float", nullable: false),
                    SemesterExamScore = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SinhVienSubject", x => new { x.SinhVienId, x.SubjectId });
                    table.ForeignKey(
                        name: "FK_SinhVienSubject_SinhVienTruongMua_SinhVienId",
                        column: x => x.SinhVienId,
                        principalTable: "SinhVienTruongMua",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SinhVienSubject_Subject_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subject",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SinhVienSubject_SubjectId",
                table: "SinhVienSubject",
                column: "SubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SinhVienSubject");

            migrationBuilder.DropTable(
                name: "Subject");
        }
    }
}
