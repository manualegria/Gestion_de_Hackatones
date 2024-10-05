using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hackatones.API.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Teams_TeamsId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_TeamsId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "TeamsId",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "TemsId",
                table: "Projects",
                newName: "TeamId");

            migrationBuilder.CreateTable(
                name: "HackatonTeams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HackatonId = table.Column<int>(type: "int", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HackatonTeams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HackatonTeams_Hackatons_HackatonId",
                        column: x => x.HackatonId,
                        principalTable: "Hackatons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HackatonTeams_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_TeamId",
                table: "Projects",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_HackatonTeams_HackatonId",
                table: "HackatonTeams",
                column: "HackatonId");

            migrationBuilder.CreateIndex(
                name: "IX_HackatonTeams_TeamId",
                table: "HackatonTeams",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Teams_TeamId",
                table: "Projects",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Teams_TeamId",
                table: "Projects");

            migrationBuilder.DropTable(
                name: "HackatonTeams");

            migrationBuilder.DropIndex(
                name: "IX_Projects_TeamId",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "Projects",
                newName: "TemsId");

            migrationBuilder.AddColumn<int>(
                name: "TeamsId",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_TeamsId",
                table: "Projects",
                column: "TeamsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Teams_TeamsId",
                table: "Projects",
                column: "TeamsId",
                principalTable: "Teams",
                principalColumn: "Id");
        }
    }
}
