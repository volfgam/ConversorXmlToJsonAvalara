using System;

using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeOperacaoMedicamentoDTO
    {
        public string numeroLoteFabricacao { get; set; }
        public decimal quantidadeItemLote { get; set; }
        public DateTime dataFabricacao { get; set; }
        public DateTime dataExpiracao { get; set; }
        public int? tipoCalculoICMS { get; set; }
        //0 = Base de cálculo referente ao preço tabelado ou preço máximo sugerido
        //1 = Base de cálculo - margem de valor agregado
        //2 = Base de cálculo referente à lista negativa
        //3 = Base de cálculo referente à lista positiva
        //4 = Base de cálculo referente à lista neutra
        //9 = Não se aplica ao produto
        public int? tipoProduto { get; set; }
        //0 = Similar
        //1 = Genérico
        //2 = Ético ou de marca
        public decimal valor { get; set; }
    }
}