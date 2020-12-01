﻿using SistemaBanco.Domain;
using SistemaBanco.Infra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoAPI.Application.Repositories.ModelRepos
{
    public class CorretorasRepo : EFCoreRepo<Corretora, BancoContext>
    {
        public CorretorasRepo(BancoContext context) : base(context) {  }
    }
}
