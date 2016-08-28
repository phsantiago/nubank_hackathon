using SimuladorAcoes.RegrasDominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuladorAcoes.Data.Context;
using SimuladorAcoes.Domain.Entidades;

namespace SimuladorAcoes.RegrasDominio.Implementacoes.VerificacaoConquistas
{
    public class ConquistaConservador : IConquista
    {
        public const decimal ValorMercadoConquista = 100000000;

        public Conquista VerificarSeConquistaFoiAlcancada(int idUsuario, DefinicaoConquista conquistaAVerificar, SimuladorAcoesContext ctx)
        {
            if (ctx.Transacoes.Any(x => x.AcaoComprada.ValorDeMercado >= ValorMercadoConquista))
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
