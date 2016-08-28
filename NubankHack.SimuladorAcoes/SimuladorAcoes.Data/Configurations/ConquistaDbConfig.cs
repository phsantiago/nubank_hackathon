using SimuladorAcoes.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorAcoes.Data.Configurations
{
    public class ConquistaDbConfig : EntityTypeConfiguration<Conquista>
    {
        public ConquistaDbConfig()
        { 
            HasKey(x => x.IdConquista);

            HasRequired(x => x.DefinicaoConquista)
                .WithMany()
                .HasForeignKey(x => x.IdDefinicaoConquista);

           
        }
    }
}
