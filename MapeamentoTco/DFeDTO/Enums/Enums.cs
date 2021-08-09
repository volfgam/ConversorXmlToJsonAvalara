using System.ComponentModel;

using TCO.WebApi.Abstractions.Attributes;

namespace TCO.WebApi.Abstractions.Enums
{
    public enum YesNoEnum
    {
        [EnumDbValue("N")] [Description("Não")] Nao = 0,
        [EnumDbValue("S")] [Description("Sim")] Sim = 1
    }

    public enum Yes0No1Enum
    {
        [EnumDbValue("1")] [Description("Não")] Nao = 0,
        [EnumDbValue("0")] [Description("Sim")] Sim = 1
    }

    public enum Yes1No0Enum
    {
        [EnumDbValue("0")] [Description("Não")] Nao = 0,
        [EnumDbValue("1")] [Description("Sim")] Sim = 1
    }

    public enum Yes1No2Enum
    {
        [EnumDbValue("2")] [Description("Não")] Nao = 0,
        [EnumDbValue("1")] [Description("Sim")] Sim = 1
    }

    public enum TipoItemEnum
    {
        [EnumDbValue("00")] [Description("Mercadoria para revenda")] TipoItem0 = 0,
        [EnumDbValue("01")] [Description("Matéria prima")] TipoItem1 = 1,
        [EnumDbValue("02")] [Description("Embalagem")] TipoItem2 = 2,
        [EnumDbValue("03")] [Description("Produto em processo")] TipoItem3 = 3,
        [EnumDbValue("04")] [Description("Produto acabado")] TipoItem4 = 4,
        [EnumDbValue("05")] [Description("Subproduto")] TipoItem5 = 5,
        [EnumDbValue("06")] [Description("Produto intermediário")] TipoItem6 = 6,
        [EnumDbValue("07")] [Description("Material de uso e consumo")] TipoItem7 = 7,
        [EnumDbValue("08")] [Description("Ativo imobilizado")] TipoItem8 = 8,
        [EnumDbValue("09")] [Description("Serviços")] TipoItem9 = 9,
        [EnumDbValue("10")] [Description("Outros insumos")] TipoItem10 = 10,
        [EnumDbValue("99")] [Description("Outras")] TipoItem99 = 99
    }

    public enum TipoInformacaoComplementarEnum
    {
        [Description("Processo referenciado")] ProcessoReferenciado = 1,
        [Description("Documento arrecadação referenciado")] DocArrecadacaoReferenciado = 2,
        [Description("Documento fiscal referenciado")] DocFiscalReferenciado = 3,
        [Description("Cupom fiscal referenciado")] CupomFiscalReferenciado = 4,
        [Description("Local de coleta de entrega")] LocalColetaEntrega = 5,
        [Description("Fisco")] Fisco = 99
    }

