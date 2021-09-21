using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CsjSistemas.LocaisReciclagem.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
