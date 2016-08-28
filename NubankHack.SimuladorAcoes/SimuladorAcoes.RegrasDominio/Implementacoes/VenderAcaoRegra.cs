using SimuladorAcoes.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimuladorAcoes.Domain.Entidades;
using SimuladorAcoes.RegrasDominio.Implementacoes.VerificacaoConquistas;

namespace SimuladorAcoes.RegrasDominio.Implementacoes
{
    public class VenderAcaoRegra
    {
        private int _acaoVendidaId;
        private int _qtdVendida;
        private int _idUsuarioVendedor;

        public VenderAcaoRegra(int idAcaoVendida, int quantidadeVendida, int idUsuarioVendedor)
        {
            _acaoVendidaId = idAcaoVendida;
            _qtdVendida = quantidadeVendida;
            _idUsuarioVendedor = idUsuarioVendedor;
            if (quantidadeVendida < 1)
                throw new Exception("Quantidade deve ser maior que 0");
        }

        public List<Conquista> VenderAcao()
        {
            using (var ctx = new SimuladorAcoesContext())
            {
                var acaoEmEstoque = ctx.EstoqueAcoes.Single(x => x.EmpresaId == _acaoVendidaId && x.UsuarioId == _idUsuarioVendedor);

                if (_qtdVendida > acaoEmEstoque.Quantidade)
                    throw new Exception("Não é possível vender mais ações do que possui");

                acaoEmEstoque.Quantidade -= _qtdVendida;

                IncluirTransacaoVenda(ctx, acaoEmEstoque);

                acaoEmEstoque.Usuario.SaldoUsuario += acaoEmEstoque.Acao.CotacaoRecente * _qtdVendida;

                var conquistas = VerificarConquistas(ctx, acaoEmEstoque.UsuarioId);

                ctx.SaveChanges();

                return conquistas;
            }
        }

        private List<Conquista> VerificarConquistas(SimuladorAcoesContext ctx, int usuarioId)
        {
            var conquistasObtidas = new VerificadorGeralConquistas(usuarioId, ctx).VerificarConquistasVendaAindaNaoAlcancadas();

            foreach (var c in conquistasObtidas)
            {
                ctx.Conquista.Add(c);
            }

            return conquistasObtidas;
        }

        private void IncluirTransacaoVenda(SimuladorAcoesContext ctx, EstoqueAcoes acaoEmEstoque)
        {
            var transacao = new Transacao() {
                CompraOuVenda = TipoTransacao.Venda,
                DataTransacao = DateTime.Now,
                AcaoComprada = acaoEmEstoque.Acao,
                QtdTransacao = _qtdVendida,
                Usuario = acaoEmEstoque.Usuario,
                ValorTransacao = acaoEmEstoque.Acao.CotacaoRecente
            };

            ctx.Transacoes.Add(transacao);
        }
    }
}
