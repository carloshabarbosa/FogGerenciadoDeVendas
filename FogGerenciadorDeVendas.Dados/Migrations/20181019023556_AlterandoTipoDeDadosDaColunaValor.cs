using Microsoft.EntityFrameworkCore.Migrations;

namespace FogGerenciadorDeVendas.Dados.Migrations
{
    public partial class AlterandoTipoDeDadosDaColunaValor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "Produto",
                type: "decimal(16,3)",
                nullable: false,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Valor",
                table: "Produto",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(16,3)");
        }
    }
}
