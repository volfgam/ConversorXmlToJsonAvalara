using TCO.WebApi.Abstractions.Enums;

namespace TCO.WebApi.Abstractions.DTO
{
    public class ParceiroObraDTO
    {
        public string codigo { get; set; }
        public string nome { get; set; }
        public TipoPrestacaoServicoObraConstrucaoCivilEnum? tipoPrestacaoServicoObraConstrucaoCivil { get; set; }
        public string inscricaoMunicipal { get; set; }
        public string codigoCEI { get; set; }
    }
}