using System;
using System.Collections.Generic;
using TCO.WebApi.Abstractions.Enums;
using TCO.WebApi.Abstractions.Enums.DFe;

namespace TCO.WebApi.Abstractions.DTO.DFe
{
    public class DFeDTO
    {

        public DFeDTO()
        {
            itens = new List<DFeItemDTO>();
        }

        public string codigoEmpresa { get; set; }
        public string codigoContribuinte { get; set; }
        public ParceiroDTO parceiro { get; set; }
        public string inscricaoMunicipal { get; set; }
        public string inscricaoEstadualSubstituto { get; set; }
        public int? operacao { get; set; } 
        //0 = Entrada
        //1 = Saída
        public int? emitidaContribuinte { get; set; } 
        //0 = Não
        //1 = Sim
        public int? finalidadeNotaFiscal { get; set; } 
        //1 = Normal
        //2 = Substituição ou 3 = Normal com ajuste
        public string serie { get; set; }
        public int? subserie { get; set; }
        public int? modelo { get; set; }
        //1 = Nota fiscal
        //2 = Nota fiscal de venda a consumidor
        //4 = Nota fiscal de produtor
        //6 = Nota fiscal / conta de energia elétrica
        //7 = Nota fiscal de serviço de transporte
        //8 = Conhecimento de transporte rodoviário de cargas
        //9 = Conhecimento de transporte aquaviário de cargas
        //10 = Conhecimento aéreo
        //11 = Conhecimento de transporte ferroviário de cargas
        //13 = Bilhete de passagem rodoviário
        //14 = Bilhete de passagem aquaviário
        //15 = Bilhete de passagem e nota de bagagem
        //16 = Bilhete de passagem ferroviário
        //17 = Despacho de transporte
        //18 = Resumo de movimento diário
        //19 = Nota fiscal avulsa
        //20 = Ordem de coleta de cargas
        //21 = Nota fiscal de serviço de comunicação
        //22 = Nota fiscal de serviço de telecomunicação
        //23 = GNRE
        //24 = Autorização de carregamento e transporte
        //25 = Manifesto de carga
        //26 = Conhecimento de transporte multimodal de cargas
        //27 = Nota fiscal de transporte ferroviário de carga
        //28 = Nota fiscal / conta de fornecimento de gás canalizado
        //29 = Nota fiscal / conta de fornecimento de água canalizada
        //30 = Cupom fiscal
        //31 = Cupom fiscal de bilhete de passagem
        //55 = Nota fiscal eletrônica
        //57 = Conhecimento de transporte eletrônico – CTe
        //59 = Cupom fiscal eletrônico – CFe
        //60 = Cupom fiscal eletrônico CFe - ECF
        //65 = Nota fiscal eletrônica ao consumidor final – NFC-e
        //66 = Nota fiscal de energia elétrica eletrônica - NF3e
        //67 = Conhecimento de transporte eletrônico para outros serviços - CTe - OS
        //68 = Conhecimento de transporte de cargas avulso
        //69 = Nota fiscal de serviço
        //70 = Outros
        public int? modeloServico { get; set; }
        //1 = Nota fiscal de serviço
        //2 = Nota fiscal fatura de serviço
        //3 = Nota fiscal simplificada de serviço
        //4 = Nota fiscal de serviço eletrônica
        //5 = Recibo de pagamento de autônomo
        //6 = Fatura manual
        public long numeroDocumento { get; set; }
        public string chaveNFe { get; set; }
        public DateTime? dataEmissao { get; set; }
        public DateTime? dataEntradaSaida { get; set; }
        public DateTime? dataExecucaoServico { get; set; }
        public int? localExecucaoServico { get; set; } 
        //0 = Executado no país
        //1 = Executado no exterior
        public DateTime? periodoEscrituracao { get; set; }
        public int? situacao { get; set; }
        //0 = Documento regular
        //1 = Documento regular extemporâneo
        //2 = Documento cancelado
        //3 = Documento cancelado extemporâneo
        //4 = NFe denegada
        //5 = NFe numeração inutilizada
        //6 = Documento fiscal complementar
        //7 = Documento fiscal complementar extemporâneo
        //8 = Documento fiscal emitido por regime especial ou norma
        //99 = Documento fiscal bloqueado
        public DateTime? dataCancelamento { get; set; }
        public string motivoCancelamento { get; set; }        
        public int? tipoPagamento { get; set; }
        //0 = À vista
        //1 = À prazo
        //2 = Outros
        //9 = Sem pagamento
        public int? tipoConsumo { get; set; }
        //1 = Gás
        //2 = Energia elétrica
        //3 = Água canalizada
        //4 = Serviços de comunicação
        //5 = Serviços de telecomunicação
        public int? codigoClasseConsumo { get; set; }
        public int? tipoLigacao { get; set; }
        //1 = Monofásico
        //2 = Bifásico
        //3 = Trifásico
        public int? grupoTensao { get; set; }
        //1 = A1 - Alta tensão(230kV ou mais)
        //2 = A2 - Alta tensão(88 a 138kV)
        //3 = A3 - Alta tensão(69kV)
        //4 = A3a - Alta tensão(30kV a 44kV)
        //5 = A4 - Alta tensão(2,3kV a 25kV)
        //6 = AS - Alta tensão subterrâneo
        //7 = B1 - Residencial
        //8 = B1 - Residencial baixa renda
        //9 = B2 - Rural
        //10 = B2 - Cooperativa de eletrificação rural
        //11 = B2 - Serviço público de irrigação
        //12 = B3 - Demais classes
        //13 = B4a - Iluminação pública - rede de distribuição
        //14 = B4b - Iluminação pública - bulbo de lâmpada
        public string codigoObra { get; set; }
        public string codigoObraFilial { get; set; }
        public string codigoCNO { get; set; }
        public int? municipioRecolhimentoISSCodigoIBGE { get; set; }
        public int? municipioExecucaoServicoCodigoIBGE { get; set; }
        public int? operacaoConsumidorFinal { get; set; }
        //0 = Normal
        //1 = Consumidor final
        public int? presencaComprador { get; set; }
        //0 = Não se aplica
        //1 = Operação presencial
        //2 = Operação não presencial, pela internet
        //3 = Operação não presencial, teleatendimento
        //4 = NFC-e em operação com entrega em domicílio
        //5 = Operação presencial, fora do estabelecimento
        //9 = Operação não presencial, outros
        public int? inscricaoEstadualDestinatario { get; set; }
        //1 = Contribuinte ICMS (informar a inscrição estadual do destinatário)
        //2 = Contribuinte isento de inscrição no cadastro de contribuintes do ICMS
        //9 = Não contribuinte, que pode ou não possuir inscrição estadual no cadastro de contribuintes do ICMS
        public int? notaFiscalAtivo { get; set; }
        //0 = Não
        //1 = Sim
        public string codigoReferenciaIntegracao { get; set; }
        public string numeroLancamentoContabil { get; set; }

        public DFeTotalDTO totais { get; set; }
        public DFeTransporteDTO transporte { get; set; }
        public DFeCobrancaDTO cobranca { get; set; }
        public DFeInformacaoAdicionalDTO informacoesAdicionais { get; set; }
        
        public List<DFeItemDTO> itens { get; set; }
        public List<DFeParceiroDTO> parceiros { get; set; }
        public List<DFeImpostoRetidoDTO> impostosRetidos { get; set; }
        public List<DFeConhecimentoTransporteComplementoDTO> complementosConhecimentoTransporte { get; set; }
        public List<DFeConhecimentoTransporteNotaFiscalDTO> notasFiscaisConhecimentoTransporte { get; set; }
        public List<DFeObservacaoDTO> observacoes { get; set; }
    }
}