using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace PrototipoArquitetura1.Aplicacao.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegistrarMapeamentos()
        {
            Mapper.Initialize(x =>
                {
                    x.AddProfile<DominioParaViewModelPerfilMapeamento>();
                    x.AddProfile<ViewModelParaDominioPerfilMapeamento>();
                });
        }
    }
}
