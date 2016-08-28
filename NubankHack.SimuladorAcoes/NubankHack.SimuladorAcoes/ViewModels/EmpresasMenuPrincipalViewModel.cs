using System;
using SimuladorAcoes.Domain.Entidades;

namespace NubankHack.SimuladorAcoes.ViewModels
{
    public class EmpresasMenuPrincipalViewModel
    {
        public int IdEmpresa { get; set; }
        public string NomeEmpresa { get; set; }
        public decimal ValorDeMercado { get; set; }
        public decimal ValorDeAbertura { get; set; }
        public decimal MaiorValorDia { get; set; }
        public decimal MenorValorDia { get; set; }
        public decimal MaiorMeses { get; set; }
        public decimal MenorMeses { get; set; }
        public decimal CotacaoRecente { get; set; }
        public decimal Variacao { get; set; }
        public decimal UltimoFechamento { get; set; }
        public string UrlLogo { get; set; }
        public string UrlGrafico { get; set; }
    }

    public static class Converter
    {
        public static EmpresasMenuPrincipalViewModel ConvertToViewModel(this AcaoEmpresa o)
        {
            return new EmpresasMenuPrincipalViewModel()
            {
                IdEmpresa = o.IdEmpresa,
                NomeEmpresa = o.NomeEmpresa,
                ValorDeAbertura = o.ValorDeAbertura,
                ValorDeMercado = o.ValorDeMercado,
                MaiorValorDia = o.MaiorValorDia,
                MenorValorDia = o.MenorValorDia,
                MaiorMeses = o.MaiorMeses,
                MenorMeses = o.MenorMeses,
                CotacaoRecente = o.CotacaoRecente,
                Variacao = o.Variacao,
                UltimoFechamento = o.UltimoFechamento,
                UrlLogo = o.LogoEmpresaUrl,
                UrlGrafico = PegarGraficoEmpresa(o.IdEmpresa)
            };
        }

        private static string PegarGraficoEmpresa(int idEmpresa)
        {
            switch (idEmpresa)
            {
                case 1:
                    return "http://i.imgur.com/KbH13FW.png";
                case 2:
                    return "http://i.imgur.com/gTdMh8B.png";
                case 3:
                    return "http://i.imgur.com/ygtdOua.png";
                case 4:
                    return "http://i.imgur.com/BOYtdJI.png";
                case 5:
                    return "http://i.imgur.com/GHRvUtu.png";
                case 6:
                    return "http://i.imgur.com/NlwtM4r.png";
                case 7:
                    return "http://i.imgur.com/ggQ6iST.png";
                case 8:
                    return "http://i.imgur.com/BHwLpCp.png";
                case 9:
                    return "http://i.imgur.com/TR7R7Vj.png";
                case 10:
                    return "http://i.imgur.com/6fOdYNQ.png";
                case 11:
                    return "http://i.imgur.com/tABYF8H.png";

                default:
                    return "";
            }
        }
    }
}