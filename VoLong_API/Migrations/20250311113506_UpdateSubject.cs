using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VoLong_API.Migrations
{
    public partial class UpdateSubject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FifteenMinutesPoint",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "OralTestScores",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "ScoreOnePeriod",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "SemesterExamScore",
                table: "Subject");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "FifteenMinutesPoint",
                table: "Subject",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "OralTestScores",
                table: "Subject",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "ScoreOnePeriod",
                table: "Subject",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SemesterExamScore",
                table: "Subject",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
