using FogGerenciadorDeVendas.Dominio.Vendas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FogGerenciadorDeVendas.Dados.Contexto.Mapeamentos
{
    public class VendaProdutosMapping : IEntityTypeConfiguration<VendaProdutos>
    {
        public void Configure(EntityTypeBuilder<VendaProdutos> builder)
        {
            builder.HasKey(v => v.Id);

            builder.Property(v => v.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(v => v.NomeProduto)
                .IsRequired();

            builder.Property(v => v.DescricaoProduto)
                .IsRequired();

            builder.Property(v => v.ValorProduto)
                .HasColumnType("decimal(16,3)")
                .IsRequired();

            builder.HasOne(v => v.Venda)
                .WithMany(v => v.VendasProdutos)
                .HasForeignKey(v => v.VendaId);

            builder.ToTable(nameof(VendaProdutos));
        }
    }
}