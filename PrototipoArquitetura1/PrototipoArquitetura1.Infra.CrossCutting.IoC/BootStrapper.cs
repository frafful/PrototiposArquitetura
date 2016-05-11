using PrototipoArquitetura1.Aplicacao;
using PrototipoArquitetura1.Aplicacao.Interfaces;
using PrototipoArquitetura1.Dominio.Interfaces;
using PrototipoArquitetura1.Dominio.Interfaces.Repositorios;
using PrototipoArquitetura1.Dominio.Interfaces.Servicos;
using PrototipoArquitetura1.Infra.Dados;
using PrototipoArquitetura1.Infra.Dados.Repositorios;
using PrototipoArquitetura1.Servico;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototipoArquitetura1.Infra.CrossCutting.IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            container.Register<IFamiliaServicoApp, FamiliaServicoApp>();
            container.Register<IServicoFamilia, ServicoFamilia>();
            container.Register<IRepositorioFamilia, RepositorioFamilia>();

            //Todo: Verificar se o lifestyle é correto para a unidade de trabalho
            container.Register<IUnidadeDeTrabalho, UnidadeDeTrabalho>(Lifestyle.Scoped);
        }
    }
}
