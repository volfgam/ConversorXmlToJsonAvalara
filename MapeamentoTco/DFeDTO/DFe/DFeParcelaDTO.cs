using System;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeParcelaDTO
    {
        public int? numeroParcela { get; set; }
        public DateTime? dataVencimento { get; set; }
        public DateTime? dataPagamento { get; set; }
        public decimal valorPrincipal { get; set; }
        public decimal valorMulta { get; set; }
        public decimal valorJuros { get; set; }
        public decimal valorPago { get; set; }
    }
}