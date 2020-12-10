using SistemaBanco.Domain;
using SistemaBanco.Infra;

namespace BancoAPI.Application.Repositories.ModelRepos
{
    public class ContasRepo : EFCoreRepo<Conta, BancoContext>
    {
        public ContasRepo(BancoContext context) : base(context)
        {
        }
    }
}