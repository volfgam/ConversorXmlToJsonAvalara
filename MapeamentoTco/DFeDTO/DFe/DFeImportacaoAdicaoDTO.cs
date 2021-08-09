using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeImportacaoAdicaoDTO
    {
        public string numeroAdicao { get; set; }
        public int? numeroSequencia { get; set; }
        public ParceiroDTO fabricante { get; set; }
        public decimal valorDesconto { get; set; }
        public ViaTransporteEnum? viaTransporte { get; set; }
        public decimal valorAdicionalFrete { get; set; }
        public TipoIntermediarioEnum? tipoIntermediario { get; set; }
    }
}