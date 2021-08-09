using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeImpostoIPIDTO
    {
        public int? periodoApuracaoIPI { get; set; }
        //0 = Mensal
        //1 = Decendial
        public int? situacaoTributariaIPI { get; set; }
        //0 = Entrada com recuperação de crédito
        //1 = Entrada tributada com alíquota zero
        //2 = Entrada isenta
        //3 = Entrada não-tributada
        //4 = Entrada imune
        //5 = Entrada com suspensão
        //49 = Outras entradas
        //50 = Saída tributada
        //51 = Saída tributada com alíquota zero
        //52 = Saída isenta
        //53 = Saída não-tributada
        //54 = Saída imune
        //55 = Saída com suspensão
        //99 = Outras saídas
        public decimal baseCalculoIPI { get; set; }
        public decimal aliquotaIPI { get; set; }
        public decimal quantidadePautadaIPI { get; set; }
        public decimal valorPautadoIPI { get; set; }
        public decimal valorIPI { get; set; }
        public decimal valorNaoTributadoIPI { get; set; }
        public decimal valorDevolvidoIPI { get; set; }
        public decimal valorBaseTributadoIPI { get; set; }
        public decimal valorBaseIsentoIPI { get; set; }
        public decimal valorBaseOutrosIPI { get; set; }
        public string seloControleIPI { get; set; }
        public int? quantidadeSeloIPI { get; set; }
        public string enquandramentoLegalIPI { get; set; }
        public string classeEnquadramentoIPI { get; set; }
    }
}