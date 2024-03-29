﻿using SimuladorAcoes.Data.Context;
using SimuladorAcoes.Domain.Entidades;
using SimuladorAcoes.RegrasDominio.Implementacoes.VerificacaoConquistas;
using System;
using System.Collections.Generic;
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
            if (quantidadeComprada < 1)
                throw new Exception("Quantidade deve ser maior que 0");
        }

        public List<Conquista> ComprarAcao()
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

                AdicionarTransacao(acao, usuario, ctx);

                AdicionarEstoque(usuario, acao, ctx);

                var ret = VerificarConquistas(usuario, ctx);

                ctx.SaveChanges();

                return ret;
            }
        }

        private List<Conquista> VerificarConquistas(Usuario usuario, SimuladorAcoesContext ctx)
        {
            var conquistasObtidas = new VerificadorGeralConquistas(usuario.IdUsuario, ctx).VerificarConquistasCompraAindaNaoAlcancadas();

            foreach (var c in conquistasObtidas)
            {
                ctx.Conquista.Add(c);
                usuario.DescontoAcumuladoUsuario += c.DefinicaoConquista.ValorDesconto;
            }

            return conquistasObtidas;
        }

        private void AdicionarEstoque(Usuario usuario, AcaoEmpresa acao, SimuladorAcoesContext ctx)
        {
            var existeEstoque = ctx.EstoqueAcoes.SingleOrDefault(x => x.UsuarioId == usuario.IdUsuario && x.EmpresaId == acao.IdEmpresa);
            if(existeEstoque == null)
            {
                var novoItemEstoque = new EstoqueAcoes() {
                    Acao = acao,
                    Usuario = usuario,
                    Quantidade = _qtdComprada
                };
                ctx.EstoqueAcoes.Add(novoItemEstoque);
            }
            else
            {
                existeEstoque.Quantidade += _qtdComprada;
            }
        }

        private void AdicionarTransacao(AcaoEmpresa acao, Usuario usuario, SimuladorAcoesContext ctx)
        {
            var transacao = new Transacao()
            {
                CompraOuVenda = TipoTransacao.Compra,
                ValorTransacao = acao.CotacaoRecente,
                AcaoComprada = acao,
                DataTransacao = DateTime.Now,
                Usuario = usuario,
                QtdTransacao = _qtdComprada,
            };

            ctx.Transacoes.Add(transacao);
        }
    }
}
