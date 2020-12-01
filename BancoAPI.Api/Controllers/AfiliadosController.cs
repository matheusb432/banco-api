using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BancoAPI.Application.Repositories.ModelRepos;
using MessageService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaBanco.Api.DTOs;
using SistemaBanco.Domain;
using SistemaBanco.Infra;

namespace SistemaBanco.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AfiliadosController : ApiController<Afiliado, AfiliadosRepo>
    {
        public AfiliadosController(AfiliadosRepo repository) : base(repository) { }
    }
}
