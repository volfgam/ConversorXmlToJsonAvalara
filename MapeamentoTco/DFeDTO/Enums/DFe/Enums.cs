using System.ComponentModel;

using TCO.WebApi.Abstractions.Attributes;

namespace TCO.WebApi.Abstractions.Enums.DFe
{
    public enum OperacaoEnum
    {
        [Description("Entrada")] Entrada = 0,
        [Description("Saída")] Saida = 1
    }

    public enum FinalidadeNotaFiscalEnum
    {
        [Description("Normal")] Normal = 1,
        [Description("Substituição")] Substituicao = 2,
        [Description("Normal com ajuste")] NormalComAjuste = 3
    }

    public enum ModeloEnum
    {
        [EnumDbValue("01")] [Description("Nota fiscal")] Modelo01 = 1,
        [EnumDbValue("02")] [Description("Nota fiscal de venda a consumidor")] Modelo02 = 2,
        [EnumDbValue("04")] [Description("Nota fiscal de produtor")] Modelo04 = 4,
        [EnumDbValue("06")] [Description("Nota fiscal / conta de energia elétrica")] Modelo06 = 6,
        [EnumDbValue("07")] [Description("Nota fiscal de serviço de transporte")] Modelo07 = 7,
        [EnumDbValue("08")] [Description("Conhecimento de transporte rodoviário de cargas")] Modelo08 = 8,
        [EnumDbValue("09")] [Description("Conhecimento de transporte aquaviário de cargas")] Modelo09 = 9,
        [EnumDbValue("10")] [Description("Conhecimento aéreo")] Modelo10 = 10,
        [EnumDbValue("11")] [Description("Conhecimento de transporte ferroviário de cargas")] Modelo11 = 11,
        [EnumDbValue("13")] [Description("Bilhete de passagem rodoviário")] Modelo13 = 13,
        [EnumDbValue("14")] [Description("Bilhete de passagem aquaviário")] Modelo14 = 14,
        [EnumDbValue("15")] [Description("Bilhete de passagem e nota de bagagem")] Modelo15 = 15,
        [EnumDbValue("16")] [Description("Bilhete de passagem ferroviário")] Modelo16 = 16,
        [EnumDbValue("17")] [Description("Despacho de transporte")] Modelo17 = 17,
        [EnumDbValue("18")] [Description("Resumo de movimento diário")] Modelo18 = 18,
        [EnumDbValue("1B")] [Description("Nota fiscal avulsa")] Modelo1B = 19,
        [EnumDbValue("20")] [Description("Ordem de coleta de cargas")] Modelo20 = 20,
        [EnumDbValue("21")] [Description("Nota fiscal de serviço de comunicação")] Modelo21 = 21,
        [EnumDbValue("22")] [Description("Nota fiscal de serviço de telecomunicação")] Modelo22 = 22,
        [EnumDbValue("23")] [Description("GNRE")] Modelo23 = 23,
        [EnumDbValue("24")] [Description("Autorização de carregamento e transporte")] Modelo24 = 24,
        [EnumDbValue("25")] [Description("Manifesto de carga")] Modelo25 = 25,
        [EnumDbValue("26")] [Description("Conhecimento de transporte multimodal de cargas")] Modelo26 = 26,
        [EnumDbValue("27")] [Description("Nota fiscal de transporte ferroviário de carga")] Modelo27 = 27,
        [EnumDbValue("28")] [Description("Nota fiscal / conta de fornecimento de gás canalizado")] Modelo28 = 28,
        [EnumDbValue("29")] [Description("Nota fiscal / conta de fornecimento de água canalizada")] Modelo29 = 29,
        [EnumDbValue("2D")] [Description("Cupom fiscal")] Modelo2D = 30,
        [EnumDbValue("2E")] [Description("Cupom fiscal de bilhete de passagem")] Modelo2E = 31,
        [EnumDbValue("55")] [Description("Nota fiscal eletrônica")] Modelo55 = 55,
        [EnumDbValue("57")] [Description("Conhecimento de transporte eletrônico – CTe")] Modelo57 = 57,
        [EnumDbValue("59")] [Description("Cupom fiscal eletrônico – CFe")] Modelo59 = 59,
        [EnumDbValue("60")] [Description("Cupom fiscal eletrônico CFe - ECF")] Modelo60 = 60,
        [EnumDbValue("65")] [Description("Nota fiscal eletrônica ao consumidor final – NFC-e")] Modelo65 = 65,
        [EnumDbValue("66")] [Description("Nota fiscal de energia elétrica eletrônica - NF3e")] Modelo66 = 66,
        [EnumDbValue("67")] [Description("Conhecimento de transporte eletrônico para outros serviços - CTe - OS")] Modelo67 = 67,
        [EnumDbValue("8B")] [Description("Conhecimento de transporte de cargas avulso")] Modelo8B = 68,
        [EnumDbValue("SV")] [Description("Nota fiscal de serviço")] ModeloSV = 69,
        [EnumDbValue("OT")] [Description("Outros")] ModeloOT = 70
    }

