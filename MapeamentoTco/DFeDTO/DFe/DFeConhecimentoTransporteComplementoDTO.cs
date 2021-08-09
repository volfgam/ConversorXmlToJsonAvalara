using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeConhecimentoTransporteComplementoDTO
    {
        public ParceiroDTO parceiroConsignatario { get; set; }
        public ParceiroDTO parceiroRedespeacho { get; set; }
        public int? municipioOrigemCodigoIBGE { get; set; }
        public int? municipioDestinoCodigoIBGE { get; set; }
        public TipoFreteConhecimentoTransporteComplementoEnum? tipoFrete { get; set; }
        public EstadoEnum? estadoPlacaVeiculo { get; set; }
        public string placaVeiculo { get; set; }
        public decimal valorLiquidoFrete { get; set; }
        public decimal valorTotalFrete { get; set; }
        public decimal valorSECCAT { get; set; }
        public decimal valorDespacho { get; set; }
        public decimal valorPedagio { get; set; }
        public decimal valorOutros { get; set; }
    }
}