using TCO.WebApi.Abstractions.Enums;

namespace TCO.WebApi.Abstractions.DTO
{
    public class InformacaoComplementarDTO
    {
        public string codigo { get; set; }
        public string descricao { get; set; }
        public TipoInformacaoComplementarEnum? tipo { get; set; }
    }
}