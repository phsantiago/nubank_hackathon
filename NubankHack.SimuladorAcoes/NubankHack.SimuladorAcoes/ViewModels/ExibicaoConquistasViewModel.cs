using SimuladorAcoes.Data.Context;
using SimuladorAcoes.Domain.Entidades;
using System.Linq;

namespace NubankHack.SimuladorAcoes.ViewModels
{
    public class ExibicaoConquistasViewModel
    {
        public int IdConquista { get; set; }
        public string TituloConquista { get; set; }
        public string DescricaoConquista { get; set; }
        public bool Completada { get; set; }
        public decimal ValorDesconto { get; set; }
    }

    public static class ExibicaoConquistaConverter
    {
        public static ExibicaoConquistasViewModel ConvertToViewModel(this DefinicaoConquista o, int userId, SimuladorAcoesContext ctx)
        {
            return new ExibicaoConquistasViewModel() {
                Completada = ctx.Conquista.Any(x => x.IdUsuario == userId && x.IdDefinicaoConquista == o.IdDefinicaoConquista),
                DescricaoConquista = o.DescricaoConquista,
                IdConquista = o.IdDefinicaoConquista,
                TituloConquista = o.TituloConquista,
                ValorDesconto = o.ValorDesconto
            };
        }
    }
}