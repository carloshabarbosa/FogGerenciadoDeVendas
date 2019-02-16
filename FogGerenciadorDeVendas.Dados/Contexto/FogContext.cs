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
        public FogContext(): base() { }

        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Consumo> Consumos{ get; set; }
        public DbSet<Lancamento> Lancamentos { get; set; }
        public DbSet<VendaProdutos> VendasProdutos{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"Server=localhost;Database=FogDb;Uid=root;Pwd=@leca2119;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProdutoMapping());
            modelBuilder.ApplyConfiguration(new VendaMapping());
            modelBuilder.ApplyConfiguration(new ConsumoMapping());
            modelBuilder.ApplyConfiguration(new LancamentoMapping());
            modelBuilder.ApplyConfiguration(new ProdutoMapping());
            modelBuilder.ApplyConfiguration(new VendaProdutosMapping());
        }

    }
}
