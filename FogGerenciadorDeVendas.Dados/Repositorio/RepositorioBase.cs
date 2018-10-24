using FogGerenciadorDeVendas.Dados.Contexto;
using FogGerenciadorDeVendas.Dominio.Repositorio;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FogGerenciadorDeVendas.Dados.Repositorio

{
    public class RepositorioBase<TId, TEntity> : IRepositorio<TId, TEntity> where TId : struct where TEntity : class 
    {
        private readonly DbSet<TEntity> _dbSet;
        private readonly FogContext _context;

        public RepositorioBase(FogContext context)
        {
            _dbSet = context.Set<TEntity>();
            _context = context;
        }


        public virtual void Adicionar(TEntity item)
        {
            _dbSet.Add(item);
            _context.SaveChanges();
        }


        public virtual void Remover(TEntity item)
        {
            _dbSet.Remove(item);
            _context.SaveChanges();
        }

        public virtual TEntity ObtemPorId(TId id)
        {
            return _dbSet.Find(id);
        }


        public virtual IQueryable<TEntity> Buscar()
        {
            return _dbSet;
        }

        public void Salvar()
        {
            _context.SaveChanges();
        }
    }
}
