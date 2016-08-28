using SimuladorAcoes.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace SimuladorAcoes.Data.Configurations
{
    public class EmpresaDbConfig : EntityTypeConfiguration<AcaoEmpresa>
    {
        public EmpresaDbConfig()
        {
            HasKey(x => x.IdEmpresa);

            Property(x => x.LogoEmpresaUrl)
                .HasMaxLength(200);
        }
    }
}
