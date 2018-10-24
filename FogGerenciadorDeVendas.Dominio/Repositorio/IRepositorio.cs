using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FogGerenciadorDeVendas.Dominio.Repositorio
{
    public interface IRepositorio<TId, TEntity>
    {
        void Adicionar(TEntity item);
        void Remover(TEntity item);
        void Salvar();
        TEntity ObtemPorId(TId id);
        IQueryable<TEntity> Buscar();
    }
}
