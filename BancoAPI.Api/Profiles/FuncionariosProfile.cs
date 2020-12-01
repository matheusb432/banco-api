using AutoMapper;
using SistemaBanco.Api.DTOs;
using SistemaBanco.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco.Api.Profiles
{
    public class FuncionariosProfile : Profile
    {
        public FuncionariosProfile()
        {
            CreateMap<Funcionario, FuncionarioReadDTO>();
        }
    }
}
