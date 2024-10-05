using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hackatones.API.Migrations
{
    /// <inheritdoc />
    public partial class updateDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TeamAwards_Teams_TeamId",
                table: "TeamAwards");

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

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "TeamAwards",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TeamAwardId",
                table: "TeamAwards",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HackatonId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TeamsId",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TemsId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Projects_HackatonId",
                table: "Projects",
                column: "HackatonId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_TeamsId",
                table: "Projects",
                column: "TeamsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Hackatons_HackatonId",
                table: "Projects",
                column: "HackatonId",
                principalTable: "Hackatons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Teams_TeamsId",
                table: "Projects",
                column: "TeamsId",
                principalTable: "Teams",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamAwards_TeamAwards_TeamAwardId",
                table: "TeamAwards",
                column: "TeamAwardId",
                principalTable: "TeamAwards",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamAwards_Teams_TeamId",
                table: "TeamAwards",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Hackatons_HackatonId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Teams_TeamsId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamAwards_TeamAwards_TeamAwardId",
                table: "TeamAwards");

            migrationBuilder.DropForeignKey(
                name: "FK_TeamAwards_Teams_TeamId",
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

            migrationBuilder.DropIndex(
                name: "IX_Projects_HackatonId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_TeamsId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "TeamAwardId",
                table: "TeamParticipants");

            migrationBuilder.DropColumn(
                name: "TeamAwardId",
                table: "TeamMentors");

            migrationBuilder.DropColumn(
                name: "TeamAwardId",
                table: "TeamAwards");

            migrationBuilder.DropColumn(
                name: "HackatonId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "TeamsId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "TemsId",
                table: "Projects");

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "TeamAwards",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TeamAwards_Teams_TeamId",
                table: "TeamAwards",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id");
        }
    }
}
