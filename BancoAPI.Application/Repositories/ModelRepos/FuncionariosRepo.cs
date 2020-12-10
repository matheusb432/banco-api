using SistemaBanco.Domain;
using SistemaBanco.Infra;

namespace BancoAPI.Application.Repositories.ModelRepos
{
    public class FuncionariosRepo : EFCoreRepo<Funcionario, BancoContext>
    {
        public FuncionariosRepo(BancoContext context) : base(context)
        {
        }
    }
}