    public enum TipoServicoEnum
    {
        [Description("Serviços de informática e congêneres")] TipoServico1 = 1,
        [Description("Serviços de pesquisas e desenvolvimento de qualquer natureza")] TipoServico2 = 2,
        [Description("Serviços prestados mediante locação, cessão de direito de uso e congêneres")] TipoServico3 = 3,
        [Description("Serviços de saúde, assistência médica e congêneres")] TipoServico4 = 4,
        [Description("Serviços de medicina e assistência veterinária e congêneres")] TipoServico5 = 5,
        [Description("Serviços de cuidados pessoais, estética, atividades físicas e congêneres")] TipoServico6 = 6,
        [Description("Serviços relativos a engenharia, arquitetura, geologia, urbanismo, construção civil, manutenção, limpeza, meio ambiente, saneamento e congêneres")] TipoServico7 = 7,
        [Description("Serviços de educação, ensino, orientação pedagógica e educacional, instrução, treinamento e avaliação pessoal de qualquer grau ou natureza")] TipoServico8 = 8,
        [Description("Serviços relativos a hospedagem, turismo, viagens e congêneres")] TipoServico9 = 9,
        [Description("Serviços de intermediação e congêneres")] TipoServico10 = 10,
        [Description("Serviços de guarda, estacionamento, armazenamento, vigilância e congêneres")] TipoServico11 = 11,
        [Description("Serviços de diversões, lazer, entretenimento e congêneres")] TipoServico12 = 12,
        [Description("Serviços relativos a fonografia, fotografia, cinematografia e reprografia")] TipoServico13 = 13,
        [Description("Serviços relativos a bens de terceiros")] TipoServico14 = 14,
        [Description("Serviços relacionados ao setor bancário ou financeiro, inclusive aqueles prestados por instituições financeiras autorizadas a funcionar pela união ou por quem de direito")] TipoServico15 = 15,
        [Description("Serviços de transporte de natureza municipal")] TipoServico16 = 16,
        [Description("Serviços de apoio técnico, administrativo, jurídico, contábil, comercial e congêneres")] TipoServico17 = 17,
        [Description("Serviços de regulação de sinistros vinculados a contratos de seguros; inspeção e avaliação de riscos para cobertura de contratos de seguros; prevenção e gerência de riscos seguráveis e congêneres")] TipoServico18 = 18,
        [Description("Serviços de distribuição e venda de bilhetes e demais produtos de loteria, bingos, cartões, pules ou cupons de apostas, sorteios, prêmios, inclusive os decorrentes de títulos de capitalização e congêneres")] TipoServico19 = 19,
        [Description("Serviços portuários, aeroportuários, ferroportuários, de terminais rodoviários, ferroviários e metroviários")] TipoServico20 = 20,
        [Description("Serviços de registros públicos, cartorários e notariais")] TipoServico21 = 21,
        [Description("Serviços de exploração de rodovia ")] TipoServico22 = 22,
        [Description("Serviços de programação e comunicação visual, desenho industrial e congêneres ")] TipoServico23 = 23,
        [Description("Serviços de chaveiros, confecção de carimbos, placas, sinalização visual, banners, adesivos e congêneres ")] TipoServico24 = 24,
        [Description("Serviços funerários ")] TipoServico25 = 25,
        [Description("Serviços de coleta, remessa ou entrega de correspondências, documentos, objetos, bens ou valores, inclusive pelos correios e suas agências franqueadas; courrier e congêneres")] TipoServico26 = 26,
        [Description("Serviços de assistência social")] TipoServico27 = 27,
        [Description("Serviços de avaliação de bens e serviços de qualquer natureza")] TipoServico28 = 28,
        [Description("Serviços de biblioteconomia")] TipoServico29 = 29,
        [Description("Serviços de biologia, biotecnologia e química")] TipoServico30 = 30,
        [Description("Serviços técnicos em edificações, eletrônica, eletrotécnica, mecânica, telecomunicações e congêneres")] TipoServico31 = 31,
        [Description("Serviços de desenhos técnicos")] TipoServico32 = 32,
        [Description("Serviços de desembaraço aduaneiro, comissários, despachantes e congêneres")] TipoServico33 = 33,
        [Description("Serviços de investigações particulares, detetives e congêneres")] TipoServico34 = 34,
        [Description("Serviços de reportagem, assessoria de imprensa, jornalismo e relações públicas")] TipoServico35 = 35,
        [Description("Serviços de meteorologia")] TipoServico36 = 36,
        [Description("Serviços de artistas, atletas, modelos e manequins")] TipoServico37 = 37,
        [Description("Serviços de museologia")] TipoServico38 = 38,
        [Description("Serviços de ourivesaria e lapidação")] TipoServico39 = 39,
        [Description("Serviços relativos a obras de arte sob encomenda")] TipoServico40 = 40
    }

    public enum TipoPrestacaoServicoObraConstrucaoCivilEnum
    {
        [Description("Não é obra de construção civil ou não está sujeita a matrícula de obra")] PrestacaoServicoObraConstrucaoCivil0 = 0,
        [Description("Obra de construção civil - empreitada total")] PrestacaoServicoObraConstrucaoCivil1 = 1,
        [Description("Obra de construção civil - empreitada parcial")] PrestacaoServicoObraConstrucaoCivil2 = 2
    }

