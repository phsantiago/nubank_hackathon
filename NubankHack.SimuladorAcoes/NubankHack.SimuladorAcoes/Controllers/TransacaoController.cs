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
    public class TransacaoController : ApiController
    {
        [Route("Transacao/Lista/Empresa/{idEmpresa}/{idUsuario}")]
        [HttpGet]
        public RequestResponse<List<LogCompraVendaViewModel>> ListarTransacoes(int idUsuario, int idEmpresa)
        {
            var response = new RequestResponse<List<LogCompraVendaViewModel>>();
            try
            {
                using (var ctx = new SimuladorAcoesContext())
                {
                    var listaRetorno = new List<LogCompraVendaViewModel>();
                    var listaTransacoes = ctx.Transacoes.Where(x => x.UsuarioId == idUsuario && x.EmpresaId == idEmpresa);

                    foreach (var transacao in listaTransacoes)
                        listaRetorno.Add(transacao.ConvertToViewModel());

                    response.Code = 0;
                    response.Message = "Sucesso";
                    response.ReturnObject = listaRetorno;

                    return response;
                }
            }
            catch (Exception ex)
            {
                response.Code = -1;
                response.Message = ex.Message;
                return response;
            }
        }
    }
}
