using SistemaBanco.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BancoAPI.Application.Repositories
{
    // Abstração do repositório
    public interface IRepository<T> where T : class, IEntity
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> Get(long id);

        Task<T> Post(T entity);

        Task<T> Update(T entity);

        Task<T> Delete(long id);

        Task SaveAsync();
    }
}