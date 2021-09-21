using CsjSistemas.LocaisReciclagem.Core.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CsjSistemas.LocaisReciclagem.Domain.Interfaces
{
    public interface IRepositoryLocalisReciclagem : IRepository<Entity.LocaisReciclagem>
    {
        Task<IEnumerable<Entity.LocaisReciclagem>> ObterTodos();
        Task<Entity.LocaisReciclagem> ObterPorId(Int64 id);
        void Adicionar(Entity.LocaisReciclagem produto);
        Task Atualizar(Entity.LocaisReciclagem produto);
        Task Excluir(Int64 id);
    }
}
