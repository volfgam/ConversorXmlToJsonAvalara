namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeImpostoINSSDTO
    {
        public decimal baseCalculoINSS { get; set; }
        public decimal aliquotaINSS { get; set; }
        public decimal valorINSS { get; set; }
        public decimal valorSubcontratadosINSS { get; set; }
        public decimal valorJuizoINSS { get; set; }
        public decimal valorAdicional { get; set; }
        public decimal valorAdicionalJuizo { get; set; }
        public decimal valorServicosAtivoAposentado15Anos { get; set; }
        public decimal valorServicosAtivoAposentado20Anos { get; set; }
        public decimal valorServicosAtivoAposentado25Anos { get; set; }
    }
}