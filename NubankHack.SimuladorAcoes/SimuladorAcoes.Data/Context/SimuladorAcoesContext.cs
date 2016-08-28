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

        public IDbSet<AcaoEmpresa> Empresa { get; set; }
        public IDbSet<Conquista> Conquista { get; set; }
        public IDbSet<DefinicaoConquista> DefinicaoConquista { get; set; }
        public IDbSet<Transacao> MyProperty { get; set; }
        public IDbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));


            modelBuilder.Configurations.Add(new EmpresaDbConfig());
            modelBuilder.Configurations.Add(new DefinicaoConquistaDbConfig());
            modelBuilder.Configurations.Add(new ConquistaDbConfig());
            modelBuilder.Configurations.Add(new TransacaoDbConfig());
            modelBuilder.Configurations.Add(new UsuarioDbConfig());
        }
    }
}
