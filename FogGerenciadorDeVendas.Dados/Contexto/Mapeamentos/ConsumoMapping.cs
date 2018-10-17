using FogGerenciadorDeVendas.Dominio.Consumos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FogGerenciadorDeVendas.Dados.Contexto.Mapeamentos
{
    public class ConsumoMapping : IEntityTypeConfiguration<Consumo>
    {
        public void Configure(EntityTypeBuilder<Consumo> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(c => c.Quantidade)
                .IsRequired();

            builder.Property(c => c.Situacao)
                .IsRequired();

            builder.Property(c => c.CodigoDaComanda)
                .HasMaxLength(25)
                .IsRequired();

            builder.Property(c => c.DataDeAbertura)
                .IsRequired();

            builder.Property(c => c.DataDeFechamento);

            builder.HasMany(c => c.Lancamentos)
                .WithOne(l => l.Consumo);

            builder.ToTable(nameof(Consumo));
        }
    }
}
