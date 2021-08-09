using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeImpostoCOFINSDTO
    {
        public int? situacaoTributariaCOFINS { get; set; }
        //1 = Operação tributável com alíquota básica
        //2 = Operação tributável com alíquota diferenciada
        //3 = Operação tributável com alíquota por unidade de medida de produto
        //4 = Operação tributável monofásica - revenda a alíquota zero
        //5 = Operação tributável por substituição tributária
        //6 = Operação tributável a alíquota zero
        //7 = Operação isenta da contribuição
        //8 = Operação sem incidência da contribuição
        //9 = Operação com suspensão da contribuição
        //49 = Outras operações de saída
        //50 = Operação com direito a crédito - vinculada exclusivamente a receita tributada no mercado interno
        //51 = Operação com direito a crédito – vinculada exclusivamente a receita não tributada no mercado interno
        //52 = Operação com direito a crédito - vinculada exclusivamente a receita de exportação
        //53 = Operação com direito a crédito - vinculada a receitas tributadas e não-tributadas no mercado interno
        //54 = Operação com direito a crédito - vinculada a receitas tributadas no mercado interno e de exportação
        //55 = Operação com direito a crédito - vinculada a receitas não-tributadas no mercado interno e de exportação
        //56 = Operação com direito a crédito - vinculada a receitas tributadas e não-tributadas no mercado interno, e de exportação
        //60 = Crédito presumido - operação de aquisição vinculada exclusivamente a receita tributada no mercado interno
        //61 = Crédito presumido - operação de aquisição vinculada exclusivamente a receita não-tributada no mercado interno
        //62 = Crédito presumido - operação de aquisição vinculada exclusivamente a receita de exportação
        //63 = Crédito presumido - operação de aquisição vinculada a receitas tributadas e não-tributadas no mercado interno
        //64 = Crédito presumido - operação de aquisição vinculada a receitas tributadas no mercado interno e de exportação
        //65 = Crédito presumido - operação de aquisição vinculada a receitas não-tributadas no mercado interno e de exportação
        //66 = Crédito presumido - operação de aquisição vinculada a receitas tributadas e não-tributadas no mercado interno, e de exportação
        //67 = Crédito presumido - outras operações
        //70 = Operação de aquisição sem direito a crédito
        //71 = Operação de aquisição com isenção
        //72 = Operação de aquisição com suspensão
        //73 = Operação de aquisição a alíquota zero
        //74 = Operação de aquisição sem incidência da contribuição
        //75 = Operação de aquisição por substituição tributária
        //98 = Outras operações de entrada
        //99 = Outras operações
        public decimal baseCalculoCOFINS { get; set; }
        public decimal aliquotaCOFINS { get; set; }
        public decimal quantidadeBaseCalculoCOFINS { get; set; }
        public decimal valorPautadoCOFINS { get; set; }
        public decimal valorCOFINS { get; set; }
        public decimal valorImportacaoCOFINS { get; set; }
    }
}