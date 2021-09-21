using CsjSistemas.LocaisReciclagem.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace CsjSistemas.LocaisReciclagem.Core.Data
{
    public interface IRepository<T> : IDisposable where T : IAggregateRoot
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
