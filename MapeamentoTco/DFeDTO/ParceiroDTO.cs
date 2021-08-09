using TCO.WebApi.Abstractions.Enums;

namespace TCO.WebApi.Abstractions.DTO
{
    public class ParceiroDTO
    {
        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Cnpj { get; set; }
        public string Codigo { get; set; }
        public int? CodigoCNAE { get; set; }
        public string Complemento { get; set; }
        public string Cpf { get; set; }
        public string Ddd { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public CodigoCPRBEnum? IndCPRB { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string InscricaoSuframa { get; set; }
        public int? MunicipioCodigoIBGE { get; set; }
        public string Nome { get; set; }
        public string NomeFantasia { get; set; }
        public string Numero { get; set; }
        public ParceiroObraDTO[] Obras { get; set; }
        public int? PaisCodigoIBGE { get; set; }
        public string Telefone { get; set; }
    }
}