namespace SimuladorAcoes.Domain.Entidades
{
    public class EstoqueAcoes
    {
        public int IdEstoque { get; set; }
        public int UsuarioId { get; set; }
        public int Quantidade { get; set; }
        public int EmpresaId { get; set; }

        public virtual AcaoEmpresa Acao { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
