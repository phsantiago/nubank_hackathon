using SimuladorAcoes.RegrasDominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuladorAcoes.Domain.Entidades;
using SimuladorAcoes.Data.Context;

namespace SimuladorAcoes.RegrasDominio.Implementacoes.VerificacaoConquistas
{
    public class ConquistaCompraPrimeiraAcao : IConquista
    {
        public Conquista VerificarSeConquistaFoiAlcancada(int idUsuario, DefinicaoConquista conquistaAVerificar, SimuladorAcoesContext ctx)
        {
            if (ctx.Transacoes.Any(x => x.UsuarioId == idUsuario && x.CompraOuVenda == TipoTransacao.Compra))
            {
                return new Conquista() {
                    DataConquista = DateTime.Now,
                    DefinicaoConquista = conquistaAVerificar,
                    IdUsuario = idUsuario
                };
            }
            else
                return null;
        }
    }
}
