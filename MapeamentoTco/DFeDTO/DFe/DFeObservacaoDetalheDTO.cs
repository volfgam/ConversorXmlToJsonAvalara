namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeObservacaoDetalheDTO
    {
        public int? numeroSequencia { get; set; }
        public string codigoAjusteBeneficio { get; set; }
        public ItemDto item { get; set; }
        public decimal baseCalculoICMS { get; set; }
        public decimal aliquotaICMS { get; set; }
        public decimal valorICMS { get; set; }
        public decimal valorOutros { get; set; }
        public string descricaoComplementar { get; set; }
    }
}