    public enum ModeloServicoEnum
    {
        [EnumDbValue("NFS")]  [Description("Nota fiscal de serviço")] ModeloNFS = 1,
        [EnumDbValue("NFFS")] [Description("Nota fiscal fatura de serviço")] ModeloNFFS = 2,
        [EnumDbValue("NFSS")] [Description("Nota fiscal simplificada de serviço")] ModeloNFSS = 3,
        [EnumDbValue("NFSE")] [Description("Nota fiscal de serviço eletrônica")] ModeloNFSE = 4,
        [EnumDbValue("RPA")]  [Description("Recibo de pagamento de autônomo")] ModeloRPA = 5,
        [EnumDbValue("FATM")] [Description("Fatura manual")] ModeloFATM = 6
    }

    public enum LocalExecucaoServicoEnum
    {
        [Description("Executado no país")] ExecutadoPais = 0,
        [Description("Executado no exterior")] ExecutadoExterior = 1
    }

    public enum SituacaoEnum
    {
        [EnumDbValue("00")] [Description("Documento regular")] DocumentoRegular = 0,
        [EnumDbValue("01")] [Description("Documento regular extemporâneo")] DocumentoRegularExtemporaneo = 1,
        [EnumDbValue("02")] [Description("Documento cancelado")] DocumentoCancelado = 2,
        [EnumDbValue("03")] [Description("Documento cancelado extemporâneo")] DocumentoCanceladoExtemporaneo = 3,
        [EnumDbValue("04")] [Description("NFe denegada")] NFeDenegada = 4,
        [EnumDbValue("05")] [Description("NFe numeração inutilizada")] NFeNumeracaoInutilizada = 5,
        [EnumDbValue("06")] [Description("Documento fiscal complementar")] DocumentoFiscalComplementar = 6,
        [EnumDbValue("07")] [Description("Documento fiscal complementar extemporâneo")] DocumentoFiscalComplementarExtemporaneo = 7,
        [EnumDbValue("08")] [Description("Documento fiscal emitido por regime especial ou norma")] DocumentoFiscalEmitidoRegimeEspecialNorma = 8,
        [EnumDbValue("99")] [Description("Documento fiscal bloqueado")] DocumentoFiscalBloqueado = 99,
    }
        

    public enum TipoPagamentoEnum
    {
        [Description("À vista")] Vista = 0,
        [Description("À prazo")] Prazo = 1,
        [Description("Outros")] Outros = 2,
        [Description("Sem pagamento")] SemPagamento = 9
    }

    public enum TipoConsumoEnum
    {
        [EnumDbValue("GAS")] [Description("Gás")] Gas = 1,
        [EnumDbValue("ENERGIA ELETRICA")] [Description("Energia elétrica")] EnergiaEletrica = 2,
        [EnumDbValue("AGUA CANALIZADA")] [Description("Água canalizada")] AguaCanalizada = 3,
        [EnumDbValue("SERV COMUNICACAO")] [Description("Serviços de comunicação")] ServicosComunicacao = 4,
        [EnumDbValue("SERV TELECOMUNICACAO")] [Description("Serviços de telecomunicação")] ServicosTelecomunicacao = 5
    }

    public enum TipoLigacaoEnum
    {
        [Description("Monofásico")] Monofasico = 1,
        [Description("Bifásico")] Bifasico = 2,
        [Description("Trifásico")] Trifasico = 3
    }

    public enum GrupoTensaoEnum
    {
        [EnumDbValue("01")] [Description("A1 - Alta tensão (230kV ou mais)")] GrupoTensao01 = 1,
        [EnumDbValue("02")] [Description("A2 - Alta tensão (88 a 138kV)")] GrupoTensao02 = 2,
        [EnumDbValue("03")] [Description("A3 - Alta tensão (69kV)")] GrupoTensao03 = 3,
        [EnumDbValue("04")] [Description("A3a - Alta tensão (30kV a 44kV)")] GrupoTensao04 = 4,
        [EnumDbValue("05")] [Description("A4 - Alta tensão (2,3kV a 25kV)")] GrupoTensao05 = 5,
        [EnumDbValue("06")] [Description("AS - Alta tensão subterrâneo")] GrupoTensao06 = 6,
        [EnumDbValue("07")] [Description("B1 - Residencial")] GrupoTensao07 = 7,
        [EnumDbValue("08")] [Description("B1 - Residencial baixa renda")] GrupoTensao08 = 8,
        [EnumDbValue("09")] [Description("B2 - Rural")] GrupoTensao09 = 9,
        [EnumDbValue("10")] [Description("B2 - Cooperativa de eletrificação rural")] GrupoTensao10 = 10,
        [EnumDbValue("11")] [Description("B2 - Serviço público de irrigação")] GrupoTensao11 = 11,
        [EnumDbValue("12")] [Description("B3 - Demais classes")] GrupoTensao12 = 12,
        [EnumDbValue("13")] [Description("B4a - Iluminação pública - rede de distribuição")] GrupoTensao13 = 13,
        [EnumDbValue("14")] [Description("B4b - Iluminação pública - bulbo de lâmpada")] GrupoTensao14 = 14
    }

    public enum OperacaoConsumidorFinalEnum
    {
        [Description("Normal")] Normal = 0,
        [Description("Consumidor final")] ConsumidorFinal = 1
    }

    public enum PresencaCompradorEnum
    {
        [Description("Não se aplica")] NaoAplica = 0,
        [Description("Operação presencial")] OperacaoPresencial = 1,
        [Description("Operação não presencial, pela internet")] OperacaoNaoPresencialPelaInternet = 2,
        [Description("Operação não presencial, teleatendimento")] OperacaoNaoPresencialTeleatendimento = 3,
        [Description("NFC-e em operação com entrega em domicílio")] NFCeOperacaoEntregaDomicilio = 4,
        [Description("Operação presencial, fora do estabelecimento")] OperacaoPresencialForaEstabelecimento = 5,
        [Description("Operação não presencial, outros")] OperacaoNaoPresencialOutros = 9
    }

