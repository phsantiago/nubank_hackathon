using SimuladorAcoes.Domain.Entidades;

namespace NubankHack.SimuladorAcoes.ViewModels
{
    public class LogCompraVendaViewModel
    {
        public TipoTransacao TipoTransacao { get; set; }
        public decimal ValorUnitario { get; set; }
        public int Quantidade { get; set; }
        public string DataHoraTransacao { get; set; }
    }

    public static class LogCompraVendaConverter
    {
        public static LogCompraVendaViewModel ConvertToViewModel (this Transacao o)
        {
            return new LogCompraVendaViewModel() {
                DataHoraTransacao = $"{o.DataTransacao.ToShortDateString()} { o.DataTransacao.ToShortTimeString() }",
                Quantidade = o.QtdTransacao,
                TipoTransacao = o.CompraOuVenda,
                ValorUnitario = o.ValorTransacao
            };
        }
    }
}