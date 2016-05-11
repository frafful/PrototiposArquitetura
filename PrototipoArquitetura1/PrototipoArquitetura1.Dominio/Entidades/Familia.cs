using PrototipoArquitetura1.Dominio.Abstratos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoArquitetura1.Dominio.Entidades
{
    public class Familia : EntidadeBase
    {
        public virtual string Nome { get; set; }
    }
}
