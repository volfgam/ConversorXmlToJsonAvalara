using System.Collections.Generic;
using TCO.WebApi.Abstractions.Enums;
using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeItemDTO
    {
        public int numeroSequencia { get; set; }
        public ItemDto item { get; set; }
        public string descricaoComplementar { get; set; }
        public string codigoFCI { get; set; }
        public string codigoServicoMunicipal { get; set; }
        public string descricaoServicoMunicipal { get; set; }
        public int? cfop { get; set; }
        public int? cfopEmitente { get; set; }
        public string cfopComplemento { get; set; }
        public NaturezaOperacaoDTO naturezaOperacao { get; set; }
        public string codigoInformacaoAdicional { get; set; }
        public UnidadeMedidaDTO unidadeMedida { get; set; }
        public decimal quantidade { get; set; }
        public decimal valorUnidade { get; set; }
        public decimal valorTotal { get; set; }
        public decimal valorDescontoComercial { get; set; }
        public decimal valorDescontoZonaFranca { get; set; }
        public decimal valorDespesaAduaneira { get; set; }
        public decimal valorFrete { get; set; }
        public decimal valorSeguro { get; set; }
        public decimal valorOutrasDespesas { get; set; }
        public decimal valorContabil { get; set; }
        public decimal valorDeducao { get; set; }
        public decimal valorMaterialTerceiro { get; set; }
        public int? movimentacaoFisica { get; set; }
        //0 = Não
        //1 = Sim
        public int? controleMovimentacaoFiscal { get; set; }
        //0 = Não
        //1 = Sim
        public string codigoEspecificoBeneficioFiscal { get; set; }
        public int? tipoDocumentoImportacao { get; set; }
        //0 = Declaração de importação
        //1 = Declaração simplificada de importação
        //2 = Declaração única de importação
        public string atoConcessionarioDrawback { get; set; }
        public string numeroDocumentoImportacao { get; set; }
        public string registroExportacao { get; set; }
        public int? origemCredito { get; set; }
        //0 = Operação no mercado interno
        //1 = Operação de importação
        public string codigoNaturezaBaseCalculoCreditos { get; set; }
        public int? rateioProporcionalCredito { get; set; }
        //0 = Não
        //1 = Sim
        public string naturezaReceita { get; set; }
        public int? naturezaFrete { get; set; }
        //0 = Operações de vendas, com ônus suportado pelo estabelecimento vendedor
        //1 = Operações de vendas, com ônus suportado pelo adquirente
        //2 = Operações de compras(bens para revenda, matériasprima e outros produtos, geradores de crédito)
        //3 = Operações de compras(bens para revenda, matériasprima e outros produtos, não geradores de crédito)
        //4 = Transferência de produtos acabados entre estabelecimentos da pessoa jurídica
        //5 = Transferência de produtos em elaboração entre estabelecimentos da pessoa jurídica
        //9 = Outros
        public int? tipoFrete { get; set; }
        //0 = Contratação do frete por conta do remetente(CIF)
        //1 = Contratação do frete por conta do destinatário(FOB)
        //2 = Contratação do frete por donta de terceiros
        //3 = Transporte próprio por conta do remetente
        //4 = Transporte próprio por conta do destinatário
        //5 = Sem ocorrência de transporte
        public string codigoContaContabilAnalitica { get; set; }
        public CentroCustoDto centroCusto { get; set; }
        public string categoriaDocumentoFiscal { get; set; }
        public string numeroPedidoCliente { get; set; }
        public int? linhaPedidoCliente { get; set; }
        public string codigoReferenciaIntegracao { get; set; }

        public DFeImpostoDTO imposto { get; set; }
        public DFeOperacaoDTO operacao { get; set; }

        public List<DFeRessarcimentoComplementoICMSSTDTO> ressarcimentosComplementosICMSST { get; set; }
        public List<DFeImportacaoDTO> importacoes { get; set; }
        public List<DFeItemInformacaoAdicionalDTO> informacoesAdicionais { get; set; }
    }
}