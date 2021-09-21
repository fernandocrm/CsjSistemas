using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CsjSistemas.LocaisReciclagem.API.DTO;

namespace CsjSistemas.LocaisReciclagem.API.AutoMapper
{
    public class DomainToDTO : Profile
    {
        public DomainToDTO()
        {
            CreateMap<Domain.Entity.LocaisReciclagem, LocaisReciclagemDTO>();
        }
    }
}
