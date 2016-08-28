using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorAcoes.Domain.Entidades
{
    public class Conquista
    {
        public int IdConquista { get; set; }
        public int IdUsuario { get; set; }
        public int IdDefinicaoConquista { get; set; }
        public DateTime DataConquista { get; set; }

        public virtual DefinicaoConquista DefinicaoConquista { get; set; }
        public virtual Usuario Usuario { get; set; }
    }

}