    public enum JobTypeEnum
    {
        [Description("Arquivo Digital")] ArquivoDigitalGeracao = 1,
        [Description("Apuração Imposto")] ProcessoApuracaoImposto = 4,
        [Description("Importação XML Manual")] ImportacaoXmlManual = 5,
        [Description("Importação XML Automática")] ImportacaoXmlAutomatica = 6,
        [Description("CIAP")] CIAP = 7,
        [Description("PIS/COFINS")] PISCOFINS = 8,
        [Description("Receita PIS/COFINS")] ReceitaPISCOFINS = 9,
        [Description("Execução Auditoria")] ExecucaoAuditoria = 10,
        [Description("Importação FCI")] ImportacaoFCI = 11,
        [Description("GPS")] GPS = 12,
        [Description("Cálculo de Saldo Contábil - Centro de Custo")] CalculoSaldoContabilCentroCusto = 14,
        [Description("Limpeza - CIAP")] LimpezaCIAP = 15,
        [Description("Limpeza - Cupons Fiscais")] LimpezaCuponsFiscais = 16,
        [Description("Limpeza - Dados Fiscais")] LimpezaDadosFiscais = 17,
        [Description("Limpeza - Dados Contábeis")] LimpezaDadosContabeis = 18,
        [Description("Encerramento de Período")] EncerramentoPeriodo = 19,
        [Description("Limpeza - Encerramento Período")] LimpezaEncerramentoPeriodo = 20,
        [Description("Report")] Report = 21,
        [Description("Limpeza - Bloco K")] LimpezaBlocoK = 22,
        [Description("Tax Intelligence")] TaxIntelligence = 23,
        [Description("REINF")] Reinf = 24,
        [Description("Consolidação SPT")] ConsolidacaoSPT = 25,
        [Description("Consolidação SIR")] ConsolidacaoSIR = 26,
        [Description("Importação Excel REINF")] ImportExcelReinf = 27,
        [Description("Participante CPRB Update")] ParticipanteCPRBUpdate = 29,
        [Description("Controle Imposto Retido")] ControleImpostoRetido = 30,
        [Description("Replicação de Dados Contábeis")] ReplicacaoDadosContabeis = 31,
        [Description("Limpeza - P3")] LimpezaP3 = 32,
        [Description("Limpeza - GPS")] LimpezaGPS = 33,
        [Description("Download XML")] DownloadXML = 34,
        [Description("Limpeza - F200")] LimpezaF200 = 35,
        [Description("Importação CSV")] ImportCSV = 36,
        [Description("JOB Generic")] JobGeneric = 37,
        [Description("Reinf Check Status")] ReinfCheckStatus = 40,
        [Description("Check Remessa Retorno Notas")] CheckRemessaRetornoNovasNotas = 41,
        [Description("Integração TaxDocs x TaxCompliance")] IntegracaoTaxDocsCompliance = 42,
        [Description("Calculo Crédito Estadual")] ProcessoCalculoCreditoEstadual = 43,
        [Description("Limpeza F600 - Contribuições Retidas na Fonte")] LimpezaF600ContribuicoesRetidasFonte = 44,
        [Description("Versionamento Arquivo Digital")] ArquivoDigitalVersionamento = 45,
        [Description("Verifica Atualização Versionamento Arquivo Digital")] VerificaAtualizacaoArquivoDigitalVersionamento = 46,
        [Description("Limpeza Em Massa")] LimpezaEmMassa = 47,
        [Description("Atualização da Taxa Selic")] AtualizaTaxaSelic = 48,
        [Description("Replicar Parametrização de Contabilização de Vencimento")] ReplicarParametrizacaoContabilizacaoVencimento = 49,
        [Description("Verifica Atualização da Taxa Selic")] VerificaAtualizacaoTaxaSelic = 50,
        [Description("Extração do indicadores")] ExtracaoIndicadores = 51,
        [Description("Eventos Portal")] EventosPortal = 52,
        [Description("Versionamento Tabela Externa")] TabelaExternalVersionamento = 53,
        [Description("Verifica Atualização Versionamento Tabela Externa")] VerificaAtualizacaoTabelaExternaVersionamento = 54,
        [Description("Extração do indicador de Tarefas por Contrato")] ExtracaoIndicadorTarefasPorContrato = 56,
        [Description("GNRE - Criação Automática")] GNRECriacaoAutomatica = 57,
        [Description("Exclusão de Apuração")] ExclusaoApuracao = 58,
        [Description("Exclusão do Processo de Apuração")] ExclusaoProcessoApuracao = 59,
        [Description("Exclusão da Consolidação da Apuração")] ExclusaoConsolidacaoApuracao = 60,
        [Description("Apuração Simples Nacional")] SimplesNacional = 62
    }

    public enum JobStatusEnum
    {
        [Description("Pendente")] Pendente = 1,
        [Description("Em Execução")] EmExecucao = 2,
        [Description("Concluído")] Concluido = 3,
        [Description("Concluído com erro")] ConcluidoComErro = 4,
        [Description("Agendado")] Agendado = 5,
        [Description("Excluindo")] Excluido = 6
    }

    public enum CodigoCPRBEnum
    {
        [EnumDbValue("0")]
        [Description("Não é contribuinte da Contribuição Previdenciária sobre a Receita Bruta (CPRB) - Retenção 11%")] CodigoNaoContribuinte = 0,
        [EnumDbValue("1")]
        [Description("Contribuinte da Contribuição Previdenciária sobre a Receita Bruta (CPRB) - Retenção 3,5%")] CodigoContribuinte = 1
    }

    public enum FormatoRelatorioEnum
    {
        Pdf = 1,
        Excel = 2
    }

    public enum TipoListaRelatorioEnum
    {
        [Description("Todos os documentos")] TodosDocumentos = 1,
        [Description("Documentos geradores de crédito")] GeradoresCredito = 2
    }

    public enum TipoTributacaoEnum
    {
        Tributado = 1,
        Completo = 2
    }
}