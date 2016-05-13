using AutoMapper;
using PrototipoArquitetura1.Aplicacao.ViewModels;
using PrototipoArquitetura1.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoArquitetura1.Aplicacao.AutoMapper
{
    public class DominioParaViewModelPerfilMapeamento : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<Familia, FamiliaViewModel>();
        }
    }
}
