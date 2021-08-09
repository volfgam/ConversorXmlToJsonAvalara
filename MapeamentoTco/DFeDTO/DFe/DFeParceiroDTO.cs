using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeParceiroDTO
    {
        public string nome { get; set; }
        public string nomeFantasia { get; set; }
        public TipoParceiroEnum? tipoParceiro { get; set; }
        public string cnpj { get; set; }
        public string cpf { get; set; }
        public string inscricaoEstadual { get; set; }
        public string inscricaoMunicipal { get; set; }
        public string inscricaoSuframa { get; set; }
        public int? codigoCNAE { get; set; }
        public Enums.CodigoCPRBEnum indCPRB { get; set; }
        public string endereco { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string bairro { get; set; }
        public string cep { get; set; }
        public int paisCodigoIBGE { get; set; }
        public int? municipioCodigoIBGE { get; set; }
        public string ddd { get; set; }
        public string telefone { get; set; }
        public string email { get; set; }
    }
}