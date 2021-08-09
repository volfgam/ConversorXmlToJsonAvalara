using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeTransporteDTO
    {
        public ParceiroDTO transportadora { get; set; }
        public string placaVeiculo { get; set; }
        public string viaTransporte { get; set; }
        public string especieVolume { get; set; }
        public decimal quantidade { get; set; }
        public decimal pesoBruto { get; set; }
        public decimal pesoLiquido { get; set; }
        public string marca { get; set; }
        public string numero { get; set; }
        public EstadoEnum? estado { get; set; }
        public TipoFreteEnum? tipoFrete { get; set; }
        public NaturezaFreteEnum? naturezaFrete { get; set; }
        public TipoCTeEnum? tipoCTe { get; set; }
        public string chaveCTe { get; set; }
        public string ChaveCTeReferencia { get; set; }

        public DFeTransporteExportacaoDTO exportacao { get; set; }
    }
}