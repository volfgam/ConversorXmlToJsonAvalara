namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeInformacaoAdicionalDTO
    {
        public InformacaoComplementarDTO informacaoComplementar { get; set; }
        public string descricaoComplementar { get; set; }

        public DFeProcessoReferenciadoDTO[] processosReferenciados { get; set; }
        public DFeDocumentoArrecadacaoReferenciadoDTO[] documentosArrecadacaoReferenciados { get; set; }
        public DFeDocumentoFiscalReferenciadoDTO[] documentosFiscaisReferenciados { get; set; }
        public DFeCupomFiscalReferenciadoDTO[] cuponsFiscaisReferenciados { get; set; }
        public DFeLocalColetaEntregaDTO localColetaEntrega { get; set; }
    }
}