    public enum InscricaoEstadualDestinatarioEnum
    {
        [Description("Contribuinte ICMS (informar a inscrição estadual do destinatário)")] ContribuinteICMS = 1,
        [Description("Contribuinte isento de inscrição no cadastro de contribuintes do ICMS")] ContribuinteIsento = 2,
        [Description("Não contribuinte, que pode ou não possuir inscrição estadual no cadastro de contribuintes do ICMS")] NaoContribuinte = 9
    }

    public enum TipoDocumentoImportacaoEnum
    {
        [Description("Declaração de importação")] DeclaracaoImportacao = 0,
        [Description("Declaração simplificada de importação")] DeclaracaoSimplificadaImportacao = 1,
        [Description("Declaração única de importação")] DeclaracaoUnicaImportacao = 2
    }

    public enum OrigemCreditoEnum
    {
        [Description("Operação no mercado interno")] OperacaoMercadoInterno = 0,
        [Description("Operação de importação")] OperacaoImportacao = 1
    }

    public enum NaturezaFreteEnum
    {
        [Description("Operações de vendas, com ônus suportado pelo estabelecimento vendedor")] NaturezaFrete0 = 0,
        [Description("Operações de vendas, com ônus suportado pelo adquirente")] NaturezaFrete1 = 1,
        [Description("Operações de compras (bens para revenda, matériasprima e outros produtos, geradores de crédito)")] NaturezaFrete2 = 2,
        [Description("Operações de compras (bens para revenda, matériasprima e outros produtos, não geradores de crédito)")] NaturezaFrete3 = 3,
        [Description("Transferência de produtos acabados entre estabelecimentos da pessoa jurídica")] NaturezaFrete4 = 4,
        [Description("Transferência de produtos em elaboração entre estabelecimentos da pessoa jurídica")] NaturezaFrete5 = 5,
        [Description("Outros")] NaturezaFrete9 = 9,
    }

    public enum TipoFreteEnum
    {
        [EnumDbValue("E")] [Description("Contratação do frete por conta do remetente (CIF)")] ContratacaoFreteRemetente = 0,
        [EnumDbValue("D")] [Description("Contratação do frete por conta do destinatário (FOB)")] ContratacaoFreteDestinario = 1,
        [EnumDbValue("T")] [Description("Contratação do frete por donta de terceiros")] ContratacaoFreteTerceiros = 2,
        [EnumDbValue("R")] [Description("Transporte próprio por conta do remetente")] TransportePropioRemetente = 3,
        [EnumDbValue("C")] [Description("Transporte próprio por conta do destinatário")] TransporteProprioDestinatario = 4,
        [EnumDbValue("S")] [Description("Sem ocorrência de transporte")] SemOcorrenciaTransporte = 5,
    }

    public enum TipoFreteConhecimentoTransporteComplementoEnum
    {
        [Description("Sem redespacho")] SemRedespacho = 0,
        [Description("Por conta do emitente")] PorContaEmitente = 1,
        [Description("Por conta do destinatário")] PorContaDestinatario = 2,
        [Description("Outros")] Outros = 9
    }

    public enum TipoCTeEnum
    {
        [Description("CT-e normal")] Normal = 0,
        [Description("CT-e de complemento de valores")] ComplementoValores = 1,
        [Description("CT-e emitido em hipótese de anulação de débito")] EmitidoHipoteseAnulacaoDebito = 2
    }

    public enum EmitenteTituloEnum
    {
        [Description("Entrada")] Entrada = 0,
        [Description("Saída")] Saida = 1
    }

    public enum TituloCreditoEnum
    {
        [EnumDbValue("00")] [Description("Duplicata")] Duplicata = 0,
        [EnumDbValue("01")] [Description("Cheque")] Cheque = 1,
        [EnumDbValue("02")] [Description("Promissória")] Promissoria = 2,
        [EnumDbValue("03")] [Description("Recibo")] Recibo = 3,
        [EnumDbValue("99")] [Description("Outros")] Outros = 99
    }

    public enum FormaPagamentoEnum
    {
        [EnumDbValue("01")] [Description("Dinheiro")] Dinheiro = 1,
        [EnumDbValue("02")] [Description("Cheque")] Cheque = 2,
        [EnumDbValue("03")] [Description("Cartão de crédito")] CartaoCredito = 3,
        [EnumDbValue("04")] [Description("Cartão de débito")] CartaoDebito = 4,
        [EnumDbValue("05")] [Description("Crédito loja")] CreditoLoja = 5,
        [EnumDbValue("10")] [Description("Vale alimentação")] ValeAlimentacao = 10,
        [EnumDbValue("11")] [Description("Vale refeição")] ValeRefeicao = 11,
        [EnumDbValue("12")] [Description("Vale presente")] ValePresente = 12,
        [EnumDbValue("13")] [Description("Vale combustível")] ValeCombustivel = 13,
        [EnumDbValue("14")] [Description("Duplicata mercantil")] DuplicataMercantil = 14,
        [EnumDbValue("15")] [Description("Boleto bancário")] BoletoBancário = 15,
        [EnumDbValue("90")] [Description("Sem pagamento")] SemPagamento = 90,
        [EnumDbValue("99")] [Description("Outros")] Outros = 99
    }

