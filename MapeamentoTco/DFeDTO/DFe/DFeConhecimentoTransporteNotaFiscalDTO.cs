using System;

using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeConhecimentoTransporteNotaFiscalDTO
    {
        public TipoTransporteEnum? tipoTransporte { get; set; }
        public ModeloEnum? modelo { get; set; }
        public string serie { get; set; }
        public int numero { get; set; }
        public DateTime dataEmissao { get; set; }
        public decimal valorTotal { get; set; }
        public decimal valorMercadoria { get; set; }
        public int? quantidadeVolumes { get; set; }
        public decimal pesoBruto { get; set; }
        public decimal pesoLiquido { get; set; }
        public string despacho { get; set; }

        public DFeConhecimentoTransporteNotaFiscalEmpresaDTO remetente { get; set; }
        public DFeConhecimentoTransporteNotaFiscalEmpresaDTO destinatario { get; set; }
        public DFeConhecimentoTransporteNotaFiscalEmpresaDTO coleta { get; set; }
        public DFeConhecimentoTransporteNotaFiscalEmpresaDTO entrega { get; set; }
    }
}