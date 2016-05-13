using PrototipoArquitetura1.Aplicacao.Interfaces;
using PrototipoArquitetura1.Dominio.Entidades;
using PrototipoArquitetura1.Dominio.Interfaces;
using PrototipoArquitetura1.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoArquitetura1.Aplicacao
{
    public class FamiliaServicoApp : IFamiliaServicoApp
    {
        private readonly IServicoFamilia _servicoFamilia;
        private readonly IUnidadeDeTrabalho _unidadeDeTrabalho;

        public FamiliaServicoApp(IServicoFamilia servicoFamilia, IUnidadeDeTrabalho unidadeDeTrabalho)
        { 
            _servicoFamilia = servicoFamilia;
            _unidadeDeTrabalho = unidadeDeTrabalho;
        }

        //Todo: Retornar familia
        public void Incluir()
        {
            //Todo: Chamar automapper aqui

            try
            {
                _unidadeDeTrabalho.BeginTran();

                var retornaFamilia = _servicoFamilia.Adicionar(new Familia());
                
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
