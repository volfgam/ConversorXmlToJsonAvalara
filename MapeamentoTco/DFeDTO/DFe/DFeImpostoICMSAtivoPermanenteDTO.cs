using TCO.WebApi.Abstractions.Enums;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeImpostoICMSAtivoPermanenteDTO
    {
        public YesNoEnum? itemAtivo { get; set; }
        public decimal valorAtivoICMS { get; set; }
        public decimal valorAtivoICMSST { get; set; }
        public decimal valorAtivoICMSDIFAL { get; set; }
        public decimal valorAtivoICMSFrete { get; set; }
    }
}