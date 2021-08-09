namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeRessarcimentoComplementoICMSSTDTO
    {
        public DFeRessarcimentoComplementoICMSSTDocumentoRelativoUltimaEntradaDTO documentoRelativoUltimaEntrada { get; set; }
        public DFeRessarcimentoComplementoICMSSTDocumentoRetencaoDTO documentoRetencao { get; set; }
        public DFeRessarcimentoComplementoICMSSTComplementoDTO complemento { get; set; }
        public DFeRessarcimentoComplementoICMSSTEstoqueDTO estoque { get; set; }
        public DFeRessarcimentoComplementoICMSSTComplementoRestituicaoComplementacaoDTO complementoRestituicaoComplementacao { get; set; }
    }
}