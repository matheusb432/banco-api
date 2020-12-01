using AutoMapper;
using SistemaBanco.Api.DTOs;
using SistemaBanco.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco.Api.Profiles
{
    public class ContasProfile : Profile
    {
        public ContasProfile()
        {
            CreateMap<Conta, ContaReadDTO>();
        }
    }
}
