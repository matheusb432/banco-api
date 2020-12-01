using AutoMapper;
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
    // [Route("api/NMD39Y0")]
    [Route("api/[controller]")]
    [ApiController]
    public class CorretorasController : ApiController<Corretora, CorretorasRepo>
    {
        public CorretorasController(CorretorasRepo repository) : base(repository) { }
    }
}
