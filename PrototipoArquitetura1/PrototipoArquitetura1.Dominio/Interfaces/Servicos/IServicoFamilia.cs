using PrototipoArquitetura1.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoArquitetura1.Dominio.Interfaces.Servicos
{
    public interface IServicoFamilia : IServicoBase
    {
        void Adicionar(Familia familia);
    }
}
