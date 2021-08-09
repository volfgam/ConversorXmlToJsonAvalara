namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeObservacaoDTO
    {
        public ObservacaoLancamentoFiscalDTO observacaoLancamentoFiscal { get; set; }

        public DFeObservacaoDetalheDTO[] detalhes { get; set; }
    }
}