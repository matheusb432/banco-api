using AutoMapper;
using SistemaBanco.Api.DTOs;
using SistemaBanco.Domain;

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