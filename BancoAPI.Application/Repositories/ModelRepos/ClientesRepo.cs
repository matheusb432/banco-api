using Microsoft.EntityFrameworkCore;
using SistemaBanco.Domain;
using SistemaBanco.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAPI.Application.Repositories.ModelRepos
{
    public class ClientesRepo : EFCoreRepo<Cliente, BancoContext>
    {
        public ClientesRepo(BancoContext context) : base(context) { }

        // Como todos os métodos da classe abstrata EFCoreRepo<> são virtuais, é possível sobrescrever o GetAll() com qualquer especificação desejada
        // conforme a necessidade, deixando a aplicação pouco acoplada e facilitando alterações nas suas funcionalidades
        public async override Task<IEnumerable<Cliente>> GetAll()
        {
            return await _context.Clientes.Include(x => x.Contas).ToListAsync();
        }
    }
}
