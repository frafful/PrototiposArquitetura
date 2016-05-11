using PrototipoArquitetura1.Aplicacao.Interfaces;
using PrototipoArquitetura1.Dominio.Entidades;
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

        public FamiliaServicoApp(IServicoFamilia servicoFamilia)
        { 
            //teste
            _servicoFamilia = servicoFamilia;
        }

        public void Incluir()
        {
            _servicoFamilia.Adicionar(new Familia());
        }

    }
}
