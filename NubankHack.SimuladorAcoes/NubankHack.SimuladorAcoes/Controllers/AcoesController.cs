using NubankHack.SimuladorAcoes.ViewModels;
using SimuladorAcoes.Data.Context;
using SimuladorAcoes.Domain.Entidades;
using SimuladorAcoes.RegrasDominio.Implementacoes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace NubankHack.SimuladorAcoes.Controllers
{
    [EnableCors("*", "*", "*")]
    public class AcoesController : ApiController
    {
        [HttpGet]
        [Route("Acoes/{idUsuario}")]
        public RequestResponse<List<ListaEstoqueUsuarioViewModel>> ListarAcoesUsuario(int idUsuario)
        {
            var ret = new RequestResponse<List<ListaEstoqueUsuarioViewModel>>();
            try
            {
                using (var ctx = new SimuladorAcoesContext())
                {
                    var listaViewModel = new List<ListaEstoqueUsuarioViewModel>();
                    var listaEstoque = ctx.EstoqueAcoes.Where(x => x.UsuarioId == idUsuario && x.Quantidade > 0).Include(x => x.Acao);
                    foreach (var item in listaEstoque)
                        listaViewModel.Add(item.ConvertToViewModel());

                    ret.Code = 0;
                    ret.Message = "Sucesso";
                    ret.ReturnObject = listaViewModel;
                    return ret;
                }
            }
            catch (Exception ex)
            {
                ret.Code = -1;
                ret.Message = ex.Message;
                return ret;
            }
        }

        [HttpPost]
        [Route("Acoes/Comprar")]
        public RequestResponse<List<ConquistaAlcancadaViewModel>> Comprar(int idUsuario, int quantidade, int idAcao)
        {
            try
            {
                var conquistasViewModel = new List<ConquistaAlcancadaViewModel>();
                var handler = new ComprarAcaoRegra(idAcao, quantidade, idUsuario);

                var conquistas = handler.ComprarAcao();

                var ret = new RequestResponse<List<ConquistaAlcancadaViewModel>>();

                foreach (var item in conquistas)
                    conquistasViewModel.Add(item.DefinicaoConquista.ConvertToViewModel());

                ret.ReturnObject = conquistasViewModel;
                ret.Code = 0;
                ret.Message = "Sucesso";
                return ret;
            }
            catch (Exception ex)
            {
                return new RequestResponse<List<ConquistaAlcancadaViewModel>>(500, ex.Message);
            }
        }

        [HttpPost]
        [Route("Acoes/Vender")]
        public RequestResponse<List<ConquistaAlcancadaViewModel>> Vender(int idUsuario, int quantidade, int idAcao)
        {
            try
            {
                var conquistasViewModel = new List<ConquistaAlcancadaViewModel>();
                var handler = new VenderAcaoRegra(idAcao, quantidade, idUsuario);

                var conquistas = handler.VenderAcao();

                foreach (var c in conquistas)
                    conquistasViewModel.Add(c.DefinicaoConquista.ConvertToViewModel());

                var ret = new RequestResponse<List<ConquistaAlcancadaViewModel>>();
                ret.ReturnObject = conquistasViewModel;
                ret.Code = 0;
                ret.Message = "Sucesso";

                return ret;
            }
            catch (Exception ex)
            {
                return new RequestResponse<List<ConquistaAlcancadaViewModel>>(500, ex.Message);
            }
        }
    }
}
