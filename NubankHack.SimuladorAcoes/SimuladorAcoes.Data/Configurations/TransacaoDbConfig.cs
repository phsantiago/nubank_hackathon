using SimuladorAcoes.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorAcoes.Data.Configurations
{
    public class TransacaoDbConfig : EntityTypeConfiguration<Transacao>
    {
        public TransacaoDbConfig()
        {
            HasKey(x => x.IdTransacao);

            HasRequired(x => x.Usuario)
                .WithMany(b => b.Transacoes)
                .HasForeignKey(x => x.UsuarioId);

            HasRequired(x => x.AcaoComprada)
                .WithMany(a => a.Transacoes)
                .HasForeignKey(x => x.EmpresaId);
        }
    }
}
