using PrototipoArquitetura1.Dominio.Entidades;
using PrototipoArquitetura1.Dominio.Interfaces;
using PrototipoArquitetura1.Dominio.Interfaces.Repositorios;
using PrototipoArquitetura1.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainValidation;

namespace PrototipoArquitetura1.Servico
{
    public class ServicoFamilia : IServicoFamilia
    {
        private readonly IUnidadeDeTrabalho _unidadeDeTrabalho;
        private readonly IRepositorioFamilia _repositorioFamilia;
        
        public ServicoFamilia(IUnidadeDeTrabalho unidadeDeTrabalho, IRepositorioFamilia repositorioFamilia)
        {
            _repositorioFamilia = repositorioFamilia;
            _unidadeDeTrabalho = unidadeDeTrabalho;
        }
        
        public Familia Adicionar(Dominio.Entidades.Familia familia)
        {
            if (!familia.Valido())
                return familia;
            
            familia = new Familia { Nome = "Familia Teste", DataDeCriacao = DateTime.Now, DataDeAtualizacao = DateTime.Now };
            
            _repositorioFamilia.Incluir(familia);

            familia.ResultadoValidacao.Message = "Família cadastrada com sucesso";

            return familia;
        }
    }
}
