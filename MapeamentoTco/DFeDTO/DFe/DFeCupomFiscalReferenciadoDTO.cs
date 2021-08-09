using System;

using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeCupomFiscalReferenciadoDTO
    {
        public ModeloEnum? modelo { get; set; }
        public int numeroDocumento { get; set; }
        public string serieFabricacaoECF { get; set; }
        public int? numeroCaixaECF { get; set; }
        public DateTime? dataEmissao { get; set; }
    }
}