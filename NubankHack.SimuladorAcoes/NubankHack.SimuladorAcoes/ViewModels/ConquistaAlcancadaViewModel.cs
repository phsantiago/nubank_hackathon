using SimuladorAcoes.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NubankHack.SimuladorAcoes.ViewModels
{
    public class ConquistaAlcancadaViewModel
    {
        public string TituloConquista { get; set; }
        public string DescricaoConquista { get; set; }
        public decimal ValorDesconto { get; set; }
    }

    public static class ConquistaAlcancadaViewModelConverter
    {
        public static ConquistaAlcancadaViewModel ConvertToViewModel(this DefinicaoConquista o)
        {
            return new ViewModels.ConquistaAlcancadaViewModel()
            {
                DescricaoConquista = o.DescricaoConquista,
                TituloConquista = o.TituloConquista,
                ValorDesconto = o.ValorDesconto
            };

        }
    }
}