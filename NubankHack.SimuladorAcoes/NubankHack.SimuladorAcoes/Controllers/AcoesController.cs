using SimuladorAcoes.Data.Context;
using SimuladorAcoes.Domain.Entidades;
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
        public List<Empresa> Empresas()
        {
            using (var ctx = new SimuladorAcoesContext())
            {
                return ctx.Empresa.ToList();
            }
        }

    }
}
