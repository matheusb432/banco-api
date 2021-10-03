using Microsoft.EntityFrameworkCore;
using SistemaBanco.Domain;
using SistemaBanco.Infra;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BancoAPI.Application.Repositories.ModelRepos
{
    public class ClientesRepo : EFCoreRepo<Cliente, BancoContext>
    {
        public ClientesRepo(BancoContext context) : base(context)
        {
        }

        public async override Task<IEnumerable<Cliente>> GetAll()
        {
            return await _context.Clientes.Include(x => x.Contas).ToListAsync();
        }
    }
}