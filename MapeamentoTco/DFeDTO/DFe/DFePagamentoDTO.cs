using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFePagamentoDTO
    {
        public int numeroSequencia { get; set; }
        public FormaPagamentoEnum? formaPagamento { get; set; }
        public decimal valorPagamento { get; set; }
        public decimal valorTroco { get; set; }
        public TipoIntegracaoPagamentoEnum? tipoIntegracao { get; set; }
        public string cnpjCredenciadoraCartao { get; set; }
        public BandeiraOperadoraCartaoEnum? bandeiraOperadoraCartao { get; set; }
        public string numeroAutorizacaoOperacaoCartao { get; set; }
    }
}