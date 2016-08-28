using SimuladorAcoes.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace SimuladorAcoes.Data.Configurations
{
    public class UsuarioDbConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioDbConfig()
        {
            HasKey(x => x.IdUsuario);

            Property(x => x.NomeUsuario)
                .HasMaxLength(100);

            Property(x => x.SenhaUsuario)
                .HasMaxLength(100);

            Property(x => x.UrlImagemUsuario)
                .IsOptional()
                .HasMaxLength(250);
        }
    }
}
