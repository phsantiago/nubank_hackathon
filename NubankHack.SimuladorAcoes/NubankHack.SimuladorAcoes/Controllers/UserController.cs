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
    [EnableCors("*","*","*")]
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("Usuario/Me/{idUsuario}")]
        public RequestResponse<UserViewModel> Me(int idUsuario)
        {
            try
            {
                using (var ctx = new SimuladorAcoesContext())
                {
                    var ret = new RequestResponse<UserViewModel>();
                    var user = ctx.Usuario.Single(x => x.IdUsuario == idUsuario);

                    ret.Message = "Sucesso";
                    ret.ReturnObject = user.ConvertToViewModel();
                    ret.Code = 0;

                    return ret;
                }
            }
            catch (Exception ex)
            {
                return new RequestResponse<UserViewModel>(-1, ex.Message);
            }
        }
    }
}
