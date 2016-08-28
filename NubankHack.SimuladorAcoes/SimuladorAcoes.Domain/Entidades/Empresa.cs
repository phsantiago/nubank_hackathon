using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimuladorAcoes.Domain.Entidades
{
    public class Empresa
    {
        public int IdEmpresa { get; set; }
        public string NomeEmpresa { get; set; }
        public decimal ValorDeMercado { get; set; }
        public decimal ValorDeAbertura { get; set; }
        public decimal MaiorValorDia { get; set; }
        public decimal MenorValorDia { get; set; }
        public decimal MaiorMeses { get; set; }
        public decimal MenorMeses { get; set; }
        public decimal CotacaoRecente { get; set; }
        public decimal Variacao { get; set; }
        public decimal UltimoFechamento { get; set; }

    }
}
