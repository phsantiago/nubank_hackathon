using SimuladorAcoes.Domain.Entidades;

namespace NubankHack.SimuladorAcoes.ViewModels
{
    public class ListaEstoqueUsuarioViewModel
    {
        public int EmpresaId { get; set; }
        public string NomeEmpresa { get; set; }
        public string UrlLogoEmpresa { get; set; }
        public decimal PrecoAtualAcao { get; set; }
        public int QuantidadeEmEstoque { get; set; }
    }

    public static class ListaEstoqueConverter
    {
        public static ListaEstoqueUsuarioViewModel ConvertToViewModel(this EstoqueAcoes o)
        {
            return new ListaEstoqueUsuarioViewModel() {
                EmpresaId = o.EmpresaId,
                NomeEmpresa = o.Acao.NomeEmpresa,
                PrecoAtualAcao = o.Acao.CotacaoRecente,
                QuantidadeEmEstoque = o.Quantidade,
                UrlLogoEmpresa = o.Acao.LogoEmpresaUrl
            };
        }
    }
}