using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FogGerenciadorDeVendas.Dados.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Consumo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CodigoDaComanda = table.Column<string>(maxLength: 25, nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    Situacao = table.Column<int>(nullable: false),
                    DataDeAbertura = table.Column<DateTime>(nullable: false),
                    DataDeFechamento = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consumo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(maxLength: 250, nullable: false),
                    Descricao = table.Column<string>(maxLength: 500, nullable: true),
                    Valor = table.Column<decimal>(nullable: false),
                    Situacao = table.Column<bool>(nullable: false),
                    DataDeCadastro = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Venda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ConsumoId = table.Column<int>(nullable: false),
                    ValorTotal = table.Column<decimal>(nullable: false),
                    PorcentagemDeDesconto = table.Column<decimal>(nullable: false),
                    ValorComDesconto = table.Column<decimal>(nullable: false),
                    DataDaVenda = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Venda_Consumo_ConsumoId",
                        column: x => x.ConsumoId,
                        principalTable: "Consumo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lancamento",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CodigoDaComanda = table.Column<string>(maxLength: 25, nullable: false),
                    ConsumoId = table.Column<int>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false),
                    DataDeLancamento = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lancamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lancamento_Consumo_ConsumoId",
                        column: x => x.ConsumoId,
                        principalTable: "Consumo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lancamento_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lancamento_ConsumoId",
                table: "Lancamento",
                column: "ConsumoId");

            migrationBuilder.CreateIndex(
                name: "IX_Lancamento_ProdutoId",
                table: "Lancamento",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Venda_ConsumoId",
                table: "Venda",
                column: "ConsumoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lancamento");

            migrationBuilder.DropTable(
                name: "Venda");

            migrationBuilder.DropTable(
                name: "Produto");

            migrationBuilder.DropTable(
                name: "Consumo");
        }
    }
}
