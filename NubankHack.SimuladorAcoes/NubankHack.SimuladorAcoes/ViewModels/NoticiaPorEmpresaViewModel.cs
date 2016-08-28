using SimuladorAcoes.Domain.Entidades;

namespace NubankHack.SimuladorAcoes.ViewModels
{
    public class NoticiaPorEmpresaViewModel
    {
        public string Descricao { get; set; }
        public string UrlNoticia { get; set; }
        public string UrlImagemNoticia { get; set; }
    }

    public static class NoticiaPorEmpresaViewModelConverter
    {
        public static NoticiaPorEmpresaViewModel ConvertToViewModel(this Noticia o)
        {
            return new NoticiaPorEmpresaViewModel() {
                Descricao = o.Descricao,
                UrlImagemNoticia = o.UrlImagemNoticia,
                UrlNoticia = o.UrlNoticia
            };
        }
    }
}