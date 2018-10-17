using FogGerenciadorDeVendas.Dominio.Vendas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace FogGerenciadorDeVendas.Dados.Contexto.Mapeamentos
{
    public class VendaMapping : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.HasKey(v => v.Id);

            builder.Property(v => v.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(v => v.ValorTotal)
                .IsRequired();

            builder.Property(v => v.PorcentagemDeDesconto);

            builder.Property(v => v.ValorComDesconto)
                .IsRequired();

            builder.Property(v => v.DataDaVenda)
                .IsRequired();

            builder.Property(v => v.ConsumoId)
                .IsRequired();

            builder.HasOne(v => v.Consumo);


            builder.ToTable(nameof(Venda));
        }
    }
}
