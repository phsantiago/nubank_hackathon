using SimuladorAcoes.Data.Context;
using SimuladorAcoes.Domain.Entidades;
using SimuladorAcoes.RegrasDominio.Implementacoes.VerificacaoConquistas;

namespace SimuladorAcoes.RegrasDominio.Interfaces
{
    public interface IConquista
    {
        Conquista VerificarSeConquistaFoiAlcancada(int idUsuario, DefinicaoConquista conquistaAVerificar, SimuladorAcoesContext ctx);
    }

    public static class VerificacaoConquistaFactory
    {
        public static IConquista ObterVerificadorConquista(int idDefinicaoConquista)
        {
            switch (idDefinicaoConquista)
            {
                case 1:
                    return new ConquistaCompraPrimeiraAcao();
                case 2:
                    return new VerificarConquistaVender1Acao();
                case 3:
                    return new ComprarMaisDe300ReaisEmAcoes();
                case 4:
                    return new ConquistaVendaMaisDe300EmAcoes();
                case 5:
                    return new ConquistaHipster();
                case 6:
                    return new ConquistaConservador();
                default:
                    return null;
            }
        }

    }
}
