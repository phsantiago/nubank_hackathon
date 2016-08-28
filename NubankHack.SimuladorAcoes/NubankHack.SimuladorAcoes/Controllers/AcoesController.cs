using NubankHack.SimuladorAcoes.ViewModels;
using SimuladorAcoes.Data.Context;
using SimuladorAcoes.Domain.Entidades;
using SimuladorAcoes.RegrasDominio.Implementacoes;
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
        [HttpPost]
        [Route("Acoes/Comprar")]
        public RequestResponse Comprar(int idUsuario, int quantidade, int idAcao)
        {
            try
            {
                var handler = new ComprarAcaoRegra(idAcao, quantidade, idUsuario);

                handler.ComprarAcao();

                return new RequestResponse(1, "Sucesso");
            }
            catch (Exception ex)
            {
                return new RequestResponse(500, ex.Message);
            }
        }

    }
}
