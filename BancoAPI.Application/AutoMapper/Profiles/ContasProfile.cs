﻿using AutoMapper;
using SistemaBanco.Api.DTOs;
using SistemaBanco.Domain;

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