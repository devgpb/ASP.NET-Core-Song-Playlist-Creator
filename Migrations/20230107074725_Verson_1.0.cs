using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicPlaylist.Migrations
{
    public partial class Verson_10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Generos",
                columns: table => new
                {
                    Nome = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.Nome);
                });

            migrationBuilder.CreateTable(
                name: "Moods",
                columns: table => new
                {
                    Nome = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moods", x => x.Nome);
                });

            migrationBuilder.CreateTable(
                name: "Musicas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Autor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MoodNome = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GeneroNome = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musicas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Musicas_Generos_GeneroNome",
                        column: x => x.GeneroNome,
                        principalTable: "Generos",
                        principalColumn: "Nome",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Musicas_Moods_MoodNome",
                        column: x => x.MoodNome,
                        principalTable: "Moods",
                        principalColumn: "Nome",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Musicas_GeneroNome",
                table: "Musicas",
                column: "GeneroNome");

            migrationBuilder.CreateIndex(
                name: "IX_Musicas_MoodNome",
                table: "Musicas",
                column: "MoodNome");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Musicas");

            migrationBuilder.DropTable(
                name: "Generos");

            migrationBuilder.DropTable(
                name: "Moods");
        }
    }
}
