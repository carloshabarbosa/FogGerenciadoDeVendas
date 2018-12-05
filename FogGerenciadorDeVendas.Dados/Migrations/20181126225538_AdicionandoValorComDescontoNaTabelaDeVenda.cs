using Microsoft.EntityFrameworkCore.Migrations;

namespace FogGerenciadorDeVendas.Dados.Migrations
{
    public partial class AdicionandoValorComDescontoNaTabelaDeVenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ValorComDesconto",
                table: "Venda",
                type: "decimal(16,3)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValorComDesconto",
                table: "Venda");
        }
    }
}
