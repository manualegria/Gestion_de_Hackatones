using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hackatones.API.Migrations
{
    /// <inheritdoc />
    public partial class clear : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamAwards_TeamAwards_TeamAwardId",
                table: "TeamAwards");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamMentors_TeamAwards_TeamAwardId",
                table: "TeamMentors");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamParticipants_TeamAwards_TeamAwardId",
                table: "TeamParticipants");

            migrationBuilder.DropIndex(
                name: "IX_TeamParticipants_TeamAwardId",
                table: "TeamParticipants");

            migrationBuilder.DropIndex(
                name: "IX_TeamMentors_TeamAwardId",
                table: "TeamMentors");

            migrationBuilder.DropIndex(
                name: "IX_TeamAwards_TeamAwardId",
                table: "TeamAwards");

            migrationBuilder.DropColumn(
                name: "TeamAwardId",
                table: "TeamParticipants");

            migrationBuilder.DropColumn(
                name: "TeamAwardId",
                table: "TeamMentors");

            migrationBuilder.DropColumn(
                name: "TeamAwardId",
                table: "TeamAwards");

            migrationBuilder.AddColumn<int>(
                name: "MentorId",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_MentorId",
                table: "Teams",
                column: "MentorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Mentors_MentorId",
                table: "Teams",
                column: "MentorId",
                principalTable: "Mentors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Mentors_MentorId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_MentorId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "MentorId",
                table: "Teams");

            migrationBuilder.AddColumn<int>(
                name: "TeamAwardId",
                table: "TeamParticipants",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeamAwardId",
                table: "TeamMentors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeamAwardId",
                table: "TeamAwards",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TeamParticipants_TeamAwardId",
                table: "TeamParticipants",
                column: "TeamAwardId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamMentors_TeamAwardId",
                table: "TeamMentors",
                column: "TeamAwardId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamAwards_TeamAwardId",
                table: "TeamAwards",
                column: "TeamAwardId");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamAwards_TeamAwards_TeamAwardId",
                table: "TeamAwards",
                column: "TeamAwardId",
                principalTable: "TeamAwards",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamMentors_TeamAwards_TeamAwardId",
                table: "TeamMentors",
                column: "TeamAwardId",
                principalTable: "TeamAwards",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamParticipants_TeamAwards_TeamAwardId",
                table: "TeamParticipants",
                column: "TeamAwardId",
                principalTable: "TeamAwards",
                principalColumn: "Id");
        }
    }
}
