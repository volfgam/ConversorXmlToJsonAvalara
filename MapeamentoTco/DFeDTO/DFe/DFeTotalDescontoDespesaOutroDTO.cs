namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeTotalDescontoDespesaOutroDTO
    {
        public decimal valorDescontoLivreComercio { get; set; }
        public decimal valorDescontoZonaFranca { get; set; }
        public decimal valorTotalDesconto { get; set; }
        public decimal valorOutrasDespesas { get; set; }
        public decimal valorFrete { get; set; }
        public decimal valorSeguro { get; set; }
        public decimal valorDeducoes { get; set; }
    }
}