using SistemaBanco.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
