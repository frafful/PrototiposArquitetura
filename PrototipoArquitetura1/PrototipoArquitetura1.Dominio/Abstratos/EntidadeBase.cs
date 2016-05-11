using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoArquitetura1.Dominio.Abstratos
{
    public abstract class EntidadeBase
    {
        public virtual int Id { get; set; }
        public virtual DateTime DataDeCriacao { get; set; }
        public virtual DateTime? DataDeAtualizacao { get; set; }
        public virtual DateTime? DataDeExclusao { get; set; }
    }
}
