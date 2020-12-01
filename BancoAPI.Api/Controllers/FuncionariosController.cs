using AutoMapper;
using BancoAPI.Application.Repositories;
using BancoAPI.Application.Repositories.ModelRepos;
using MessageService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaBanco.Api.DTOs;
using SistemaBanco.Domain;
using SistemaBanco.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBanco.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionariosController : ApiController<Funcionario, FuncionariosRepo>
    {
        public FuncionariosController(FuncionariosRepo repository) : base(repository) { }
    }
}
