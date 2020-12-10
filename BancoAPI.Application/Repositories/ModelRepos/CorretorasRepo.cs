using SistemaBanco.Domain;
using SistemaBanco.Infra;

namespace BancoAPI.Application.Repositories.ModelRepos
{
    public class CorretorasRepo : EFCoreRepo<Corretora, BancoContext>
    {
        public CorretorasRepo(BancoContext context) : base(context)
        {
        }
    }
}