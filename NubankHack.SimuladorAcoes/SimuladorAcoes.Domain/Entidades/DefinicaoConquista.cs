using System.Collections;
using System.Collections.Generic;

namespace SimuladorAcoes.Domain.Entidades
{
    public class DefinicaoConquista
    {
        public int IdDefinicaoConquista { get; set; }
        public string TituloConquista { get; set; }
        public string DescricaoConquista { get; set; }
        public decimal ValorDesconto { get; set; }

        public virtual ICollection<Conquista> Conquistas { get; set; }
    }
}
