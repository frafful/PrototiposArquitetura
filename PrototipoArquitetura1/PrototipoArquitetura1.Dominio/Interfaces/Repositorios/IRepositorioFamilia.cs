using PrototipoArquitetura1.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoArquitetura1.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioFamilia : IRepositorioBase<Familia>
    {
        Familia ObterPorNome(string nome);
    }
}
