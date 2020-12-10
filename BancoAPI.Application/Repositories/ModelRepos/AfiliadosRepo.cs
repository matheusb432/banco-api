using SistemaBanco.Domain;
using SistemaBanco.Infra;

namespace BancoAPI.Application.Repositories.ModelRepos
{
    public class AfiliadosRepo : EFCoreRepo<Afiliado, BancoContext>
    {
        public AfiliadosRepo(BancoContext context) : base(context)
        {
        }
    }
}