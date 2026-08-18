using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScoutSport.Migrations
{
    /// <inheritdoc />
    public partial class CriarBaseDadosScoutSport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Avaliacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ObservacaoId = table.Column<int>(type: "int", nullable: false),
                    Tecnica = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Velocidade = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    InteligenciaTatica = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Fisico = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Atitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Potencial = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NotaFinal = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avaliacoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clubes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Jogadores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubeId = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Nacionalidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Posicao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Altura = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Peso = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jogadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Observacoes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JogadorId = table.Column<int>(type: "int", nullable: false),
                    DataObservacao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Adversario = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Competicao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PosicaoObservada = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comentario = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Observacoes", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Avaliacoes");

            migrationBuilder.DropTable(
                name: "Clubes");

            migrationBuilder.DropTable(
                name: "Jogadores");

            migrationBuilder.DropTable(
                name: "Observacoes");
        }
    }
}
