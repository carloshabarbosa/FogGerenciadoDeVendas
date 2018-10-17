using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FogGerenciadorDeVendas.Dados
{
    public class RepositorioBase<TId, TEntity> where TId : struct where TEntity : class
    {
        private readonly DbSet<TEntity> _dbSet;

        public RepositorioBase(DbContext context)
        {
            _dbSet = context.Set<TEntity>();
        }

        public virtual void Adicionar(TEntity item)
        {
            _dbSet.Add(item);
        }


        public virtual void Remover(TEntity item)
        {
            _dbSet.Remove(item);
        }

        public virtual TEntity ObtemPorId(TId id)
        {
            return _dbSet.Find(id);
        }


        public virtual IQueryable<TEntity> Buscar()
        {
            return _dbSet;
        }
    }
}
