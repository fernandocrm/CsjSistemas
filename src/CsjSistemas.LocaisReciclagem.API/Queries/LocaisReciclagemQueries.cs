using AutoMapper;
using CsjSistemas.LocaisReciclagem.API.DTO;
using CsjSistemas.LocaisReciclagem.API.Queries.Interface;
using CsjSistemas.LocaisReciclagem.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CsjSistemas.LocaisReciclagem.API.Queries
{
    public class LocaisReciclagemQueries : ILocaisReciclagemQueries
    {
        private readonly IRepositoryLocalisReciclagem _repository;
        private readonly IMapper _mapper;

        public LocaisReciclagemQueries(IRepositoryLocalisReciclagem repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Adicionar(LocaisReciclagemDTO local)
        {
            _repository.Adicionar(_mapper.Map<Domain.Entity.LocaisReciclagem>(local));
            _repository.UnitOfWork.Commit();
        }

        public async Task Atualizar(LocaisReciclagemDTO local)
        {
            await _repository.Atualizar(_mapper.Map<Domain.Entity.LocaisReciclagem>(local));
            await _repository.UnitOfWork.Commit();
        }

        public async Task Excluir(Int64 id)
        {
            await _repository.Excluir(id);
            await _repository.UnitOfWork.Commit();
        }

        public async Task<LocaisReciclagemDTO> ObterPorId(long id)
        {
            return _mapper.Map<LocaisReciclagemDTO>(await _repository.ObterPorId(id));
        }

        public async Task<IEnumerable<LocaisReciclagemDTO>> ObterTodos()
        {
            try
            {
                return _mapper.Map<IEnumerable<LocaisReciclagemDTO>>(await _repository.ObterTodos());
            }
            catch (Exception e)
            {
                var erro = e.Message;
                throw;
            }
        }
    }
}
