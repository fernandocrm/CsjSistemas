using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CsjSistemas.LocaisReciclagem.API.DTO;
using CsjSistemas.LocaisReciclagem.Domain;

namespace CsjSistemas.LocaisReciclagem.API.AutoMapper
{
    public class DTOToDomain : Profile
    {
        public DTOToDomain()
        {
            CreateMap<LocaisReciclagemDTO, Domain.Entity.LocaisReciclagem>();
        }
    }
}
