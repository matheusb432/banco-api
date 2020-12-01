using SistemaBanco.Domain;
using SistemaBanco.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAPI.Application.Repositories.ModelRepos
{
    public class FuncionariosRepo : EFCoreRepo<Funcionario, BancoContext>
    {
        public FuncionariosRepo(BancoContext context) : base(context)  { }
    }
}
