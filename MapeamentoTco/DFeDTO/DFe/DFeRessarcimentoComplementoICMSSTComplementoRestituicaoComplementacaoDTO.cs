using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeRessarcimentoComplementoICMSSTComplementoRestituicaoComplementacaoDTO
    {
        public MotivoRestituicaoComplementacaoICMSEnum? motivoRestituicaoComplementacaoICMS { get; set; }
        public MotivoRessarcimentoEnum? motivoRessarcimento { get; set; }
        public decimal valorUnitarioICMSST { get; set; }
        public decimal valorUnitarioFCP { get; set; }
        public decimal valorUnitarioICMSSTComplementar { get; set; }
        public decimal valorUnitarioFCPSTComplementar { get; set; }
    }
}