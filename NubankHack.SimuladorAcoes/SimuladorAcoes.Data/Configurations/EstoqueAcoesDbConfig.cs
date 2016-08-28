using SimuladorAcoes.Domain.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace SimuladorAcoes.Data.Configurations
{
    public class EstoqueAcoesDbConfig : EntityTypeConfiguration<EstoqueAcoes>
    {
        public EstoqueAcoesDbConfig()
        {
            HasKey(x => x.IdEstoque);

            HasRequired(x => x.Usuario)
                .WithMany(b => b.EstoqueAcoes)
                .HasForeignKey(x => x.UsuarioId);

            HasRequired(x => x.Acao)
                .WithMany(b => b.EstoqueAcoesUsuario)
                .HasForeignKey(x => x.EmpresaId);
        }
    }
}
