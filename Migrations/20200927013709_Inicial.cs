using Microsoft.EntityFrameworkCore.Migrations;

namespace AppBasquete.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jogos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Placar = table.Column<int>(nullable: false),
                    MinimoTemporada = table.Column<int>(nullable: false),
                    MaximoTemporada = table.Column<int>(nullable: false),
                    QuebraRecordeMinimo = table.Column<int>(nullable: false),
                    QuebraRecordeMaximo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jogos");
        }
    }
}
