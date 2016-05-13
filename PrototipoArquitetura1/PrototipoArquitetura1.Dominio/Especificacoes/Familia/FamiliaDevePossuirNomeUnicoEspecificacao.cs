using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainValidation.Interfaces.Specification;
using PrototipoArquitetura1.Dominio.Entidades;
using PrototipoArquitetura1.Dominio.Interfaces.Repositorios;

namespace PrototipoArquitetura1.Dominio.Especificacoes.Familia
{
    public class FamiliaDevePossuirNomeUnicoEspecificacao : ISpecification<Dominio.Entidades.Familia>
    {
        private readonly IRepositorioFamilia _repositorioFamilia;

        public FamiliaDevePossuirNomeUnicoEspecificacao(IRepositorioFamilia repositorioFamilia)
        {
            _repositorioFamilia = repositorioFamilia;
        }

        public bool IsSatisfiedBy(Dominio.Entidades.Familia entity)
        {
            return _repositorioFamilia.ObterPorNome(entity.Nome) == null;
        }
    }
}
