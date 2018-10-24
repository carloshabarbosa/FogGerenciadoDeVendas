using Microsoft.EntityFrameworkCore.Migrations;

namespace FogGerenciadorDeVendas.Dados.Migrations
{
    public partial class AlterandoERemovendoCamposDaVenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValorComDesconto",
                table: "Venda");

            migrationBuilder.AlterColumn<int>(
                name: "PorcentagemDeDesconto",
                table: "Venda",
                nullable: false,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "PorcentagemDeDesconto",
                table: "Venda",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<decimal>(
                name: "ValorComDesconto",
                table: "Venda",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
