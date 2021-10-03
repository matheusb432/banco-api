using BancoAPI.Application.Logger;
using BancoAPI.Application.Repositories.ModelRepos;
using Microsoft.AspNetCore.Mvc;
using SistemaBanco.Domain;

namespace SistemaBanco.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CorretorasController : ApiController<Corretora, CorretorasRepo>
    {
        public CorretorasController(CorretorasRepo repository, ILoggerManager logger) : base(repository, logger)
        {
        }
    }
}