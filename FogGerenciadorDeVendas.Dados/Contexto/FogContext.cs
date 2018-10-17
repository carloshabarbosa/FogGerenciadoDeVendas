using FogGerenciadorDeVendas.Dados.Contexto.Mapeamentos;
using FogGerenciadorDeVendas.Dominio.Consumos;
using FogGerenciadorDeVendas.Dominio.Lancamentos;
using FogGerenciadorDeVendas.Dominio.Produtos;
using FogGerenciadorDeVendas.Dominio.Vendas;
using Microsoft.EntityFrameworkCore;

namespace FogGerenciadorDeVendas.Dados.Contexto
{
    public class FogContext : DbContext
    {
        protected FogContext(DbContextOptions<FogContext> options): base(options) { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Consumo> Consumos{ get; set; }
        public DbSet<Lancamento> Lancamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProdutoMapping());
            modelBuilder.ApplyConfiguration(new VendaMapping());
            modelBuilder.ApplyConfiguration(new ConsumoMapping());
            modelBuilder.ApplyConfiguration(new LancamentoMapping());
            modelBuilder.ApplyConfiguration(new ProdutoMapping());

        }
    }
}
