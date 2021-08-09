namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeImpostoICMSDIFALDTO
    {
        public decimal valorBaseICMSDIFAL { get; set; }
        public decimal aliquotaDestinoICMS { get; set; }
        public decimal aliquotaICMSDIFAL { get; set; }
        public decimal valorICMSDIFAL { get; set; }
        public int percentualPartilha { get; set; }
        public decimal valorDestinoICMS { get; set; }
        public decimal valorOrigemICMS { get; set; }
        public decimal percentualFCP { get; set; }
        public decimal valorICMSFCP { get; set; }
    }
}