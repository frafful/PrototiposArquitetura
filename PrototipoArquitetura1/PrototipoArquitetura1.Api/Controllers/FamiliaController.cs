using PrototipoArquitetura1.Aplicacao.Interfaces;
using PrototipoArquitetura1.Aplicacao.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;

namespace PrototipoArquitetura1.Api.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "X-Custom-Header")]
    [RoutePrefix("InterplayersApi/Familia")]
    public class FamiliaController : ApiController
    {
        private readonly IFamiliaServicoApp _familiaServicoApp;

        public FamiliaController(IFamiliaServicoApp familiaServicoApp)
        {
            _familiaServicoApp = familiaServicoApp;
        }
        
        [HttpPost]
        [Route("Incluir")]
        public HttpResponseMessage Incluir(FamiliaViewModel familiaVm)
        {
            _familiaServicoApp.Incluir();

            var resposta = new HttpResponseMessage()
            {
                StatusCode = HttpStatusCode.OK,
                //Content = new StringContent(json)
            };

            resposta.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return resposta;

        }

    }
}
