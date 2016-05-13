using PrototipoArquitetura1.Api.App_Start;
using PrototipoArquitetura1.Aplicacao.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace PrototipoArquitetura1.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            SimpleInjectorWebApiInitializer.Initialize();
            
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AutoMapperConfig.RegistrarMapeamentos();
        }
    }
}
