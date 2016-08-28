using SimuladorAcoes.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace SimuladorAcoes.Data.Configurations
{
    public class DefinicaoConquistaDbConfig : EntityTypeConfiguration<DefinicaoConquista>
    {
        public DefinicaoConquistaDbConfig()
        {
            HasKey(x => x.IdDefinicaoConquista);

            Property(x => x.TituloConquista)
                .HasMaxLength(100);

            Property(x => x.DescricaoConquista)
                .IsOptional()
                .HasMaxLength(150);
        }
    }
}
