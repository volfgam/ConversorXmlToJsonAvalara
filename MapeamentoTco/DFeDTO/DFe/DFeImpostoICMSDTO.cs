using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeImpostoICMSDTO
    {
        public int? situacaoTributariaICMSTabA { get; set; }
        //0 = Nacional
        //1 = Estrangeira - importação direta
        //2 = Estrangeira - adquirida no mercado interno
        //3 = Nacional - mercadoria ou bem com conteúdo de importação superior a 40% (quarenta por cento)
        //4 = Nacional - produção em conformidade ppb dl nº 288/67, leis 8.248/91,8.387/91,10.176/01 e 11.484/07
        //5 = Nacional - mercadoria ou bem com conteúdo de importação inferior ou igual a 40% (quarenta por cento)
        //6 = Estrangeira - importação direta, sem similar nacional, constante em lista de resolução camex
        //7 = Estrangeira - adquirida no mercado interno, sem similar nacional, constante em lista de res.camex
        //8 = Nacional, mercadoria ou bem com conteúdo de importação superior a 70%
        public int? situacaoTributariaICMSTabB { get; set; }
        //0 = Tributada integralmente
        //10 = Tributada e com cobrança do icms por substituição tributária
        //20 = Com redução de base de cálculo
        //30 = Isenta ou não tributada e com cobrança do icms por substituição tributária
        //40 = Isenta
        //41 = Não tributada
        //50 = Suspensão
        //51 = Diferimento
        //60 = Icms cobrado anteriormente por substituição tributária
        //70 = Com redução de base de cálculo e cobrança do icms por substituição tributária
        //90 = Outras
        public decimal baseCalculoICMS { get; set; }
        public decimal aliquotaICMS { get; set; }
        public decimal valorICMS { get; set; }
        public decimal aliquotaReducaoICMS { get; set; }
        public decimal valorReduzidoICMS { get; set; }
        public decimal valorBaseTributadoICMS { get; set; }
        public decimal valorBaseIsentoICMS { get; set; }
        public decimal valorBaseOutrosICMS { get; set; }

        public DFeImpostoICMSAtivoPermanenteDTO ativoPermanente { get; set; }
        public DFeImpostoICMSDIFALDTO difal { get; set; }
        public DFeImpostoICMSCreditoSimplesNacionalDTO creditoSimplesNacional { get; set; }
        public DFeImpostoICMSDesoneradoDTO desonerado { get; set; }
        public DFeImpostoICMSDiferidoDTO diferido { get; set; }
    }
}