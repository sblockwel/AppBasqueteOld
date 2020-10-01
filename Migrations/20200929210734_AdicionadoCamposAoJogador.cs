using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AppBasquete.Migrations
{
    public partial class AdicionadoCamposAoJogador : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNasc",
                table: "Jogadores",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "NumCamisa",
                table: "Jogadores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sexo",
                table: "Jogadores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tecnico",
                table: "Jogadores",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "Jogadores",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNasc",
                table: "Jogadores");

            migrationBuilder.DropColumn(
                name: "NumCamisa",
                table: "Jogadores");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Jogadores");

            migrationBuilder.DropColumn(
                name: "Tecnico",
                table: "Jogadores");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "Jogadores");
        }
    }
}
