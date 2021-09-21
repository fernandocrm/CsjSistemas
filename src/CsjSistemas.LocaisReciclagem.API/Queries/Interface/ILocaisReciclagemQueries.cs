using CsjSistemas.LocaisReciclagem.API.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CsjSistemas.LocaisReciclagem.API.Queries.Interface
{
    public interface ILocaisReciclagemQueries
    {
        Task<IEnumerable<LocaisReciclagemDTO>> ObterTodos();
        Task<LocaisReciclagemDTO> ObterPorId(Int64 id);
        void Adicionar(LocaisReciclagemDTO produto);
        Task Atualizar(LocaisReciclagemDTO produto);
        Task Excluir(Int64 id);
    }
}
