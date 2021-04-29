using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TicTacToe.Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "games",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "TEXT", nullable: false),
                    player_1_name = table.Column<string>(type: "TEXT", nullable: true),
                    player_2_name = table.Column<string>(type: "TEXT", nullable: true),
                    cell_1 = table.Column<string>(type: "TEXT", nullable: true),
                    cell_2 = table.Column<string>(type: "TEXT", nullable: true),
                    cell_3 = table.Column<string>(type: "TEXT", nullable: true),
                    cell_4 = table.Column<string>(type: "TEXT", nullable: true),
                    cell_5 = table.Column<string>(type: "TEXT", nullable: true),
                    cell_6 = table.Column<string>(type: "TEXT", nullable: true),
                    cell_7 = table.Column<string>(type: "TEXT", nullable: true),
                    cell_8 = table.Column<string>(type: "TEXT", nullable: true),
                    cell_9 = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_games", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "games");
        }
    }
}
