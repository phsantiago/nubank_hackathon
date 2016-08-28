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
    public class ComprarMaisDe300ReaisEmAcoes : IConquista
    {
        public Conquista VerificarSeConquistaFoiAlcancada(int idUsuario, DefinicaoConquista conquistaAVerificar, SimuladorAcoesContext ctx)
        {
            if (ctx.Transacoes.Where(x => x.CompraOuVenda == TipoTransacao.Compra && x.UsuarioId == idUsuario).Sum(y => y.ValorTransacao * y.QtdTransacao) > 300)
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
