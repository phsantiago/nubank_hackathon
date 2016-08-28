using SimuladorAcoes.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace SimuladorAcoes.Data.Configurations
{
    public class NoticiaDbConfiguration : EntityTypeConfiguration<Noticia>
    {
        public NoticiaDbConfiguration()
        {
            HasKey(x => x.IdNoticia);

            Property(x => x.UrlImagemNoticia)
                .HasMaxLength(200);

            Property(x => x.UrlNoticia)
                .HasMaxLength(200);

            Property(x => x.Descricao)
                .HasMaxLength(500);

            Property(x => x.TituloNoticia)
                .IsOptional()
                .HasMaxLength(75);

            HasRequired(x => x.EmpresaReferente)
                .WithMany(n => n.Noticias)
                .HasForeignKey(x => x.EmpresaId);
        }
    }
}