    public enum TipoIntegracaoPagamentoEnum
    {
        [Description("Não se aplica")] NaoAplica = 0,
        [Description("Pagamento integrado no sistema de automação da empresa")] PagamentoIntegradoSistemaAutomacaoEmpresa = 1,
        [Description("Pagamento não integrado com o sistema de automação da empresa")] PagamentoNaoIntegradoSistemaAutomacaoEmpresa = 2
    }

    public enum BandeiraOperadoraCartaoEnum
    {
        [EnumDbValue("00")] [Description("Não se aplica")] NaoAplica = 0,
        [EnumDbValue("01")] [Description("Visa")] Visa = 1,
        [EnumDbValue("02")] [Description("Mastercard")] Mastercard = 2,
        [EnumDbValue("03")] [Description("American Express")] AmericanExpress = 3,
        [EnumDbValue("04")] [Description("Sorocred")] Sorocred = 4,
        [EnumDbValue("05")] [Description("Dinners Club")] DinnersClub = 5,
        [EnumDbValue("06")] [Description("Elo")] Elo = 6,
        [EnumDbValue("07")] [Description("Hipercard")] Hipercard = 7,
        [EnumDbValue("08")] [Description("Aura")] Aura = 8,
        [EnumDbValue("09")] [Description("Cabal")] Cabal = 9,
        [EnumDbValue("99")] [Description("Outros")] Outros = 99
    }

    public enum SituacaoTributariaCOFINSEnum
    {
        [Description("Operação tributável com alíquota básica")] SituacaoTributaria1 = 1,
        [Description("Operação tributável com alíquota diferenciada")] SituacaoTributaria2 = 2,
        [Description("Operação tributável com alíquota por unidade de medida de produto")] SituacaoTributaria3 = 3,
        [Description("Operação tributável monofásica - revenda a alíquota zero")] SituacaoTributaria4 = 4,
        [Description("Operação tributável por substituição tributária")] SituacaoTributaria5 = 5,
        [Description("Operação tributável a alíquota zero")] SituacaoTributaria6 = 6,
        [Description("Operação isenta da contribuição")] SituacaoTributaria7 = 7,
        [Description("Operação sem incidência da contribuição")] SituacaoTributaria8 = 8,
        [Description("Operação com suspensão da contribuição")] SituacaoTributaria9 = 9,
        [Description("Outras operações de saída")] SituacaoTributaria49 = 49,
        [Description("Operação com direito a crédito - vinculada exclusivamente a receita tributada no mercado interno")] SituacaoTributaria50 = 50,
        [Description("Operação com direito a crédito – vinculada exclusivamente a receita não tributada no mercado interno")] SituacaoTributaria51 = 51,
        [Description("Operação com direito a crédito - vinculada exclusivamente a receita de exportação")] SituacaoTributaria52 = 52,
        [Description("Operação com direito a crédito - vinculada a receitas tributadas e não-tributadas no mercado interno")] SituacaoTributaria53 = 53,
        [Description("Operação com direito a crédito - vinculada a receitas tributadas no mercado interno e de exportação")] SituacaoTributaria54 = 54,
        [Description("Operação com direito a crédito - vinculada a receitas não-tributadas no mercado interno e de exportação")] SituacaoTributaria55 = 55,
        [Description("Operação com direito a crédito - vinculada a receitas tributadas e não-tributadas no mercado interno, e de exportação")] SituacaoTributaria56 = 56,
        [Description("Crédito presumido - operação de aquisição vinculada exclusivamente a receita tributada no mercado interno")] SituacaoTributaria60 = 60,
        [Description("Crédito presumido - operação de aquisição vinculada exclusivamente a receita não-tributada no mercado interno")] SituacaoTributaria61 = 61,
        [Description("Crédito presumido - operação de aquisição vinculada exclusivamente a receita de exportação")] SituacaoTributaria62 = 62,
        [Description("Crédito presumido - operação de aquisição vinculada a receitas tributadas e não-tributadas no mercado interno")] SituacaoTributaria63 = 63,
        [Description("Crédito presumido - operação de aquisição vinculada a receitas tributadas no mercado interno e de exportação")] SituacaoTributaria64 = 64,
        [Description("Crédito presumido - operação de aquisição vinculada a receitas não-tributadas no mercado interno e de exportação")] SituacaoTributaria65 = 65,
        [Description("Crédito presumido - operação de aquisição vinculada a receitas tributadas e não-tributadas no mercado interno, e de exportação")] SituacaoTributaria66 = 66,
        [Description("Crédito presumido - outras operações")] SituacaoTributaria67 = 67,
        [Description("Operação de aquisição sem direito a crédito")] SituacaoTributaria70 = 70,
        [Description("Operação de aquisição com isenção")] SituacaoTributaria71 = 71,
        [Description("Operação de aquisição com suspensão")] SituacaoTributaria72 = 72,
        [Description("Operação de aquisição a alíquota zero")] SituacaoTributaria73 = 73,
        [Description("Operação de aquisição sem incidência da contribuição")] SituacaoTributaria74 = 74,
        [Description("Operação de aquisição por substituição tributária")] SituacaoTributaria75 = 75,
        [Description("Outras operações de entrada")] SituacaoTributaria98 = 98,
        [Description("Outras operações")] SituacaoTributaria99 = 99
    }

