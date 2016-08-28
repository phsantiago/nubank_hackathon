using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorAcoes.Domain.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public decimal SaldoUsuario { get; set; }
        public decimal DescontoAcumuladoUsuario { get; set; }

    }
}
