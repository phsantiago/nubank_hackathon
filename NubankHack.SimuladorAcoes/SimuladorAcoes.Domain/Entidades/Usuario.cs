using System.Collections.Generic;

namespace SimuladorAcoes.Domain.Entidades
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NomeUsuario { get; set; }
        public string SenhaUsuario { get; set; }
        public decimal SaldoUsuario { get; set; }
        public decimal DescontoAcumuladoUsuario { get; set; }
        public string UrlImagemUsuario { get; set; }

        public virtual ICollection<Conquista> Conquistas { get; set; }
        public virtual ICollection<Transacao> Transacoes { get; set; }
        public virtual ICollection<EstoqueAcoes> EstoqueAcoes { get; set; }
    }
}
