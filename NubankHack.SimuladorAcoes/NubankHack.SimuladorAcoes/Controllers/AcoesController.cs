using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NubankHack.SimuladorAcoes.Controllers
{
    public class AcoesController : ApiController
    {
        [HttpGet]
        [Route("Acoes/Teste")]
        public string Teste()
        {
            return "OK";
        }

    }
}
