namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeImpostoICMSSTDTO
    {
        public decimal baseCalculoICMSST { get; set; }
        public decimal aliquotaMarkup { get; set; }
        public decimal aliquotaICMSST { get; set; }
        public decimal valorICMSST { get; set; }
        public decimal valorNaoTributadoICMSST { get; set; }
        public decimal baseCalculoFCPST { get; set; }
        public decimal percentualFCPST { get; set; }
        public decimal valorFCPST { get; set; }
        public decimal baseCalculoRetidoFCPST { get; set; }
        public decimal percentualRetidoFCPST { get; set; }
        public decimal valorRetidoFCPST { get; set; }
    }
}