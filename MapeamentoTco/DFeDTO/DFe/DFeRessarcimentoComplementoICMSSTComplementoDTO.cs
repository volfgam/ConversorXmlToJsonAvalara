using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeRessarcimentoComplementoICMSSTComplementoDTO
    {
        public ResponsavelRetencaoEnum? responsavelRetencao { get; set; }
        public ModeloArrecadacaoEnum? modeloArrecadacao { get; set; }
        public string numeroDocumentoArrecadacao { get; set; }
        public decimal quantidadeConvertida { get; set; }
        public UnidadeMedidaDTO unidadeMedidaConversao { get; set; }
        public decimal valorUnitarioConvertido { get; set; }
        public decimal valorUnitarioICMSConvertido { get; set; }
        public decimal valorUnitarioBaseICMSSTConvertido { get; set; }
        public decimal valorUnitarioICMSSTConvertido { get; set; }
        public decimal valorUnitarioFCPSTConvertido { get; set; }
    }
}