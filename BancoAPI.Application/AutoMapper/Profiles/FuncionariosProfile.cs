using AutoMapper;
using SistemaBanco.Api.DTOs;
using SistemaBanco.Domain;

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