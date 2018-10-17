using FogGerenciadorDeVendas.Dominio.Lancamentos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FogGerenciadorDeVendas.Dados.Contexto.Mapeamentos
{
    public class LancamentoMapping : IEntityTypeConfiguration<Lancamento>
    {
        public void Configure(EntityTypeBuilder<Lancamento> builder)
        {
            builder.HasKey(l => l.Id);

            builder.Property(l => l.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder.Property(l => l.CodigoDaComanda)
                .HasMaxLength(25)
                .IsRequired();

            builder.Property(l => l.DataDeLancamento)
                .IsRequired();

            builder.Property(l => l.ConsumoId)
                .IsRequired();

            builder.Property(l => l.ProdutoId)
                .IsRequired();

            builder.HasOne(l => l.Produto);

            builder.HasOne(l => l.Consumo);

            builder.ToTable(nameof(Lancamento));


        }
    }
}
