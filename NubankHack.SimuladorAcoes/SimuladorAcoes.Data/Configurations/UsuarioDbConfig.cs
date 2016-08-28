using SimuladorAcoes.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorAcoes.Data.Configurations
{
    public class UsuarioDbConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioDbConfig()
        {
            HasKey(x => x.IdUsuario);


        }
    }
}
