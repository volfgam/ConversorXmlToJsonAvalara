using System;

using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeRessarcimentoComplementoICMSSTDocumentoRetencaoDTO
    {
        public ModeloEnum? modelo { get; set; }
        public string chaveDocumento { get; set; }
        public string serieDocumento { get; set; }
        public long? numeroDocumento { get; set; }
        public ParceiroDTO parceiro { get; set; }
        public int? numeroSequencia { get; set; }        
        public DateTime? dataEmissao { get; set; }
    }
}