using NubankHack.SimuladorAcoes.ViewModels;
using SimuladorAcoes.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NubankHack.SimuladorAcoes.Controllers
{
    [EnableCors("*", "*", "*")]
    public class ConquistaController : ApiController
    {
        [HttpGet]
        [Route("Conquista/Lista/{usuarioId}")]
        public RequestResponse<List<ExibicaoConquistasViewModel>> ListarConquistas(int usuarioId)
        {
            var ret = new RequestResponse<List<ExibicaoConquistasViewModel>>();
            try
            {
                using (var ctx = new SimuladorAcoesContext())
                {
                    var listaDados = new List<ExibicaoConquistasViewModel>();
                    var listaConquistas = ctx.DefinicaoConquista.ToList();

                    foreach (var c in listaConquistas)
                        listaDados.Add(c.ConvertToViewModel(usuarioId, ctx));

                    ret.Code = 0;
                    ret.Message = "Sucesso";
                    ret.ReturnObject = listaDados;
                    return ret;
                }
            }
            catch (Exception ex)
            {
                ret.Message = ex.Message;
                ret.Code = -1;
                return ret;
            }
        }
    }
}
