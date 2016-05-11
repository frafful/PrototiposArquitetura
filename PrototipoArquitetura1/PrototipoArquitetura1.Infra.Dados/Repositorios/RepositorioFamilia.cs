using PrototipoArquitetura1.Dominio.Entidades;
using PrototipoArquitetura1.Dominio.Interfaces;
using PrototipoArquitetura1.Dominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoArquitetura1.Infra.Dados.Repositorios
{
    public class RepositorioFamilia : RepositorioBase<Familia>, IRepositorioFamilia
    {
        public RepositorioFamilia(IUnidadeDeTrabalho unidadeDeTrabalho)
        {
            UnidadeDeTrabalho = unidadeDeTrabalho;
        }
    }
}
