using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//TODO: Importar a system

namespace SimuladorAcoes.Domain.Entidades
{
    public class Transacao
    {
        public int IdTransacao { get; set; }
        public int CompraOuVenda { get; set; }
        public decimal ValorTransacao { get; set; }
        public int QtdTransacao { get; set; }
        public DateTime DataTransacao { get; set; }


        //FK Usuario
        //FK Empresa
    }
}
