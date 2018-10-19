using FogGerenciadorDeVendas.Dominio.Produtos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FogGerenciadorDeVendas.Dados.Contexto.Mapeamentos
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(p => p.Nome)
                .HasMaxLength(250)
                .IsRequired();

            builder.Property(p => p.Descricao)
                .HasMaxLength(500);

            builder.Property(p => p.Situacao)
                .IsRequired();

            builder.Property(p => p.Valor)
                .HasColumnType("decimal(16,3)")
                .IsRequired();

            builder.ToTable(nameof(Produto));
        }
    }
}
