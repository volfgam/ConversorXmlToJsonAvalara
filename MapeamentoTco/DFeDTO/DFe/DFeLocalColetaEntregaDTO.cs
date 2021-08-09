using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeLocalColetaEntregaDTO
    {
        public TipoTransporteEnum? tipoTransporte { get; set; }
        public string inscricaoEstadualContribuinteColeta { get; set; }
        public string cnpjContribuinteColeta { get; set; }
        public string cpfContribuinte { get; set; }
        public int? municipioColetaCodigoIBGE { get; set; }
        public string inscricaoEstadualContribuinteEntrega { get; set; }
        public string cnpjContribuinteEntrega { get; set; }
        public string cpfContribuinteEntrega { get; set; }
        public int? municipioEntregaCodigoIBGE { get; set; }
        public string nomeColeta { get; set; }
        public string enderecoColeta { get; set; }
        public string numeroColeta { get; set; }
        public string complementoColeta { get; set; }
        public string bairroColeta { get; set; }
        public string cepColeta { get; set; }
        public string telefoneColeta { get; set; }
        public string emailColeta { get; set; }
        public string nomeEntrega { get; set; }
        public string enderecoEntrega { get; set; }
        public string numeroEntrega { get; set; }
        public string complementoEntrega { get; set; }
        public string bairroEntrega { get; set; }
        public string cepEntrega { get; set; }
        public string telefoneEntrega { get; set; }
        public string emailEntrega { get; set; }
    }
}