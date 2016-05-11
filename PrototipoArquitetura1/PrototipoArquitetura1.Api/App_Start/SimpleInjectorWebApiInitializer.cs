using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SimpleInjector;
using SimpleInjector.Integration.WebApi;
using System.Web.Http;
using PrototipoArquitetura1.Infra.CrossCutting.IoC;

namespace PrototipoArquitetura1.Api.App_Start
{
    public class SimpleInjectorWebApiInitializer
    {
        public static void Initialize()
        {
            var container = new Container();

            container.Options.DefaultScopedLifestyle = new WebApiRequestLifestyle();

            InitializeContainer(container);

            container.Verify();

            //Todo: Habilitar injection do RequestMessage
            //container.EnableHttpRequestMessageTracking(GlobalConfiguration.Configuration);

            GlobalConfiguration.Configuration.DependencyResolver = 
                new SimpleInjectorWebApiDependencyResolver(container);
        }

        private static void InitializeContainer(Container container)
        {
            BootStrapper.RegisterServices(container);
        }
    }
}