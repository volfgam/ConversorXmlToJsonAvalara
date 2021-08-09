namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeImpostoDTO
    {
        public DFeImpostoICMSDTO icms { get; set; }
        public DFeImpostoICMSSTDTO icmsst { get; set; }
        public DFeImpostoIPIDTO ipi { get; set; }
        public DFeImpostoPISDTO pis { get; set; }
        public DFeImpostoCOFINSDTO cofins { get; set; }
        public DFeImpostoISSQNDTO issqn { get; set; }
        public DFeImpostoIIDTO ii { get; set; }
        public DFeImpostoINSSDTO inss { get; set; }
    }
}