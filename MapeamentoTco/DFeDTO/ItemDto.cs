using TCO.WebApi.Abstractions.Enums;

namespace TCO.WebApi.Abstractions.DTO
{
    public class ItemDto
    {
        public CestDto Cest { get; set; }
        public ClassificacaoFiscalDTO ClassificacaoFiscal { get; set; }
        public string Codigo { get; set; }
        public string CodigoBarra { get; set; }
        public string CodigoListaServico { get; set; }
        public string Descricao { get; set; }
        public TipoItemEnum? TipoItem { get; set; }
        public UnidadeMedidaDTO UnidadeMedida { get; set; }
    }
}