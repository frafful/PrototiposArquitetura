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
        
        public void Adicionar(Dominio.Entidades.Familia familia)
        {
            //teste
            familia = new Familia { Nome = "Familia Teste", DataDeCriacao = DateTime.Now, DataDeAtualizacao = DateTime.Now };

            //Teste transacao
            try
            {
                _unidadeDeTrabalho.BeginTran();

                _repositorioFamilia.Incluir(familia);

                _unidadeDeTrabalho.Commit();
            }
            catch (Exception)
            {
                _unidadeDeTrabalho.Rollback();
                throw;
            }
        }
    }
}
