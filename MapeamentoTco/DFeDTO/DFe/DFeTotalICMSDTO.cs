namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeTotalICMSDTO
    {
        public decimal valorBaseICMS { get; set; }
        public decimal valorICMS { get; set; }
        public decimal valorBaseICMSReduzido { get; set; }
        public decimal valorFCPUFDestino { get; set; }
        public decimal valorICMSUFDestino { get; set; }
        public decimal valorICMSUFRemetente { get; set; }
    }
}