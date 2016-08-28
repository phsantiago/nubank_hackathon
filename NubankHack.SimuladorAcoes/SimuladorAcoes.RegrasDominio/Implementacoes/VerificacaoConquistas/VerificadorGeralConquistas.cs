using SimuladorAcoes.Data.Context;
using SimuladorAcoes.Domain.Entidades;
using SimuladorAcoes.RegrasDominio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorAcoes.RegrasDominio.Implementacoes.VerificacaoConquistas
{
    public class VerificadorGeralConquistas
    {
        private readonly int idUsuario;
        private readonly SimuladorAcoesContext _ctx;
        private readonly List<DefinicaoConquista> _conquistasNaoAlcancadas;

        public VerificadorGeralConquistas(int IdUsuario, SimuladorAcoesContext ctx)
        {
            idUsuario = IdUsuario;
            _ctx = ctx;
            _conquistasNaoAlcancadas = _ctx.DefinicaoConquista.Where(x => !_ctx.Conquista.Any(y => y.IdUsuario == IdUsuario && x.IdDefinicaoConquista == y.IdDefinicaoConquista))
                .ToList();
        }

        public List<Conquista> VerificarConquistasCompraAindaNaoAlcancadas()
        {
            var conquistasAlcancadas = new List<Conquista>();

            foreach (var ach in _conquistasNaoAlcancadas)
            {
                var verificadorConquista = VerificacaoConquistaFactory.ObterVerificadorConquista(ach.IdDefinicaoConquista);
                var conquistaObtida = verificadorConquista.VerificarSeConquistaFoiAlcancada(idUsuario, ach, _ctx);
                if (conquistaObtida != null)
                    conquistasAlcancadas.Add(conquistaObtida);
            }

            return conquistasAlcancadas;
        }

        public List<Conquista> VerificarConquistasVendaAindaNaoAlcancadas()
        {
            var conquistasAlcancadas = new List<Conquista>();

            foreach (var ach in _conquistasNaoAlcancadas)
            {
                var verificadorConquista = VerificacaoConquistaFactory.ObterVerificadorConquista(ach.IdDefinicaoConquista);
                var conquistaObtida = verificadorConquista.VerificarSeConquistaFoiAlcancada(idUsuario, ach, _ctx);
                if (conquistaObtida != null)
                    conquistasAlcancadas.Add(conquistaObtida);
            }

            return conquistasAlcancadas;
        }

    }
}
