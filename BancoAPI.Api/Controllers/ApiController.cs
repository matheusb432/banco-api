﻿using BancoAPI.Application.Logger;
using BancoAPI.Application.Repositories;
using Microsoft.AspNetCore.Mvc;
using SistemaBanco.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SistemaBanco.Api.Controllers
{
    /// <summary>
    /// ApiController implementa o padrão de design Repository Pattern, remove a acoplação entra a camada da API com a da infraestrutura.
    /// </summary>
    /// <typeparam name="TEntity">Entidade do BD genérica, pode representar qualquer uma conforme a necessidade</typeparam>
    /// <typeparam name="TRepository">Interface do repositório, fornece uma abstração das funcionalidades da base de dados</typeparam>
    [ApiController]
    public abstract class ApiController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository _repository;
        private readonly ILoggerManager _logger;

        public ApiController(TRepository repository)
        {
            _repository = repository;
        }

        public ApiController(TRepository repository, ILoggerManager logger)
        {
            _repository = repository;
            _logger = logger;
        }

        // GET api/controller
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> GetAll()
        {
            _logger.LogInfo("Get All called");

            return Ok(await _repository.GetAll());
        }

        // GET: api/[controller]/5
        [HttpGet("{id}"/*, Name = "Get"*/)]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var entity = await _repository.Get(id);

            if (entity is null) return NotFound();

            return entity;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity entity)
        {
            if (id != entity.Id)
            {
                return BadRequest();
            }

            await _repository.Update(entity);

            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity entity)
        {
            await _repository.Post(entity);

            return CreatedAtAction("Get", new { id = entity.Id }, entity);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var entity = await _repository.Delete(id);

            if (entity is null) return NotFound();

            return entity;
        }
    }
}