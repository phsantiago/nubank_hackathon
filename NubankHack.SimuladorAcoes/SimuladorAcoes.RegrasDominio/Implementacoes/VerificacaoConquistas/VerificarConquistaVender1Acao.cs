using SimuladorAcoes.RegrasDominio.Interfaces;
using System;
using System.Linq;
using SimuladorAcoes.Data.Context;
using SimuladorAcoes.Domain.Entidades;

namespace SimuladorAcoes.RegrasDominio.Implementacoes.VerificacaoConquistas
{
    public class VerificarConquistaVender1Acao : IConquista
    {
        public Conquista VerificarSeConquistaFoiAlcancada(int idUsuario, DefinicaoConquista conquistaAVerificar, SimuladorAcoesContext ctx)
        {
            if (!ctx.Transacoes.Local.Any(x => x.CompraOuVenda == TipoTransacao.Venda))
                return null;

            return new Conquista()
            {
                DataConquista = DateTime.Now,
                DefinicaoConquista = conquistaAVerificar,
                IdUsuario = idUsuario
            };
        }
    }
}
