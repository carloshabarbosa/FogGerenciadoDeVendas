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

            builder.Property(p => p.DataDeCadastro)
                .IsRequired();

            builder.Property(p => p.EmiteNota);

            builder.Property(p => p.Ncm);

            builder.Property(p => p.Cfop);

            builder.Property(p => p.UnidadeComercial);

            builder.Property(p => p.QuantidadeComercial)
                .HasColumnType("decimal(16,3)");

            builder.Property(p => p.ValorUnitarioComercializacao)
                .HasColumnType("decimal(16,3)");

            builder.Property(p => p.ValorDoProduto)
                .HasColumnType("decimal(16,3)");

            builder.Property(p => p.ValorDoDesconto)
                .HasColumnType("decimal(16,3)");

            builder.Property(p => p.UnidadeTributavel);

            builder.Property(p => p.QuantidadeTributavel)
                .HasColumnType("decimal(16,3)");

            builder.Property(p => p.ValorUnitarioTributacao)
                .HasColumnType("decimal(16,3)");

            builder.ToTable(nameof(Produto));
        }
    }
}
