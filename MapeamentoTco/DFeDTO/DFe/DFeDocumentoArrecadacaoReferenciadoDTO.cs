using System;

using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeDocumentoArrecadacaoReferenciadoDTO
    {
        public ModeloDocumentoArrecadacaoEnum? modeloDocumento { get; set; }
        public EstadoEnum? estadoBeneficiario { get; set; }
        public DateTime dataVencimento { get; set; }
        public DateTime? dataPagamento { get; set; }
        public string numeroDocumento { get; set; }
        public string codigoAutenticacao { get; set; }
        public decimal valorDocumento { get; set; }
    }
}