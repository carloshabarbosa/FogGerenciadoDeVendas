using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace FogGerenciadorDeVendas.Dados.Contexto
{
    public class ContextFactory : IDesignTimeDbContextFactory<FogContext>
    {
        public FogContext CreateDbContext(string[] args)
        {
            return new FogContext();
        }
    }
}
