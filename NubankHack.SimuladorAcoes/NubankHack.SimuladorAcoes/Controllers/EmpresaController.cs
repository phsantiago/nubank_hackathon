using NubankHack.SimuladorAcoes.ViewModels;
using SimuladorAcoes.Data.Context;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NubankHack.SimuladorAcoes.Controllers
{
    [EnableCors("*", "*", "*")]
    public class EmpresaController : ApiController
    {
        [HttpGet]
        [Route("Empresa/ListarEmpresas")]
        public List<EmpresasMenuPrincipalViewModel> ListarEmpresas()
        {
            using (var db = new SimuladorAcoesContext())
            {
                var ret = new List<EmpresasMenuPrincipalViewModel>();

                foreach (var acao in db.Empresa)
                {
                    ret.Add(acao.ConvertToViewModel());
                }

                return ret;
            }
        }
    }
}
