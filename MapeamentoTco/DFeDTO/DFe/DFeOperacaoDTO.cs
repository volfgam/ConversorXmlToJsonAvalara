namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeOperacaoDTO
    {
        public DFeOperacaoArmaDTO[] armas { get; set; }
        public DFeOperacaoMedicamentoDTO[] medicamentos { get; set; }        
        public DFeOperacaoVeiculoNovoDTO[] veiculos { get; set; }
    }
}