using AutoMapper;
using SistemaBanco.Api.DTOs;
using SistemaBanco.Domain;

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