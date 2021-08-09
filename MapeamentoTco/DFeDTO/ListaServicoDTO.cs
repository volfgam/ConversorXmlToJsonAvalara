using TCO.WebApi.Abstractions.Enums;

namespace TCO.WebApi.Abstractions.DTO
{
    public class ListaServicoDTO
    {
        public TipoServicoEnum? tipoServico { get; set; }
        public int codigo { get; set; }
    }
}