    public enum SituacaoTributariaICMSTabAEnum
    {
        [Description("Nacional")] SituacaoTributaria0 = 0,
        [Description("Estrangeira - importação direta")] SituacaoTributaria1 = 1,
        [Description("Estrangeira - adquirida no mercado interno")] SituacaoTributaria2 = 2,
        [Description("Nacional - mercadoria ou bem com conteúdo de importação superior a 40% (quarenta por cento)")] SituacaoTributaria3 = 3,
        [Description("Nacional - produção em conformidade ppb dl nº 288/67,leis 8.248/91,8.387/91,10.176/01 e 11.484/07")] SituacaoTributaria4 = 4,
        [Description("Nacional - mercadoria ou bem com conteúdo de importação inferior ou igual a 40% (quarenta por cento)")] SituacaoTributaria5 = 5,
        [Description("Estrangeira - importação direta, sem similar nacional, constante em lista de resolução camex")] SituacaoTributaria6 = 6,
        [Description("Estrangeira - adquirida no mercado interno, sem similar nacional, constante em lista de res. camex")] SituacaoTributaria7 = 7,
        [Description("Nacional, mercadoria ou bem com conteúdo de importação superior a 70%")] SituacaoTributaria8 = 8
    }

    public enum SituacaoTributariaICMSTabBEnum
    {
        [EnumDbValue("00")] [Description("Tributada integralmente")] SituacaoTributaria0 = 0,
        [EnumDbValue("10")] [Description("Tributada e com cobrança do icms por substituição tributária")] SituacaoTributaria10 = 10,
        [EnumDbValue("20")] [Description("Com redução de base de cálculo")] SituacaoTributaria20 = 20,
        [EnumDbValue("30")] [Description("Isenta ou não tributada e com cobrança do icms por substituição tributária")] SituacaoTributaria30 = 30,
        [EnumDbValue("40")] [Description("Isenta")] SituacaoTributaria40 = 40,
        [EnumDbValue("41")] [Description("Não tributada")] SituacaoTributaria41 = 41,
        [EnumDbValue("50")] [Description("Suspensão")] SituacaoTributaria50 = 50,
        [EnumDbValue("51")] [Description("Diferimento")] SituacaoTributaria51 = 51,
        [EnumDbValue("60")] [Description("Icms cobrado anteriormente por substituição tributária")] SituacaoTributaria60 = 60,
        [EnumDbValue("70")] [Description("Com redução de base de cálculo e cobrança do icms por substituição tributária")] SituacaoTributaria70 = 70,
        [EnumDbValue("90")] [Description("Outras")] SituacaoTributaria90 = 90
    }

    public enum SituacaoTributariaIPIEnum
    {
        [EnumDbValue("00")] [Description("Entrada com recuperação de crédito")] SituacaoTributaria0 = 0,
        [EnumDbValue("01")] [Description("Entrada tributada com alíquota zero")] SituacaoTributaria1 = 1,
        [EnumDbValue("02")] [Description("Entrada isenta")] SituacaoTributaria2 = 2,
        [EnumDbValue("03")] [Description("Entrada não-tributada")] SituacaoTributaria3 = 3,
        [EnumDbValue("04")] [Description("Entrada imune")] SituacaoTributaria4 = 4,
        [EnumDbValue("05")] [Description("Entrada com suspensão")] SituacaoTributaria5 = 5,
        [EnumDbValue("49")] [Description("Outras entradas")] SituacaoTributaria49 = 49,
        [EnumDbValue("50")] [Description("Saída tributada")] SituacaoTributaria50 = 50,
        [EnumDbValue("51")] [Description("Saída tributada com alíquota zero")] SituacaoTributaria51 = 51,
        [EnumDbValue("52")] [Description("Saída isenta")] SituacaoTributaria52 = 52,
        [EnumDbValue("53")] [Description("Saída não-tributada")] SituacaoTributaria53 = 53,
        [EnumDbValue("54")] [Description("Saída imune")] SituacaoTributaria54 = 54,
        [EnumDbValue("55")] [Description("Saída com suspensão")] SituacaoTributaria55 = 55,
        [EnumDbValue("99")] [Description("Outras saídas")] SituacaoTributaria99 = 99
    }

