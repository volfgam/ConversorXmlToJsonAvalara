using System;

namespace TCO.WebApi.Abstractions.DTO
{
    public class CentroCustoDto
    {
        public string Codigo { get; set; }
        public DateTime DataAtualizacaoSistemaContabil { get; set; }
        public string Descricao { get; set; }
    }
}