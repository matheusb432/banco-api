using AutoMapper;
using SistemaBanco.Api.DTOs;
using SistemaBanco.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco.Api.Profiles
{
    public class AfiliadosProfile : Profile
    {
        public AfiliadosProfile()
        {
            CreateMap<Afiliado, AfiliadoReadDTO>();
        }
    }
}
