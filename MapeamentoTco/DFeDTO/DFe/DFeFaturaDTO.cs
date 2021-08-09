using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeFaturaDTO
    {
        public EmitenteTituloEnum? emitente { get; set; }
        public TituloCreditoEnum? tituloCredito { get; set; }
        public string numero { get; set; }
        public decimal valor { get; set; }
        public int? numeroParcelas { get; set; }
        public string descricaoComplementar { get; set; }
    }
}