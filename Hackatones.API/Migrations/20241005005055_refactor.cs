using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hackatones.API.Migrations
{
    /// <inheritdoc />
    public partial class refactor : Migration
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
                name: "TeamsId",
                table: "Hackatons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Hackatons_TeamsId",
                table: "Hackatons",
                column: "TeamsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hackatons_Teams_TeamsId",
                table: "Hackatons",
                column: "TeamsId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hackatons_Teams_TeamsId",
                table: "Hackatons");

            migrationBuilder.DropIndex(
                name: "IX_Hackatons_TeamsId",
                table: "Hackatons");

            migrationBuilder.DropColumn(
                name: "TeamsId",
                table: "Hackatons");

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
