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
                UrlLogo = o.LogoEmpresaUrl
            };
        }
    }
}