namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeCobrancaDTO
    {
        public DFeFaturaDTO fatura { get; set; }
        public DFeParcelaDTO[] parcelas { get; set; }
        public DFePagamentoDTO[] pagamentos { get; set; }
    }
}