    public enum SituacaoTributariaPISEnum
    {
        [Description("Operação tributável com alíquota básica")] SituacaoTributaria1 = 1,
        [Description("Operação tributável com alíquota diferenciada")] SituacaoTributaria2 = 2,
        [Description("Operação tributável com alíquota por unidade de medida de produto")] SituacaoTributaria3 = 3,
        [Description("Operação tributável monofásica - revenda a alíquota zero")] SituacaoTributaria4 = 4,
        [Description("Operação tributável por substituição tributária")] SituacaoTributaria5 = 5,
        [Description("Operação tributável a alíquota zero")] SituacaoTributaria6 = 6,
        [Description("Operação isenta da contribuição")] SituacaoTributaria7 = 7,
        [Description("Operação sem incidência da contribuição")] SituacaoTributaria8 = 8,
        [Description("Operação com suspensão da contribuição")] SituacaoTributaria9 = 9,
        [Description("Outras operações de saída")] SituacaoTributaria49 = 49,
        [Description("Operação com direito a crédito - vinculada exclusivamente a receita tributada no mercado interno")] SituacaoTributaria50 = 50,
        [Description("Operação com direito a crédito – vinculada exclusivamente a receita não tributada no mercado interno")] SituacaoTributaria51 = 51,
        [Description("Operação com direito a crédito - vinculada exclusivamente a receita de exportação")] SituacaoTributaria52 = 52,
        [Description("Operação com direito a crédito - vinculada a receitas tributadas e não-tributadas no mercado interno")] SituacaoTributaria53 = 53,
        [Description("Operação com direito a crédito - vinculada a receitas tributadas no mercado interno e de exportação")] SituacaoTributaria54 = 54,
        [Description("Operação com direito a crédito - vinculada a receitas não-tributadas no mercado interno e de exportação")] SituacaoTributaria55 = 55,
        [Description("Operação com direito a crédito - vinculada a receitas tributadas e não-tributadas no mercado interno, e de exportação")] SituacaoTributaria56 = 56,
        [Description("Crédito presumido - operação de aquisição vinculada exclusivamente a receita tributada no mercado interno")] SituacaoTributaria60 = 60,
        [Description("Crédito presumido - operação de aquisição vinculada exclusivamente a receita não-tributada no mercado interno")] SituacaoTributaria61 = 61,
        [Description("Crédito presumido - operação de aquisição vinculada exclusivamente a receita de exportação")] SituacaoTributaria62 = 62,
        [Description("Crédito presumido - operação de aquisição vinculada a receitas tributadas e não-tributadas no mercado interno")] SituacaoTributaria63 = 63,
        [Description("Crédito presumido - operação de aquisição vinculada a receitas tributadas no mercado interno e de exportação")] SituacaoTributaria64 = 64,
        [Description("Crédito presumido - operação de aquisição vinculada a receitas não-tributadas no mercado interno e de exportação")] SituacaoTributaria65 = 65,
        [Description("Crédito presumido - operação de aquisição vinculada a receitas tributadas e não-tributadas no mercado interno, e de exportação")] SituacaoTributaria66 = 66,
        [Description("Crédito presumido - outras operações")] SituacaoTributaria67 = 67,
        [Description("Operação de aquisição sem direito a crédito")] SituacaoTributaria70 = 70,
        [Description("Operação de aquisição com isenção")] SituacaoTributaria71 = 71,
        [Description("Operação de aquisição com suspensão")] SituacaoTributaria72 = 72,
        [Description("Operação de aquisição a alíquota zero")] SituacaoTributaria73 = 73,
        [Description("Operação de aquisição sem incidência da contribuição")] SituacaoTributaria74 = 74,
        [Description("Operação de aquisição por substituição tributária")] SituacaoTributaria75 = 75,
        [Description("Outras operações de entrada")] SituacaoTributaria98 = 98,
        [Description("Outras operações")] SituacaoTributaria99 = 99
    }

    public enum ResponsavelRetencaoEnum
    {
        [Description("Remetente direto")] RemetenteDireto = 1,
        [Description("Remetente indireto")] RemetenteIndireto = 2,
        [Description("Próprio declarante")] ProprioDeclarante = 3
    }

    public enum ModeloArrecadacaoEnum
    {
        [Description("Documento estadual de arrecadação")] DocumentoEstadualArrecadacao = 0,
        [Description("GNRE")] GNRE = 1
    }

    public enum PeriodoApuracaoIPIEnum
    {
        [Description("Mensal")] Mensal = 0,
        [Description("Decendial")]Decendial = 1
    }

    public enum TipoParceiroEnum
    {
        [Description("Emitente")] Emitente = 0,
        [Description("Destinatário")] Destinatario = 1,
        [Description("Transportadora")] Transportadora = 2,
        [Description("Coleta")] Coleta = 3,
        [Description("Entrega")] Entrega = 4
    }

    public enum MotivoRessarcimentoEnum
    {
        [Description("Venda para outra UF")] VendaOutraUF = 1,
        [Description("Saída amparada por isenção ou não, incidência")] SaidaAmparadaIsencaoOuNao = 2,
        [Description("Perda ou deterioração")] PerdaDeterioracao = 3,
        [Description("Furto ou roubo")] FurtoRoubo = 4,
        [Description("Exportação")] Exportacao = 5,
        [Description("Venda interna para Simples Nacional")] VendaInternaSimplesNacional = 6,
        [Description("Outros")] Outros = 9
    }

