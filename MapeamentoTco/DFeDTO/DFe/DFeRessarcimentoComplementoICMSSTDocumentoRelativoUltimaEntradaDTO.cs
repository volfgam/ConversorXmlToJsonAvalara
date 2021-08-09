using System;

using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeRessarcimentoComplementoICMSSTDocumentoRelativoUltimaEntradaDTO
    {
        public string chaveDocumento { get; set; }
        public ModeloEnum? modeloDocumento { get; set; }
        public string serieDocumento { get; set; }
        public long numeroDocumento { get; set; }
        public ParceiroDTO parceiro { get; set; }
        public DateTime dataEntrada { get; set; }
        public int numeroSequencia { get; set; }
        public decimal quantidade { get; set; }
        public decimal valorUnitario { get; set; }
        public decimal valorUnitarioBaseICMSST { get; set; }
        public decimal aliquotaICMSST { get; set; }
        public decimal valorUnitarioBaseICMS { get; set; }
        public decimal aliquotaICMS { get; set; }
        public decimal valorLimiteBase { get; set; }
        public decimal valorICMS { get; set; }
    }
}