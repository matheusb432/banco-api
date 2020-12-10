using AutoMapper;
using SistemaBanco.Api.DTOs;
using SistemaBanco.Domain;

namespace SistemaBanco.Api.Profiles
{
    public class CorretoraProfile : Profile
    {
        public CorretoraProfile()
        {
            CreateMap<Corretora, CorretoraReadDTO>();
        }
    }
}