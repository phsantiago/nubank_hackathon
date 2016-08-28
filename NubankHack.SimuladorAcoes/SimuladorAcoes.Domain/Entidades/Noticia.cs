namespace SimuladorAcoes.Domain.Entidades
{
    public class Noticia
    {
        public int IdNoticia { get; set; }
        public string Descricao { get; set; }
        public string UrlNoticia { get; set; }
        public string UrlImagemNoticia { get; set; }
        public int EmpresaId { get; set; }
        public string TituloNoticia { get; set; }

        public virtual AcaoEmpresa EmpresaReferente { get; set; }
    }
}
