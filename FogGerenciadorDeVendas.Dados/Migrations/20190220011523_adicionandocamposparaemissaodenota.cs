using Microsoft.EntityFrameworkCore.Migrations;

namespace FogGerenciadorDeVendas.Dados.Migrations
{
    public partial class adicionandocamposparaemissaodenota : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Cfop",
                table: "Produto",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "EmiteNota",
                table: "Produto",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Ncm",
                table: "Produto",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "QuantidadeComercial",
                table: "Produto",
                type: "decimal(16,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "QuantidadeTributavel",
                table: "Produto",
                type: "decimal(16,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "UnidadeComercial",
                table: "Produto",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UnidadeTributavel",
                table: "Produto",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorDoDesconto",
                table: "Produto",
                type: "decimal(16,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorDoProduto",
                table: "Produto",
                type: "decimal(16,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorUnitarioComercializacao",
                table: "Produto",
                type: "decimal(16,3)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "ValorUnitarioTributacao",
                table: "Produto",
                type: "decimal(16,3)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Cfop",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "EmiteNota",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "Ncm",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "QuantidadeComercial",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "QuantidadeTributavel",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "UnidadeComercial",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "UnidadeTributavel",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "ValorDoDesconto",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "ValorDoProduto",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "ValorUnitarioComercializacao",
                table: "Produto");

            migrationBuilder.DropColumn(
                name: "ValorUnitarioTributacao",
                table: "Produto");
        }
    }
}
