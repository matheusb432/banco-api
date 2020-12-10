using Microsoft.EntityFrameworkCore;
using SistemaBanco.Domain;
using SistemaBanco.Infra;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BancoAPI.Application.Repositories
{
    /// <summary>
    /// EFCoreRepo implementa IRepository, e contém as especificações do contexto de dados com EF Core
    /// </summary>
    /// <typeparam name="TEntity">TEntity é a entidade em questão do contexto de dados, ser um tipo de genérico elimina a necessidade de várias
    /// sobrecargas de métodos para que essa classe acomode a todas as entidades da base de dados</typeparam>
    /// <typeparam name="TContext">TContext representa o context de dados, que no caso da implementação com o EF Core, deriva de DbContext</typeparam>
    public abstract class EFCoreRepo<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class, IEntity
        where TContext : DbContext
    {
        protected readonly BancoContext _context;

        public EFCoreRepo(BancoContext context)
        {
            _context = context;
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            // Set<TEntity>() representa qualquer DbSet<> que seja do tipo TEntity.
            return await _context.Set<TEntity>().ToListAsync();
        }

        public virtual async Task<TEntity> Get(long id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);

            if (entity is null) return null;

            return entity;
        }

        public virtual async Task<TEntity> Post(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);

            await SaveAsync();

            return entity;
        }

        public virtual async Task<TEntity> Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;

            await SaveAsync();

            return entity;
        }

        public virtual async Task<TEntity> Delete(long id)
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);

            if (entity is null) return entity;

            _context.Set<TEntity>().Remove(entity);

            await SaveAsync();

            return entity;
        }

        public virtual async Task SaveAsync()
            => await _context.SaveChangesAsync();
    }
}