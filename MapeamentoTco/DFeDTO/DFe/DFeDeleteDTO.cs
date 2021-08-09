using System;

using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeDeleteDTO
    {
        public string codigoEmpresa { get; set; }
        public string codigoContribuinte { get; set; }
        public string codigoParceiro { get; set; }
        public string codigoReferenciaIntegracao { get; set; }
        public OperacaoEnum? operacao { get; set; }
        public ModeloEnum? modelo { get; set; }
        public long numeroDocumento { get; set; }
        public string serie { get; set; }
        public DateTime? dataEmissao { get; set; }
    }
}