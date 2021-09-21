using CsjSistemas.LocaisReciclagem.Core.Data;
using CsjSistemas.LocaisReciclagem.Data.Context;
using CsjSistemas.LocaisReciclagem.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CsjSistemas.LocaisReciclagem.Data.Repository
{
    public class LocaisReciclagemRepository : IRepositoryLocalisReciclagem
    {
        public readonly LocaisReciclagemContext _context;
        public LocaisReciclagemRepository(LocaisReciclagemContext context)
        {
            _context = context;
        }
        public IUnitOfWork UnitOfWork => _context;

        public void Adicionar(Domain.Entity.LocaisReciclagem locaisReciclagem)
        {
            _context.LocaisReciclagem.Add(locaisReciclagem);
        }

        public async Task Atualizar(Domain.Entity.LocaisReciclagem locaisReciclagem)
        {
            await Task.FromResult(_context.LocaisReciclagem.Update(locaisReciclagem));
        }

        public void Dispose()
        {
            _context?.Dispose();
        }

        public async Task Excluir(Int64 id)
        {
            var local = await _context.LocaisReciclagem.FindAsync(id);
            _context.Entry(local).State = EntityState.Detached;

            await Task.FromResult(_context.LocaisReciclagem.Remove(local));
        }

        public async Task<Domain.Entity.LocaisReciclagem> ObterPorId(Int64 id)
        {
            return await _context.LocaisReciclagem.FindAsync(id);
        }

        public async Task<IEnumerable<Domain.Entity.LocaisReciclagem>> ObterTodos()
        {
            return await _context.LocaisReciclagem.AsNoTracking().ToListAsync();
        }
    }
}
