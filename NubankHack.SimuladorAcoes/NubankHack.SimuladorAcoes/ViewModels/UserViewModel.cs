using SimuladorAcoes.Domain.Entidades;

namespace NubankHack.SimuladorAcoes.ViewModels
{
    public class UserViewModel
    {
        public string NomeUsuario { get; set; }
        public decimal SaldoUsuario { get; set; }
        public decimal DescontoAcumuladoUsuario { get; set; }
        public string UrlImagemUsuario { get; set; }
    }

    public static class UserViewModelConverter
    {
        public static UserViewModel ConvertToViewModel(this Usuario o)
        {
            return new UserViewModel()
            {
                NomeUsuario = o.NomeUsuario,
                DescontoAcumuladoUsuario = o.DescontoAcumuladoUsuario,
                SaldoUsuario = o.SaldoUsuario,
                UrlImagemUsuario = o.UrlImagemUsuario
            };
        }
    }
}