using DomainValidation.Validation;
using PrototipoArquitetura1.Dominio.Abstratos;
using PrototipoArquitetura1.Dominio.Validacoes.Familia;
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
        public ValidationResult ResultadoValidacao { get; set; }

        public bool Valido()
        {
            ResultadoValidacao = new FamiliaEstaConsistenteValidacao().Validate(this);
            return ResultadoValidacao.IsValid;
        }
    }
}
