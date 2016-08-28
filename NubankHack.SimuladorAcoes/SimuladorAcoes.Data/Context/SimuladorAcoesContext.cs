using SimuladorAcoes.Data.Configurations;
using SimuladorAcoes.Domain.Entidades;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SimuladorAcoes.Data.Context
{
    public class SimuladorAcoesContext : DbContext
    {
        public SimuladorAcoesContext()
            : base("dbConnect")
        {
        }

        public IDbSet<Empresa> Empresa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));


            modelBuilder.Configurations.Add(new EmpresaDbConfig());
        }
    }
}
