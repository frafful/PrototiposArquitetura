using DomainValidation.Validation;
using PrototipoArquitetura1.Dominio.Especificacoes.Familia;
using PrototipoArquitetura1.Dominio.Interfaces.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoArquitetura1.Dominio.Validacoes.Familia
{
    public class FamiliaAptaParaCadastroValidacao : Validator<Dominio.Entidades.Familia>
    {
        public FamiliaAptaParaCadastroValidacao(IRepositorioFamilia repositorioFamilia)
        {
            var familiaDuplicada = new FamiliaDevePossuirNomeUnicoEspecificacao(repositorioFamilia);

            base.Add("familiaDuplicada", new Rule<Dominio.Entidades.Familia>(familiaDuplicada, "Família com mesmo nome já cadastrada."));
        }
    }
}
