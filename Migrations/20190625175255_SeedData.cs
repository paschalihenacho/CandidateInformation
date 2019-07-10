using Microsoft.EntityFrameworkCore.Migrations;

namespace CandidateInformation.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "zipCode",
                table: "Candidate",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "zipCode",
                table: "Candidate",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
