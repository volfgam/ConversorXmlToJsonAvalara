using System;

using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeDocumentoFiscalReferenciadoDTO
    {
        public OperacaoEnum? operacao { get; set; }
        public EmitenteTituloEnum? emitente { get; set; }
        public ParceiroDTO parceiro { get; set; }
        public ModeloEnum? modelo { get; set; }
        public string serie { get; set; }
        public int? subserie { get; set; }
        public long numeroDocumento { get; set; }
        public DateTime dataEmissao { get; set; }
        public string chaveNFe { get; set; }
    }
}