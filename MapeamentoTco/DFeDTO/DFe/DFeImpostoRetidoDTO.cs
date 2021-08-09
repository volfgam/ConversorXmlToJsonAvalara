using System;

using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeImpostoRetidoDTO
    {
        public TipoImpostoRetidoEnum? tipoImposto { get; set; }
        public string codigoReceita { get; set; }
        public DateTime? dataVencimento { get; set; }
        public DateTime? dataPagamento { get; set; }
        public decimal valorBaseRetencao { get; set; }
        public decimal aliquotaRetencao { get; set; }
        public decimal valorRetido { get; set; }
        public CondicaoPessoaJuridicaEnum? condicaoPessoaJuridica { get; set; }
        public int? sequenciaItem { get; set; }
    }
}