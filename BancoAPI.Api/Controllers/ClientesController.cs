using AutoMapper;
using BancoAPI.Application.Repositories.ModelRepos;
using MessageService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaBanco.Api.DTOs;
using SistemaBanco.Api.MessageService;
using SistemaBanco.Domain;
using SistemaBanco.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace SistemaBanco.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ApiController<Cliente, ClientesRepo>
    {
        public ClientesController(ClientesRepo repository) : base(repository) { }
    }
}
