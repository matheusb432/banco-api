using AutoMapper;
using SistemaBanco.Api.DTOs;
using SistemaBanco.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco.Api.Profiles
{
    public class ClientesProfile : Profile
    {
        public ClientesProfile()
        {
            CreateMap<Cliente, ClienteReadDTO>();
        }
    }
}
