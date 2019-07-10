using Microsoft.EntityFrameworkCore.Migrations;

namespace CandidateInformation.Migrations
{
    public partial class Qualification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Candidate",
                table: "Candidate");

            migrationBuilder.RenameTable(
                name: "Candidate",
                newName: "Qualifications");

            migrationBuilder.AddColumn<int>(
                name: "CandidateID",
                table: "Qualifications",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Qualifications",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "qualificationName",
                table: "Qualifications",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "qualificationType",
                table: "Qualifications",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Qualifications",
                table: "Qualifications",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Qualifications_CandidateID",
                table: "Qualifications",
                column: "CandidateID");

            migrationBuilder.AddForeignKey(
                name: "FK_Qualifications_Qualifications_CandidateID",
                table: "Qualifications",
                column: "CandidateID",
                principalTable: "Qualifications",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Qualifications_Qualifications_CandidateID",
                table: "Qualifications");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Qualifications",
                table: "Qualifications");

            migrationBuilder.DropIndex(
                name: "IX_Qualifications_CandidateID",
                table: "Qualifications");

            migrationBuilder.DropColumn(
                name: "CandidateID",
                table: "Qualifications");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Qualifications");

            migrationBuilder.DropColumn(
                name: "qualificationName",
                table: "Qualifications");

            migrationBuilder.DropColumn(
                name: "qualificationType",
                table: "Qualifications");

            migrationBuilder.RenameTable(
                name: "Qualifications",
                newName: "Candidate");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Candidate",
                table: "Candidate",
                column: "ID");
        }
    }
}
