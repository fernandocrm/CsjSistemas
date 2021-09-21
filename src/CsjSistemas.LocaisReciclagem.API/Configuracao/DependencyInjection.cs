using CsjSistemas.LocaisReciclagem.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using CsjSistemas.LocaisReciclagem.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsjSistemas.LocaisReciclagem.API.Queries.Interface;
using CsjSistemas.LocaisReciclagem.API.Queries;

namespace CsjSistemas.LocaisReciclagem.API.Configuracao
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryLocalisReciclagem, LocaisReciclagemRepository>();
            services.AddScoped<ILocaisReciclagemQueries, LocaisReciclagemQueries>();
        }
    }
}
