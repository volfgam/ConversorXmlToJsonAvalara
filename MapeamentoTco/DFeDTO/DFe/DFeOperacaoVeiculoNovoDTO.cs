using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeOperacaoVeiculoNovoDTO
    {
        public int? tipoOperacao { get; set; }
        //0 = Venda para concessionária
        //1 = Faturamento direto
        //2 = Venda direta
        //3 = Venda da concessionária
        //9 = Outros
        public string cnpjConcessionaria { get; set; }
        public int? ufConcessionaria { get; set; }
        //11 = Rondônia
        //12 = Acre
        //13 = Amazonas
        //14 = Roraima
        //15 = Pará
        //16 = Amapá
        //17 = Tocantins
        //21 = Maranhão
        //22 = Piauí
        //23 = Ceará
        //24 = Rio Grande do Norte
        //25 = Paraiba
        //26 = Pernambuco
        //27 = Alagoas
        //28 = Sergipe
        //29 = Bahia
        //31 = Minas Gerais
        //32 = Espirito Santo
        //33 = Rio de Janeiro
        //35 = São Paulo
        //41 = Paraná
        //42 = Santa Catarina
        //43 = Rio Grande do Sul
        //50 = Mato Grosso do Sul
        //51 = Mato Grosso
        //52 = Goiás
        //53 = Distrito Federal
        //99 = Exportacao
        public string chassiVeiculo { get; set; }
    }
}