    public enum MotivoRestituicaoComplementacaoICMSEnum
    {
        [EnumDbValue("MG100")] [Description("Operação ensejadora de ressarcimento ICMS-ST na hipótese do inciso I do art. 269 do RICMS")] MotivoRestituicaoComplementacaoMG100 = 1,
        [EnumDbValue("MG101")] [Description("Operação ensejadora de ressarcimento de ICMS-ST na hipótese inciso II do art. 269 do RICMS")] MotivoRestituicaoComplementacaoMG101 = 2,
        [EnumDbValue("MG102")] [Description("Operação ensejadora de ressarcimento de ICMS-ST na hipótese inciso III do art. 269 do RICMS, sem manutenção do crédito de operação própria")] MotivoRestituicaoComplementacaoMG102 = 3,
        [EnumDbValue("MG200")] [Description("Operação ensejadora de ressarcimento de ICMS-ST na hipótese inciso III do art. 269 do RICMS, com manutenção do crédito de operação própria")] MotivoRestituicaoComplementacaoMG200 = 4,
        [EnumDbValue("MG201")] [Description("Operação ensejadora de ressarcimento de ICMS-STna hipótese inciso IV do art. 269 do RICMS")] MotivoRestituicaoComplementacaoMG201 = 5,
        [EnumDbValue("MG300")] [Description("Operação ensejadora de complemento de ICMS-ST na hipótese do inciso I do art. 269 do RICMS")] MotivoRestituicaoComplementacaoMG300 = 6,
        [EnumDbValue("SC001")] [Description("Operação não ensejadora de ressarcimento, restituição ou complemento de ICMS-ST")] MotivoRestituicaoComplementacaoSC001 = 7,
        [EnumDbValue("SC101")] [Description("Operação ensejadora de restituição de ICMS-ST pela venda a consumidor final")] MotivoRestituicaoComplementacaoSC101 = 8,
        [EnumDbValue("SC102")] [Description("Operação ensejadora de restituição de ICMS-ST pela venda a contribuinte do simples nacional")] MotivoRestituicaoComplementacaoSC102 = 9,
        [EnumDbValue("SC201")] [Description("Operação ensejadora de ressarcimento de ICMS-ST pela venda para outra unidade da federação, com manutenção do crédito de operação própria")] MotivoRestituicaoComplementacaoSC201 = 10,
        [EnumDbValue("SC202")] [Description("Operação ensejadora de ressarcimento de ICMS-ST por outras hipóteses, sem manutenção do crédito de operação própria")] MotivoRestituicaoComplementacaoSC202 = 11,
        [EnumDbValue("SC301")] [Description("Operação ensejadora de complemento de ICMS-ST")] MotivoRestituicaoComplementacaoSC301 = 12,
        [EnumDbValue("SP000")] [Description("Operação não ensejadora de ressarcimento ou complemento de ICMS-ST")] MotivoRestituicaoComplementacaoSP000 = 13,
        [EnumDbValue("SP100")] [Description("Operação ensejadora de ressarcimento ICMS-ST na hipótese do inciso I do Art. 269 do RICMS")] MotivoRestituicaoComplementacaoSP100 = 14,
        [EnumDbValue("SP101")] [Description("Operação ensejadora de ressarcimento de ICMS-ST na hipótese inciso II do Art. 269 do RICMS")] MotivoRestituicaoComplementacaoSP101 = 15,
        [EnumDbValue("SP102")] [Description("Operação ensejadora de ressarcimento de ICMS-ST na hipótese inciso III do Art. 269 do RICMS, sem manutenção do crédito de operação própria")] MotivoRestituicaoComplementacaoSP102 = 16,
        [EnumDbValue("SP200")] [Description("Operação ensejadora de ressarcimento de ICMS-ST na hipótese inciso III do Art. 269 do RICMS, com manutenção do crédito de operação própria")] MotivoRestituicaoComplementacaoSP200 = 17,
        [EnumDbValue("SP201")] [Description("Operação ensejadora de ressarcimento de ICMS-ST na hipótese inciso IV do Art. 269 do RICMS")] MotivoRestituicaoComplementacaoSP201 = 18,
        [EnumDbValue("SP300")] [Description("Operação ensejadora de complemento de ICMS-ST na hipótese do inciso I do Art. 269 do RICMS")] MotivoRestituicaoComplementacaoSP300 = 19,
    }

    public enum ViaTransporteEnum
    {
        [Description("Marítima")] Maritima = 1,
        [Description("Fluvial")] Fluvial = 2,
        [Description("Lacustre")] Lacustre = 3,
        [Description("Aérea")] Aerea = 4,
        [Description("Postal")] Postal = 5,
        [Description("Ferroviária")] Ferroviaria = 6,
        [Description("Rodoviária")] Rodoviaria = 7,
        [Description("Conduto / Rede Transmissão")] ConutoRedeTransmissao = 8,
        [Description("Meios próprios")] MeiosProprios = 9,
        [Description("Entrada / Saída ficta")] EntradasaidaFicta = 10
    }

    public enum TipoIntermediarioEnum
    {
        [Description("Importação por conta própria")] ImportacaoContaPropria = 1,
        [Description("Importação por conta e ordem")] ImportacaoContaEOrdem = 2,
        [Description("Importação por encomenda")] ImportacaoEncomenda = 3
    }

    public enum TipoArmaEnum
    {
        [Description("Uso permitido")] UsoPermitido = 0,
        [Description("Uso restrito")] UsoRestrito = 1
    }

    public enum TipoCalculoICMSMedicamentoEnum
    {
        [Description("Base de cálculo referente ao preço tabelado ou preço máximo sugerido")] BaseCalculoPrecoTabeladoPrecoMaximo = 0,
        [Description("Base de cálculo - margem de valor agregado")] BaseCalculoMargemValorAgregado = 1,
        [Description("Base de cálculo referente à lista negativa")] BaseCalculoListaNegativa = 2,
        [Description("Base de cálculo referente à lista positiva")] BaseCalculoListaPositiva = 3,
        [Description("Base de cálculo referente à lista neutra")] BaseCalculoListaNeutra = 4,
        [Description("Não se aplica ao produto")] NaoAplicaProduto = 9
    }

