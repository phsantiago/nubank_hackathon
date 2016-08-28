using SimuladorAcoes.Data.Context;
using SimuladorAcoes.Domain.Entidades;
using System;
using System.Linq;

namespace SimuladorAcoes.RegrasDominio.Implementacoes
{
    public class ComprarAcaoRegra
    {
        private int _acaoCompradaId;
        private int _qtdComprada;
        private int _idUsuarioComprador;

        public ComprarAcaoRegra(int idAcaoComprada, int quantidadeComprada, int idUsuarioComprador)
        {
            _acaoCompradaId = idAcaoComprada;
            _qtdComprada = quantidadeComprada;
            _idUsuarioComprador = idUsuarioComprador;   
        }

        public void ComprarAcao()
        {
            using (var ctx = new SimuladorAcoesContext())
            {
                var usuario = ctx.Usuario.Find(_idUsuarioComprador);

                if (usuario == null)
                    throw new Exception("Usuário inexistente");

                var acao = ctx.Empresa.Single(x => x.IdEmpresa == _acaoCompradaId);

                var valorAGastar = acao.CotacaoRecente * _qtdComprada;

                if (valorAGastar > usuario.SaldoUsuario)
                    throw new Exception("Compra ultrapassa saldo do usuário");

                usuario.SaldoUsuario = usuario.SaldoUsuario - valorAGastar;

                var transacao = new Transacao() {
                    CompraOuVenda = TipoTransacao.Compra,
                    ValorTransacao = acao.CotacaoRecente,
                    AcaoComprada = acao,
                    DataTransacao = DateTime.Now,
                    Usuario = usuario,
                    QtdTransacao = _qtdComprada,
                };

                ctx.Transacoes.Add(transacao);

                ctx.SaveChanges();
            }
        }
    }
}
