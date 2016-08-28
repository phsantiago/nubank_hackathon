using NubankHack.SimuladorAcoes.ViewModels;
using SimuladorAcoes.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NubankHack.SimuladorAcoes.Controllers
{
    public class NoticiaController : ApiController
    {
        [HttpGet]
        [Route("Noticias/Listar/{idEmpresa}")]
        public RequestResponse<List<NoticiaPorEmpresaViewModel>> Listar(int idEmpresa)
        {
            var objRetorno = new RequestResponse<List<NoticiaPorEmpresaViewModel>>();
            try
            {
                using (var ctx = new SimuladorAcoesContext())
                {
                    var ret = new List<NoticiaPorEmpresaViewModel>();
                    var listaNoticias = ctx.Noticia.Where(x => x.EmpresaId == idEmpresa);

                    foreach (var noticia in listaNoticias)
                        ret.Add(noticia.ConvertToViewModel());

                    objRetorno.Code = 0;
                    objRetorno.Message = "Sucesso";
                    objRetorno.ReturnObject = ret;
                    return objRetorno;
                }
            }
            catch (Exception ex)
            {
                objRetorno.Code = -1;
                objRetorno.Message = ex.Message;
                return objRetorno;
            }
        }
    }
}