    public enum TipoProdutoMedicamentoEnum
    {
        [Description("Similar")] Similar = 0,
        [Description("Genérico")] Generico = 1,
        [Description("Ético ou de marca")] EticoMarca = 2
    }

    public enum TipoOperacaoVeiculoEnum
    {
        [Description("Venda para concessionária")] VendaParaConcessionaria = 0,
        [Description("Faturamento direto")] FaturamentoDireto = 1,
        [Description("Venda direta")] VendaDireta = 2,
        [Description("Venda da concessionária")] VendaDaConcessionaria = 3,
        [Description("Outros")] Outros = 9
    }

    public enum EstadoEnum
    {
        [Description("Acre")] Acre = 12,
        [Description("Alagoas")] Alagoas = 27,
        [Description("Amapá")] Amapá = 16,
        [Description("Amazonas")] Amazonas = 13,
        [Description("Bahia")] Bahia = 29,
        [Description("Ceará")] Ceará = 23,
        [Description("Distrito Federal")] DistritoFederal = 53,
        [Description("Espirito Santo")] EspiritoSanto = 32,
        [Description("Goiás")] Goias = 52,
        [Description("Maranhão")] Maranhao = 21,
        [Description("Mato Grosso")] MatoGrosso = 51,
        [Description("Mato Grosso do Sul")] MatoGrossoSul = 50,
        [Description("Minas Gerais")] MinasGerais = 31,
        [Description("Pará")] Para = 15,
        [Description("Paraiba")] Paraiba = 25,
        [Description("Paraná")] Parana = 41,
        [Description("Pernambuco")] Pernambuco = 26,
        [Description("Piauí")] Piaui = 22,
        [Description("Rio de Janeiro")] RioJaneiro = 33,
        [Description("Rio Grande do Norte")] RioGrandeNorte = 24,
        [Description("Rio Grande do Sul")] RioGrandeSul = 43,
        [Description("Rondônia")] Rondonia = 11,
        [Description("Roraima")] Roraima = 14,
        [Description("Santa Catarina")] SantaCatarina = 42,
        [Description("São Paulo")] SaoPaulo = 35,
        [Description("Sergipe")] Sergipe = 28,
        [Description("Tocantins")] Tocantins = 17,
        [Description("Exportacao")] Exportacao = 99,
    }

    public enum TipoImpostoRetidoEnum
    {
        [EnumDbValue("COFINS")] [Description("COFINS")] COFINS = 1,
        [EnumDbValue("CSLL")] [Description("CSLL")] CSLL = 2,
        [EnumDbValue("IRRF")] [Description("IRRF")] IRRF = 3,
        [EnumDbValue("IPI")] [Description("IPI")] IPI = 4,
        [EnumDbValue("ISSQN")] [Description("ISSQN")] ISSQN = 5,
        [EnumDbValue("IRPJ")] [Description("IRPJ")] IRPJ = 6,
        [EnumDbValue("IOF")] [Description("IOF")] IOF = 7,
        [EnumDbValue("PIS")] [Description("PIS")] PIS = 8,
        [EnumDbValue("CPMF")] [Description("CPMF")] CPMF = 9,
        [EnumDbValue("CIDE")] [Description("CIDE")] CIDE = 10,
        [EnumDbValue("RET")] [Description("RET")] RET = 11,
        [EnumDbValue("CSRF")] [Description("CSRF")] CSRF = 12,
        [EnumDbValue("COSIRF")] [Description("COSIRF")] COSIRF = 13,
        [EnumDbValue("CPSSS")] [Description("CPSSS")] CPSSS = 14,
        [EnumDbValue("PIS/PASEP")] [Description("PIS/PASEP")] PISPASEP = 15,
        [EnumDbValue("RET/PAGAMENTO UNIFICADO DE TRIBUTOS")] [Description("RET/PAGAMENTO UNIFICADO DE TRIBUTOS")] RETPAGAMENTOUNIFICADOTRIBUTOS = 16,
        [EnumDbValue("PCC")] [Description("PCC")] PCC = 17,
        [EnumDbValue("INSS")] [Description("INSS")] INSS = 18
    }

    public enum CondicaoPessoaJuridicaEnum
    {
        [Description("Beneficiária da retenção / recolhimento")] BeneficiariaRetencaoRecolhimento = 0,
        [Description("Responsável pelo recolhimento")] ResponsavelRecolhimento = 1
    }

    public enum ModeloDocumentoArrecadacaoEnum
    {
        [Description("Documento estadual de arrecadação")] DocumentoEstadualArrecadacao = 0,
        [Description("GNRE")] GNRE = 1
    }

    public enum TipoTransporteEnum
    {
        [Description("Rodoviário")] Rodoviario = 0,
        [Description("Ferroviário")] Ferroviario = 1,
        [Description("Rodo-Ferroviário")] RodoFerroviario = 2,
        [Description("Aquaviário")] Aquiviario = 3,
        [Description("Dutoviário")] Dutoviario = 4,
        [Description("Aéreo")] Aereo = 5,
        [Description("Outros")] Outros = 9
    }

    public enum OrigemProcessoEnum
    {
        [Description("SEFAZ")] SEFAZ = 0,
        [Description("Justiça Federal")] JusticaFederal = 1,
        [Description("Justiça Estadual")] JusticaEstadual = 2,
        [Description("SECEX/SRF")] SECEXSRF = 3,
        [Description("Outros")] Outros = 9,
    }
}