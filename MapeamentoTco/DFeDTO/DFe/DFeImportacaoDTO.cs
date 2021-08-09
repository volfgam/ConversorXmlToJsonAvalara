using System;

using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeImportacaoDTO
    {
        public int numeroSequencia { get; set; }
        public string numeroDI { get; set; }
        public DateTime dataDI { get; set; }
        public DateTime dataDesembaraco { get; set; }
        public EstadoEnum? ufDesembaraco { get; set; }
        public string localDesembarque { get; set; }
        public ParceiroDTO exportador { get; set; }
        public string cnpjIntermediario { get; set; }
        public string atoDrawback { get; set; }

        public DFeImportacaoAdicaoDTO adicao { get; set; }
    }
}