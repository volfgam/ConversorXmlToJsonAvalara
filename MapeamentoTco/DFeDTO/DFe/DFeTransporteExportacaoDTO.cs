using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeTransporteExportacaoDTO
    {
        public int? paisEmbarqueCodigoIBGE { get; set; }
        public EstadoEnum? estadoEmbarque { get; set; }
        public string localEmbarque { get; set; }
        public string localDespacho { get; set; }
    }
}