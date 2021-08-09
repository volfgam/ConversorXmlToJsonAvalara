using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeOperacaoArmaDTO
    {
        public int? tipoArma { get; set; }
        //0 = Uso permitido
        //1 = Uso restrito
        public string numeroSerieFabricacao { get; set; }
        public string descricao { get; set; }
    }
}