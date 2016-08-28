using SimuladorAcoes.RegrasDominio.Interfaces;
using System;
using System.Linq;
using SimuladorAcoes.Data.Context;
using SimuladorAcoes.Domain.Entidades;

namespace SimuladorAcoes.RegrasDominio.Implementacoes.VerificacaoConquistas
{
    public class ConquistaHipster : IConquista
    {
        private const decimal ValorMercadoConquista = 500000;

        public Conquista VerificarSeConquistaFoiAlcancada(int idUsuario, DefinicaoConquista conquistaAVerificar, SimuladorAcoesContext ctx)
        {
            if (ctx.Transacoes.Local.Any(x => x.AcaoComprada.ValorDeMercado < ValorMercadoConquista))
            {
                return new Conquista()
                {
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
