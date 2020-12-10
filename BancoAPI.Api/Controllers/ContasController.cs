﻿using BancoAPI.Application.Logger;
using BancoAPI.Application.Repositories.ModelRepos;
using Microsoft.AspNetCore.Mvc;
using SistemaBanco.Domain;

namespace SistemaBanco.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContasController : ApiController<Conta, ContasRepo>
    {
        public ContasController(ContasRepo repository, ILoggerManager logger) : base(repository, logger)
        {
        }
    }
}