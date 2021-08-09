using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeProcessoReferenciadoDTO
    {
        public OrigemProcessoEnum? origem { get; set; }
        public string numero { get; set; }
    }
}