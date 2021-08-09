namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeTotalDTO
    {
        public DFeTotalICMSDTO icms { get; set; }
        public DFeTotalICMSSTDTO icmsst { get; set; }
        public DFeTotalIPIDTO ipi { get; set; }
        public DFeTotalPISDTO pis { get; set; }
        public DFeTotalCOFINSDTO cofins { get; set; }
        public DFeTotalINSSDTO inss { get; set; }
        public DFeTotalISSQNDTO issqn { get; set; }
        public DFeTotalIRRFDTO irrf { get; set; }
        public DFeTotalDescontoDespesaOutroDTO descontoDespesaOutros { get; set; }

        public decimal valorMercadorias { get; set; }
        public decimal valorServicos { get; set; }
        public decimal valorDocumento { get; set; }
    }
}