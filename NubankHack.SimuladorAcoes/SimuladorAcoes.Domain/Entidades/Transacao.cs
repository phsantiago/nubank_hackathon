using System;

namespace SimuladorAcoes.Domain.Entidades
{
    public class Transacao
    {
        public int IdTransacao { get; set; }
        public TipoTransacao CompraOuVenda { get; set; }
        public decimal ValorTransacao { get; set; }
        public int QtdTransacao { get; set; }
        public DateTime DataTransacao { get; set; }

        public int UsuarioId { get; set; }
        public int EmpresaId { get; set; }

        public virtual Usuario Usuario { get; set; }
        public virtual AcaoEmpresa AcaoComprada { get; set; }
    }

    public enum TipoTransacao:int
    {
        Compra = 1,
        Venda = 2
    }
}
