using System;
using System.Globalization;
using System.Xml.Serialization;
using TCO.WebApi.Abstractions.DTO;
using TCO.WebApi.Abstractions.DTO.DFe;
using TCOXMLJsonConverter.ModelXMLNFe;
using static TCOXMLJsonConverter.Integration.MapeamentoXMLTCO;

namespace TCOXMLJsonConverter.Integration
{
    public static class ConverterEnum
    {
        public static string GetDescription<T>(this T enumerationValue)
        {
            if (enumerationValue == null)
                return string.Empty;
            var type = enumerationValue.GetType();
            if (!type.IsEnum)
                throw new ArgumentException($"{nameof(enumerationValue)} must be of Enum type", nameof(enumerationValue));
            var memberInfo = type.GetMember(enumerationValue.ToString());
            if (memberInfo.Length > 0)
            {
                var attrs = memberInfo[0].GetCustomAttributes(typeof(XmlEnumAttribute), false);
                if (attrs.Length > 0)
                    return ((XmlEnumAttribute)attrs[0]).Name;
            }
            return enumerationValue.ToString();
        }
    }

    public class MapeamentoXMLTCO
    {
        public enum DocumentType
        {
            EmitenteEstabFiscal,
            EmitenteParceiro
        }

        public static string SetEmptyOrValue(object input)
        {
            return input == null ? string.Empty : input.ToString();
        }

        public static int? SetNullIntegerOrValue(object input)
        {
            try
            {
                return input == null ? 0 : int.Parse(input.ToString(), new CultureInfo("en-US"));
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static decimal SetZeroOrValue(object input)
        {
            try
            {
                return input == null ? 0 : decimal.Parse(input.ToString(), new CultureInfo("en-US"));
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }

    public class MapeamentoXMLTCOIntegration
    {
        private DocumentType identificadorEmitente;

        private DFeDTO CabecalhoNFeParser(TNFeInfNFe infNfe)
        {
            TNFeInfNFeIde nf = infNfe.ide;
            TNFeInfNFeDest destNF = infNfe.dest;

            DFeDTO documentoFiscal = new DFeDTO();

            ParceiroDTO parceiroDoumentocFiscal = new ParceiroDTO();

            string codigoEmpresa = SetEmptyOrValue(infNfe.emit.Item);
            string codigoContribuinte = SetEmptyOrValue(infNfe.emit.Item);

            if (identificadorEmitente == DocumentType.EmitenteEstabFiscal && infNfe.dest != null && infNfe.dest.enderDest != null)
            {
                codigoEmpresa = SetEmptyOrValue(infNfe.emit.Item);
                codigoContribuinte = SetEmptyOrValue(infNfe.emit.Item);

                parceiroDoumentocFiscal.Codigo = SetEmptyOrValue(infNfe.dest.Item);
                parceiroDoumentocFiscal.Nome = SetEmptyOrValue(infNfe.dest.xNome);

                if (ConverterEnum.GetDescription(infNfe.dest.ItemElementName) == "CNPJ")
                {
                    parceiroDoumentocFiscal.Cnpj = SetEmptyOrValue(infNfe.dest.Item);
                }
                else if (ConverterEnum.GetDescription(infNfe.dest.ItemElementName) == "CPF")
                {
                    parceiroDoumentocFiscal.Cpf = SetEmptyOrValue(infNfe.dest.Item);
                }

                parceiroDoumentocFiscal.Endereco = SetEmptyOrValue(infNfe.dest.enderDest.xLgr);
                parceiroDoumentocFiscal.Numero = SetEmptyOrValue(infNfe.dest.enderDest.nro);
                parceiroDoumentocFiscal.Complemento = SetEmptyOrValue(infNfe.dest.enderDest.xCpl);
                parceiroDoumentocFiscal.Bairro = SetEmptyOrValue(infNfe.dest.enderDest.xBairro);
                parceiroDoumentocFiscal.Cep = SetEmptyOrValue(infNfe.dest.enderDest.CEP);
                parceiroDoumentocFiscal.PaisCodigoIBGE = Convert.ToInt32(infNfe.dest.enderDest.cPais);
                parceiroDoumentocFiscal.MunicipioCodigoIBGE = Convert.ToInt32(infNfe.dest.enderDest.cMun);
                parceiroDoumentocFiscal.Ddd = "00";
                parceiroDoumentocFiscal.Telefone = SetEmptyOrValue(infNfe.dest.enderDest.fone);
                parceiroDoumentocFiscal.Email = SetEmptyOrValue(infNfe.dest.email);
            }
            else if (identificadorEmitente == DocumentType.EmitenteParceiro && infNfe.emit != null && infNfe.emit.enderEmit != null)
            {
                codigoEmpresa = SetEmptyOrValue(infNfe.dest.Item);
                codigoContribuinte = SetEmptyOrValue(infNfe.dest.Item);

                parceiroDoumentocFiscal.Codigo = SetEmptyOrValue(infNfe.emit.Item);
                parceiroDoumentocFiscal.Nome = SetEmptyOrValue(infNfe.emit.xNome);

                if (ConverterEnum.GetDescription(infNfe.emit.ItemElementName) == "CNPJ")
                {
                    parceiroDoumentocFiscal.Cnpj = SetEmptyOrValue(infNfe.emit.Item);
                }
                else if (ConverterEnum.GetDescription(infNfe.emit.ItemElementName) == "CPF")
                {
                    parceiroDoumentocFiscal.Cpf = SetEmptyOrValue(infNfe.emit.Item);
                }

                parceiroDoumentocFiscal.Endereco = SetEmptyOrValue(infNfe.emit.enderEmit.xLgr);
                parceiroDoumentocFiscal.Numero = SetEmptyOrValue(infNfe.emit.enderEmit.nro);
                parceiroDoumentocFiscal.Complemento = SetEmptyOrValue(infNfe.emit.enderEmit.xCpl);
                parceiroDoumentocFiscal.Bairro = SetEmptyOrValue(infNfe.emit.enderEmit.xBairro);
                parceiroDoumentocFiscal.Cep = SetEmptyOrValue(infNfe.emit.enderEmit.CEP);
                parceiroDoumentocFiscal.PaisCodigoIBGE = Convert.ToInt32(ConverterEnum.GetDescription(infNfe.emit.enderEmit.cPais));
                parceiroDoumentocFiscal.MunicipioCodigoIBGE = Convert.ToInt32(infNfe.emit.enderEmit.cMun);
                parceiroDoumentocFiscal.Ddd = "00";
                parceiroDoumentocFiscal.Telefone = SetEmptyOrValue(infNfe.emit.enderEmit.fone);
                parceiroDoumentocFiscal.Email = "";
            }

            documentoFiscal.codigoEmpresa = codigoEmpresa;
            documentoFiscal.codigoContribuinte = codigoContribuinte;
            documentoFiscal.parceiro = parceiroDoumentocFiscal.Codigo == string.Empty || parceiroDoumentocFiscal.Endereco == string.Empty ? null : parceiroDoumentocFiscal;
            documentoFiscal.inscricaoMunicipal = null;
            documentoFiscal.inscricaoEstadualSubstituto = null;
            documentoFiscal.operacao = identificadorEmitente == DocumentType.EmitenteEstabFiscal ? Convert.ToInt32(ConverterEnum.GetDescription(nf.tpNF)) : 0;
            documentoFiscal.emitidaContribuinte = identificadorEmitente == DocumentType.EmitenteEstabFiscal ? 1 : 0;
            documentoFiscal.finalidadeNotaFiscal = Convert.ToInt32(ConverterEnum.GetDescription(nf.finNFe));
            documentoFiscal.serie = SetEmptyOrValue(nf.serie);
            documentoFiscal.subserie = null;
            documentoFiscal.modelo = Convert.ToInt32(ConverterEnum.GetDescription(nf.mod));
            documentoFiscal.modeloServico = null;
            documentoFiscal.numeroDocumento = Convert.ToInt32(nf.nNF);
            documentoFiscal.chaveNFe = GetChaveNFe(infNfe.Id);
            documentoFiscal.dataEmissao = Convert.ToDateTime(nf.dhEmi);
            documentoFiscal.dataEntradaSaida = Convert.ToDateTime(infNfe.ide.dhSaiEnt ?? infNfe.ide.dhEmi);
            documentoFiscal.dataExecucaoServico = null;
            documentoFiscal.localExecucaoServico = null;
            documentoFiscal.periodoEscrituracao = identificadorEmitente == DocumentType.EmitenteEstabFiscal ? Convert.ToDateTime(nf.dhEmi) : Convert.ToDateTime(infNfe.ide.dhSaiEnt ?? infNfe.ide.dhEmi);
            documentoFiscal.situacao = 0;
            documentoFiscal.dataCancelamento = null;
            documentoFiscal.motivoCancelamento = null;
            documentoFiscal.tipoPagamento = null;
            documentoFiscal.tipoConsumo = null;
            documentoFiscal.codigoClasseConsumo = null;
            documentoFiscal.tipoLigacao = null;
            documentoFiscal.grupoTensao = null;
            documentoFiscal.codigoObra = null;
            documentoFiscal.codigoObraFilial = null;
            documentoFiscal.codigoCNO = null;
            documentoFiscal.municipioRecolhimentoISSCodigoIBGE = null;
            documentoFiscal.municipioExecucaoServicoCodigoIBGE = null;
            documentoFiscal.operacaoConsumidorFinal = Convert.ToInt32(ConverterEnum.GetDescription(nf.indFinal));
            documentoFiscal.presencaComprador = Convert.ToInt32(ConverterEnum.GetDescription(nf.indPres));
            documentoFiscal.inscricaoEstadualDestinatario = Convert.ToInt32(ConverterEnum.GetDescription(nf.idDest));
            documentoFiscal.notaFiscalAtivo = null;
            documentoFiscal.codigoReferenciaIntegracao = null;
            documentoFiscal.numeroLancamentoContabil = null;

            return documentoFiscal;
        }

        private DFeImpostoDTO ImpostoItensNFeParser(DFeItemDTO notaFiscalItem, TNFeInfNFeDet nfDet)
        {
            try
            {
                DFeImpostoDTO notaFiscalItemImposto = new DFeImpostoDTO();

                //Nota Fiscal Itens Impostos
                TNFeInfNFeDetImposto itemImposto = nfDet.imposto;

                foreach (object item in itemImposto.Items)
                {
                    switch (item.GetType().Name)
                    {
                        case "TNFeInfNFeDetImpostoICMS":

                        //Imposto ICMS
                        TNFeInfNFeDetImpostoICMS itemImpostoICMSNF = (TNFeInfNFeDetImpostoICMS)item;

                        //Sit. Tributaria 00
                        if (itemImpostoICMSNF.Item.GetType().Name == "TNFeInfNFeDetImpostoICMSICMS00")
                        {
                            TNFeInfNFeDetImpostoICMSICMS00 itemImpostoICMS00NF = (TNFeInfNFeDetImpostoICMSICMS00)itemImpostoICMSNF.Item;

                            notaFiscalItemImposto.icms = new DFeImpostoICMSDTO
                            {
                                situacaoTributariaICMSTabA = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoICMS00NF.orig)),
                                situacaoTributariaICMSTabB = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoICMS00NF.CST)),
                                baseCalculoICMS = SetZeroOrValue(itemImpostoICMS00NF.vBC),
                                aliquotaICMS = SetZeroOrValue(itemImpostoICMS00NF.pICMS),
                                valorICMS = SetZeroOrValue(itemImpostoICMS00NF.vICMS),
                                difal = new DFeImpostoICMSDIFALDTO
                                {
                                    percentualFCP = SetZeroOrValue(itemImpostoICMS00NF.pFCP),
                                    valorICMSFCP = SetZeroOrValue(itemImpostoICMS00NF.vFCP)
                                }
                            };
                        }
                        else if (itemImpostoICMSNF.Item.GetType().Name == "TNFeInfNFeDetImpostoICMSICMS10") //Sit. Tributaria 10
                        {
                            TNFeInfNFeDetImpostoICMSICMS10 itemImpostoICMS10NF = (TNFeInfNFeDetImpostoICMSICMS10)itemImpostoICMSNF.Item;

                            notaFiscalItemImposto.icms = new DFeImpostoICMSDTO
                            {
                                situacaoTributariaICMSTabA = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoICMS10NF.orig)),
                                situacaoTributariaICMSTabB = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoICMS10NF.CST)),

                                baseCalculoICMS = SetZeroOrValue(itemImpostoICMS10NF.vBC),
                                aliquotaICMS = SetZeroOrValue(itemImpostoICMS10NF.pICMS),
                                valorICMS = SetZeroOrValue(itemImpostoICMS10NF.vICMS),
                                valorReduzidoICMS = SetZeroOrValue(itemImpostoICMS10NF.pRedBCST),
                                difal = new DFeImpostoICMSDIFALDTO
                                {
                                    percentualFCP = SetZeroOrValue(itemImpostoICMS10NF.pFCP),
                                    valorICMSFCP = SetZeroOrValue(itemImpostoICMS10NF.vFCP)
                                }
                            };

                            notaFiscalItemImposto.icmsst = new DFeImpostoICMSSTDTO
                            {
                                aliquotaMarkup = SetZeroOrValue(itemImpostoICMS10NF.pMVAST),
                                baseCalculoICMSST = SetZeroOrValue(itemImpostoICMS10NF.vBCST),
                                aliquotaICMSST = SetZeroOrValue(itemImpostoICMS10NF.pICMSST),
                                valorICMSST = SetZeroOrValue(itemImpostoICMS10NF.vICMSST),
                                baseCalculoFCPST = SetZeroOrValue(itemImpostoICMS10NF.vBCFCPST),
                                percentualFCPST = SetZeroOrValue(itemImpostoICMS10NF.pFCPST),
                                valorFCPST = SetZeroOrValue(itemImpostoICMS10NF.vFCPST)
                            };
                        }
                        else if (itemImpostoICMSNF.Item.GetType().Name == "TNFeInfNFeDetImpostoICMSICMS20") /* Sit. Tributaria 20*/
                        {
                            TNFeInfNFeDetImpostoICMSICMS20 itemImpostoICMS20NF = (TNFeInfNFeDetImpostoICMSICMS20)itemImpostoICMSNF.Item;

                            notaFiscalItemImposto.icms = new DFeImpostoICMSDTO
                            {
                                situacaoTributariaICMSTabA = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoICMS20NF.orig)),
                                situacaoTributariaICMSTabB = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoICMS20NF.CST)),

                                baseCalculoICMS = SetZeroOrValue(itemImpostoICMS20NF.vBC),
                                aliquotaICMS = SetZeroOrValue(itemImpostoICMS20NF.pICMS),
                                valorICMS = SetZeroOrValue(itemImpostoICMS20NF.vICMS),
                                aliquotaReducaoICMS = SetZeroOrValue(itemImpostoICMS20NF.pRedBC),
                                difal = new DFeImpostoICMSDIFALDTO
                                {
                                    percentualFCP = SetZeroOrValue(itemImpostoICMS20NF.pFCP),
                                    valorICMSFCP = SetZeroOrValue(itemImpostoICMS20NF.vFCP)
                                },
                                desonerado = new DFeImpostoICMSDesoneradoDTO
                                {
                                    valorDesoneradoICMS = SetZeroOrValue(itemImpostoICMS20NF.vICMSDeson),
                                    motivoDesoneradoICMS = itemImpostoICMS20NF.motDesICMS.ToString()
                                }
                            };
                        }
                        else if (itemImpostoICMSNF.Item.GetType().Name == "TNFeInfNFeDetImpostoICMSICMS30") /* Sit. Tributaria 30 */
                        {
                            TNFeInfNFeDetImpostoICMSICMS30 itemImpostoICMS30NF = (TNFeInfNFeDetImpostoICMSICMS30)itemImpostoICMSNF.Item;

                            notaFiscalItemImposto.icms = new DFeImpostoICMSDTO
                            {
                                situacaoTributariaICMSTabA = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoICMS30NF.orig)),
                                situacaoTributariaICMSTabB = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoICMS30NF.CST)),
                                valorReduzidoICMS = SetZeroOrValue(itemImpostoICMS30NF.pRedBCST),
                                desonerado = new DFeImpostoICMSDesoneradoDTO
                                {
                                    valorDesoneradoICMS = SetZeroOrValue(itemImpostoICMS30NF.vICMSDeson),
                                    motivoDesoneradoICMS = itemImpostoICMS30NF.motDesICMS.ToString()
                                }
                            };

                            notaFiscalItemImposto.icmsst = new DFeImpostoICMSSTDTO
                            {
                                aliquotaMarkup = SetZeroOrValue(itemImpostoICMS30NF.pMVAST),
                                baseCalculoICMSST = SetZeroOrValue(itemImpostoICMS30NF.vBCST),
                                aliquotaICMSST = SetZeroOrValue(itemImpostoICMS30NF.pICMSST),
                                valorICMSST = SetZeroOrValue(itemImpostoICMS30NF.vICMSST),
                                baseCalculoFCPST = SetZeroOrValue(itemImpostoICMS30NF.vBCFCPST),
                                percentualFCPST = SetZeroOrValue(itemImpostoICMS30NF.pFCPST),
                                valorFCPST = SetZeroOrValue(itemImpostoICMS30NF.vFCPST)
                            };
                        }
                        else if (itemImpostoICMSNF.Item.GetType().Name == "TNFeInfNFeDetImpostoICMSICMS40") //Sit. Tributaria 40
                        {
                            TNFeInfNFeDetImpostoICMSICMS40 itemImpostoICMS40NF = (TNFeInfNFeDetImpostoICMSICMS40)itemImpostoICMSNF.Item;

                            notaFiscalItemImposto.icms = new DFeImpostoICMSDTO
                            {
                                situacaoTributariaICMSTabA = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoICMS40NF.orig)),
                                situacaoTributariaICMSTabB = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoICMS40NF.CST)),
                                desonerado = new DFeImpostoICMSDesoneradoDTO
                                {
                                    valorDesoneradoICMS = SetZeroOrValue(itemImpostoICMS40NF.vICMSDeson),
                                    motivoDesoneradoICMS = itemImpostoICMS40NF.motDesICMS.ToString()
                                }
                            };
                        }
                        else if (itemImpostoICMSNF.Item.GetType().Name == "TNFeInfNFeDetImpostoICMSICMS51") //Sit. Tributaria 51
                        {
                            TNFeInfNFeDetImpostoICMSICMS51 itemImpostoICMS51NF = (TNFeInfNFeDetImpostoICMSICMS51)itemImpostoICMSNF.Item;

                            notaFiscalItemImposto.icms = new DFeImpostoICMSDTO
                            {
                                situacaoTributariaICMSTabA = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoICMS51NF.orig)),
                                situacaoTributariaICMSTabB = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoICMS51NF.CST)),

                                baseCalculoICMS = SetZeroOrValue(itemImpostoICMS51NF.vBC),
                                aliquotaICMS = SetZeroOrValue(itemImpostoICMS51NF.pICMS),
                                valorICMS = SetZeroOrValue(itemImpostoICMS51NF.vICMS),
                                aliquotaReducaoICMS = SetZeroOrValue(itemImpostoICMS51NF.pRedBC),
                                difal = new DFeImpostoICMSDIFALDTO
                                {
                                    percentualFCP = SetZeroOrValue(itemImpostoICMS51NF.pFCP),
                                    valorICMSFCP = SetZeroOrValue(itemImpostoICMS51NF.vFCP)
                                },
                                diferido = new DFeImpostoICMSDiferidoDTO
                                {
                                    aliquotaDiferidoICMS = SetZeroOrValue(itemImpostoICMS51NF.pDif),
                                    valorDiferidoICMS = SetZeroOrValue(itemImpostoICMS51NF.vICMSDif)
                                }
                            };
                        }
                        else if (itemImpostoICMSNF.Item.GetType().Name == "TNFeInfNFeDetImpostoICMSICMS60") //Sit. Tributaria 60
                        {
                            var itemImpostoICMS60NF = (TNFeInfNFeDetImpostoICMSICMS60)itemImpostoICMSNF.Item;

                            notaFiscalItemImposto.icms = new DFeImpostoICMSDTO
                            {
                                situacaoTributariaICMSTabA = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoICMS60NF.orig)),
                                situacaoTributariaICMSTabB = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoICMS60NF.CST)),
                                baseCalculoICMS = SetZeroOrValue(itemImpostoICMS60NF.vBCEfet),
                                aliquotaICMS = SetZeroOrValue(itemImpostoICMS60NF.pICMSEfet),
                                valorICMS = SetZeroOrValue(itemImpostoICMS60NF.vICMSEfet),
                                aliquotaReducaoICMS = SetZeroOrValue(itemImpostoICMS60NF.pRedBCEfet)
                            };

                            notaFiscalItemImposto.icmsst = new DFeImpostoICMSSTDTO
                            {
                                baseCalculoICMSST = SetZeroOrValue(itemImpostoICMS60NF.vBCSTRet),
                                aliquotaICMSST = SetZeroOrValue(itemImpostoICMS60NF.pST),
                                valorICMSST = SetZeroOrValue(itemImpostoICMS60NF.vICMSSubstituto),
                                baseCalculoRetidoFCPST = SetZeroOrValue(itemImpostoICMS60NF.vBCFCPSTRet),
                                percentualRetidoFCPST = SetZeroOrValue(itemImpostoICMS60NF.pFCPSTRet),
                                valorRetidoFCPST = SetZeroOrValue(itemImpostoICMS60NF.vFCPSTRet)
                            };
                        }
                        else if (itemImpostoICMSNF.Item.GetType().Name == nameof(TNFeInfNFeDetImpostoICMSICMS70)) /* Sit. Tributaria 70*/
                        {
                            var itemImpostoICMS70NF = (TNFeInfNFeDetImpostoICMSICMS70)itemImpostoICMSNF.Item;

                            notaFiscalItemImposto.icms = new DFeImpostoICMSDTO
                            {
                                situacaoTributariaICMSTabA = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoICMS70NF.orig)),
                                situacaoTributariaICMSTabB = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoICMS70NF.CST)),

                                baseCalculoICMS = SetZeroOrValue(itemImpostoICMS70NF.vBC),
                                aliquotaICMS = SetZeroOrValue(itemImpostoICMS70NF.pICMS),
                                valorICMS = SetZeroOrValue(itemImpostoICMS70NF.vICMS),
                                aliquotaReducaoICMS = SetZeroOrValue(itemImpostoICMS70NF.pRedBC),
                                difal = new DFeImpostoICMSDIFALDTO
                                {
                                    percentualFCP = SetZeroOrValue(itemImpostoICMS70NF.pFCP),
                                    valorICMSFCP = SetZeroOrValue(itemImpostoICMS70NF.vFCP)
                                },
                                desonerado = new DFeImpostoICMSDesoneradoDTO
                                {
                                    valorDesoneradoICMS = SetZeroOrValue(itemImpostoICMS70NF.vICMSDeson),
                                    motivoDesoneradoICMS = itemImpostoICMS70NF.motDesICMS.ToString()
                                }
                            };

                            notaFiscalItemImposto.icmsst = new DFeImpostoICMSSTDTO
                            {
                                aliquotaMarkup = SetZeroOrValue(itemImpostoICMS70NF.pMVAST),
                                baseCalculoICMSST = SetZeroOrValue(itemImpostoICMS70NF.vBCST),
                                aliquotaICMSST = SetZeroOrValue(itemImpostoICMS70NF.pICMSST),
                                valorICMSST = SetZeroOrValue(itemImpostoICMS70NF.vICMSST),
                                baseCalculoFCPST = SetZeroOrValue(itemImpostoICMS70NF.vBCFCPST),
                                percentualFCPST = SetZeroOrValue(itemImpostoICMS70NF.pFCPST),
                                valorFCPST = SetZeroOrValue(itemImpostoICMS70NF.vFCPST)
                            };
                        }
                        else if (itemImpostoICMSNF.Item.GetType().Name == nameof(TNFeInfNFeDetImpostoICMSICMS90)) //Sit. Tributaria 90
                        {
                            var itemImpostoICMS90NF = (TNFeInfNFeDetImpostoICMSICMS90)itemImpostoICMSNF.Item;

                            notaFiscalItemImposto.icms = new DFeImpostoICMSDTO
                            {
                                situacaoTributariaICMSTabA = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoICMS90NF.orig)),
                                situacaoTributariaICMSTabB = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoICMS90NF.CST)),

                                baseCalculoICMS = SetZeroOrValue(itemImpostoICMS90NF.vBC),
                                aliquotaICMS = SetZeroOrValue(itemImpostoICMS90NF.pICMS),
                                valorICMS = SetZeroOrValue(itemImpostoICMS90NF.vICMS),
                                aliquotaReducaoICMS = SetZeroOrValue(itemImpostoICMS90NF.pRedBC),
                                difal = new DFeImpostoICMSDIFALDTO
                                {
                                    percentualFCP = SetZeroOrValue(itemImpostoICMS90NF.pFCP),
                                    valorICMSFCP = SetZeroOrValue(itemImpostoICMS90NF.vFCP)
                                },
                                desonerado = new DFeImpostoICMSDesoneradoDTO
                                {
                                    valorDesoneradoICMS = SetZeroOrValue(itemImpostoICMS90NF.vICMSDeson),
                                    motivoDesoneradoICMS = itemImpostoICMS90NF.motDesICMS.ToString()
                                }
                            };

                            notaFiscalItemImposto.icmsst = new DFeImpostoICMSSTDTO
                            {
                                aliquotaMarkup = SetZeroOrValue(itemImpostoICMS90NF.pMVAST),
                                baseCalculoICMSST = SetZeroOrValue(itemImpostoICMS90NF.vBCST),
                                aliquotaICMSST = SetZeroOrValue(itemImpostoICMS90NF.pICMSST),
                                valorICMSST = SetZeroOrValue(itemImpostoICMS90NF.vICMSST),
                                baseCalculoFCPST = SetZeroOrValue(itemImpostoICMS90NF.vBCFCPST),
                                percentualFCPST = SetZeroOrValue(itemImpostoICMS90NF.pFCPST),
                                valorFCPST = SetZeroOrValue(itemImpostoICMS90NF.vFCPST)
                            };
                        }
                        else if (itemImpostoICMSNF.Item.GetType().Name == nameof(TNFeInfNFeDetImpostoICMSICMSSN101)) //Sit. Tributaria SN101
                        {
                            var itemImpostoICMSSNNF = (TNFeInfNFeDetImpostoICMSICMSSN101)itemImpostoICMSNF.Item;

                            notaFiscalItemImposto.icms = new DFeImpostoICMSDTO
                            {
                                situacaoTributariaICMSTabA = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoICMSSNNF.orig)),
                                creditoSimplesNacional = new DFeImpostoICMSCreditoSimplesNacionalDTO
                                {
                                    aliquotaICMS = SetZeroOrValue(itemImpostoICMSSNNF.pCredSN),
                                    valorICMS = SetZeroOrValue(itemImpostoICMSSNNF.vCredICMSSN)
                                }
                            };
                        }
                        else if (itemImpostoICMSNF.Item.GetType().Name == nameof(TNFeInfNFeDetImpostoICMSICMSSN102)) //Sit. Tributaria SN102
                        {
                            TNFeInfNFeDetImpostoICMSICMSSN102 itemImpostoICMSSNNF = (TNFeInfNFeDetImpostoICMSICMSSN102)itemImpostoICMSNF.Item;

                            notaFiscalItemImposto.icms = new DFeImpostoICMSDTO
                            {
                                situacaoTributariaICMSTabA = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoICMSSNNF.orig))
                            };
                        }
                        else if (itemImpostoICMSNF.Item.GetType().Name == nameof(TNFeInfNFeDetImpostoICMSICMSSN201)) //Sit. Tributaria SN201
                        {
                            TNFeInfNFeDetImpostoICMSICMSSN201 itemImpostoICMSSNNF = (TNFeInfNFeDetImpostoICMSICMSSN201)itemImpostoICMSNF.Item;

                            notaFiscalItemImposto.icms = new DFeImpostoICMSDTO
                            {
                                situacaoTributariaICMSTabA = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoICMSSNNF.orig)),
                                creditoSimplesNacional = new DFeImpostoICMSCreditoSimplesNacionalDTO
                                {
                                    aliquotaICMS = SetZeroOrValue(itemImpostoICMSSNNF.pCredSN),
                                    valorICMS = SetZeroOrValue(itemImpostoICMSSNNF.vCredICMSSN)
                                }
                            };

                            notaFiscalItemImposto.icmsst = new DFeImpostoICMSSTDTO
                            {
                                aliquotaMarkup = SetZeroOrValue(itemImpostoICMSSNNF.pMVAST),
                                baseCalculoICMSST = SetZeroOrValue(itemImpostoICMSSNNF.vBCST),
                                aliquotaICMSST = SetZeroOrValue(itemImpostoICMSSNNF.pICMSST),
                                valorICMSST = SetZeroOrValue(itemImpostoICMSSNNF.vICMSST),
                                baseCalculoFCPST = SetZeroOrValue(itemImpostoICMSSNNF.vBCFCPST),
                                percentualFCPST = SetZeroOrValue(itemImpostoICMSSNNF.pFCPST),
                                valorFCPST = SetZeroOrValue(itemImpostoICMSSNNF.vFCPST)
                            };
                        }
                        else if (itemImpostoICMSNF.Item.GetType().Name == nameof(TNFeInfNFeDetImpostoICMSICMSSN500)) //Sit. Tributaria SN500
                        {
                            var itemImpostoICMSSNNF = (TNFeInfNFeDetImpostoICMSICMSSN500)itemImpostoICMSNF.Item;

                            notaFiscalItemImposto.icms = new DFeImpostoICMSDTO
                            {
                                situacaoTributariaICMSTabA = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoICMSSNNF.orig))
                            };

                            notaFiscalItemImposto.icmsst = new DFeImpostoICMSSTDTO
                            {
                                baseCalculoICMSST = SetZeroOrValue(itemImpostoICMSSNNF.vBCSTRet),
                                aliquotaICMSST = SetZeroOrValue(itemImpostoICMSSNNF.pST),
                                valorICMSST = SetZeroOrValue(itemImpostoICMSSNNF.vICMSSubstituto),
                                baseCalculoRetidoFCPST = SetZeroOrValue(itemImpostoICMSSNNF.vBCFCPSTRet),
                                percentualRetidoFCPST = SetZeroOrValue(itemImpostoICMSSNNF.pFCPSTRet),
                                valorRetidoFCPST = SetZeroOrValue(itemImpostoICMSSNNF.vFCPSTRet)
                            };
                        }
                        else if (itemImpostoICMSNF.Item.GetType().Name == nameof(TNFeInfNFeDetImpostoICMSICMSSN900)) //Sit. Tributaria SN900
                        {
                            var itemImpostoICMSSNNF = (TNFeInfNFeDetImpostoICMSICMSSN900)itemImpostoICMSNF.Item;

                            notaFiscalItemImposto.icms = new DFeImpostoICMSDTO
                            {
                                situacaoTributariaICMSTabA = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoICMSSNNF.orig)),
                                baseCalculoICMS = SetZeroOrValue(itemImpostoICMSSNNF.vBC),
                                aliquotaICMS = SetZeroOrValue(itemImpostoICMSSNNF.pICMS),
                                valorICMS = SetZeroOrValue(itemImpostoICMSSNNF.vICMS),
                                aliquotaReducaoICMS = SetZeroOrValue(itemImpostoICMSSNNF.pRedBC),

                                creditoSimplesNacional = new DFeImpostoICMSCreditoSimplesNacionalDTO
                                {
                                    aliquotaICMS = SetZeroOrValue(itemImpostoICMSSNNF.pCredSN),
                                    valorICMS = SetZeroOrValue(itemImpostoICMSSNNF.vCredICMSSN)
                                }
                            };

                            notaFiscalItemImposto.icmsst = new DFeImpostoICMSSTDTO
                            {
                                aliquotaMarkup = SetZeroOrValue(itemImpostoICMSSNNF.pMVAST),
                                baseCalculoICMSST = SetZeroOrValue(itemImpostoICMSSNNF.vBCST),
                                aliquotaICMSST = SetZeroOrValue(itemImpostoICMSSNNF.pICMSST),
                                valorICMSST = SetZeroOrValue(itemImpostoICMSSNNF.vICMSST),
                                baseCalculoFCPST = SetZeroOrValue(itemImpostoICMSSNNF.vBCFCPST),
                                percentualFCPST = SetZeroOrValue(itemImpostoICMSSNNF.pFCPST),
                                valorFCPST = SetZeroOrValue(itemImpostoICMSSNNF.vFCPST)
                            };
                        }

                        break;

                        case "TNFeInfNFeDetImpostoIPI":

                        //Imposto IPI
                        TNFeInfNFeDetImpostoIPI itemImpostoIPINF = (TNFeInfNFeDetImpostoIPI)item;

                        DFeImpostoIPIDTO ipi = new DFeImpostoIPIDTO();

                        ipi.seloControleIPI = SetEmptyOrValue(itemImpostoIPINF.cSelo);
                        ipi.quantidadeSeloIPI = SetNullIntegerOrValue(itemImpostoIPINF.qSelo);
                        ipi.enquandramentoLegalIPI = SetEmptyOrValue(itemImpostoIPINF.cEnq);

                        //Sit. Tributaria NT
                        if (itemImpostoIPINF.Item.GetType().Name == "TNFeInfNFeDetImpostoIPINT")
                        {
                            TNFeInfNFeDetImpostoIPINT itemImpostoIPINTNF = (TNFeInfNFeDetImpostoIPINT)itemImpostoIPINF.Item;

                            ipi.situacaoTributariaIPI = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoIPINTNF.CST));
                        }
                        else if (itemImpostoIPINF.Item.GetType().Name == "TNFeInfNFeDetImpostoIPITrib") //Sit. Tributaria Trib
                        {
                            TNFeInfNFeDetImpostoIPITrib itemImpostoIPITribNF = (TNFeInfNFeDetImpostoIPITrib)itemImpostoIPINF.Item;

                            ipi.situacaoTributariaIPI = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoIPITribNF.CST));

                            ipi.valorIPI = SetZeroOrValue(itemImpostoIPITribNF.vIPI);

                            foreach (var itemIPI in itemImpostoIPITribNF.ItemsElementName)
                            {
                                int posicao = 0;

                                switch (ConverterEnum.GetDescription(itemIPI))
                                {
                                    case "vBC":
                                    ipi.baseCalculoIPI = SetZeroOrValue(Convert.ToDecimal(itemImpostoIPITribNF.Items[posicao].ToString()));
                                    posicao += 1;
                                    break;

                                    case "pIPI":
                                    ipi.aliquotaIPI = SetZeroOrValue(Convert.ToDecimal(itemImpostoIPITribNF.Items[posicao].ToString()));
                                    posicao += 1;
                                    break;

                                    case "qUnid":
                                    ipi.quantidadePautadaIPI = SetZeroOrValue(Convert.ToDecimal(itemImpostoIPITribNF.Items[posicao].ToString()));
                                    posicao += 1;
                                    break;

                                    case "vUnid":
                                    ipi.valorPautadoIPI = SetZeroOrValue(Convert.ToDecimal(itemImpostoIPITribNF.Items[posicao].ToString()));
                                    posicao += 1;
                                    break;
                                };
                            }
                        }
                        notaFiscalItemImposto.ipi = ipi;

                        break;

                        case "TNFeInfNFeDetImpostoII":
                        break;

                        case "TNFeInfNFeDetImpostoISSQN":

                        //Imposto ISSQN
                        TNFeInfNFeDetImpostoISSQN itemImpostoISSQNNF = (TNFeInfNFeDetImpostoISSQN)item;

                        notaFiscalItemImposto.issqn = new DFeImpostoISSQNDTO
                        {
                            baseCalculoISSQN = SetZeroOrValue(itemImpostoISSQNNF.vBC),
                            aliquotaISSQN = SetZeroOrValue(itemImpostoISSQNNF.vAliq),
                            valorISSQN = SetZeroOrValue(itemImpostoISSQNNF.vISSQN)
                        };

                        //ValorDesconto = SetZeroOrValue(itemImpostoISSQNNF.vDescIncond),
                        //ValorDescontoZonaFranca = SetZeroOrValue(itemImpostoISSQNNF.vDescCond),
                        //ValorISSRetido = SetZeroOrValue(itemImpostoISSQNNF.vISSRet),
                        //CodServicoMunic = SetEmptyOrValue(itemImpostoISSQNNF.cServico)
                        //if (!string.IsNullOrEmpty(itemImpostoISSQNNF.cMunFG) && int.TryParse(itemImpostoISSQNNF.cMunFG, out int cMunFG))
                        //{
                        //    documentoFiscal.MunicipioExecucaoServico = cMunFG,
                        //}

                        break;
                    }
                }

                //Imposto ICMSUFDest
                if (itemImposto.ICMSUFDest != null)
                {
                    TNFeInfNFeDetImpostoICMSUFDest iCMSUFDest = itemImposto.ICMSUFDest;

                    if (notaFiscalItemImposto.icms == null)
                    {
                        notaFiscalItemImposto.icms = new DFeImpostoICMSDTO
                        {
                            difal = new DFeImpostoICMSDIFALDTO
                            {
                                percentualFCP = SetZeroOrValue(iCMSUFDest.pFCPUFDest),
                                percentualPartilha = (Int32)SetZeroOrValue(iCMSUFDest.pICMSInterPart),
                                valorDestinoICMS = SetZeroOrValue(iCMSUFDest.vICMSUFDest),
                                valorOrigemICMS = SetZeroOrValue(iCMSUFDest.vICMSUFRemet),
                                aliquotaDestinoICMS = SetZeroOrValue(iCMSUFDest.pICMSUFDest)
                            }
                        };
                    }
                    else
                    {
                        notaFiscalItemImposto.icms.difal = new DFeImpostoICMSDIFALDTO
                        {
                            percentualFCP = SetZeroOrValue(iCMSUFDest.pFCPUFDest),
                            percentualPartilha = (Int32)SetZeroOrValue(iCMSUFDest.pICMSInterPart),
                            valorDestinoICMS = SetZeroOrValue(iCMSUFDest.vICMSUFDest),
                            valorOrigemICMS = SetZeroOrValue(iCMSUFDest.vICMSUFRemet),
                            aliquotaDestinoICMS = SetZeroOrValue(iCMSUFDest.pICMSUFDest)
                        };
                    }
                }

                //Imposto PIS
                if (itemImposto.PIS != null)
                {
                    TNFeInfNFeDetImpostoPIS itemImpostoPISNF = itemImposto.PIS;

                    //Sit. Tributaria Aliq
                    if (itemImpostoPISNF.Item.GetType().Name == "TNFeInfNFeDetImpostoPISPISAliq")
                    {
                        TNFeInfNFeDetImpostoPISPISAliq itemImpostoPISAliqNF = (TNFeInfNFeDetImpostoPISPISAliq)itemImpostoPISNF.Item;

                        notaFiscalItemImposto.pis = new DFeImpostoPISDTO
                        {
                            situacaoTributariaPIS = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoPISAliqNF.CST)),
                            baseCalculoPIS = SetZeroOrValue(itemImpostoPISAliqNF.vBC),
                            aliquotaPIS = SetZeroOrValue(itemImpostoPISAliqNF.pPIS),
                            valorPIS = SetZeroOrValue(itemImpostoPISAliqNF.vPIS)
                        };
                    }
                    else if (itemImpostoPISNF.Item.GetType().Name == "TNFeInfNFeDetImpostoPISPISNT") //Sit. Tributaria NT
                    {
                        TNFeInfNFeDetImpostoPISPISNT itemImpostoPISNTNF = (TNFeInfNFeDetImpostoPISPISNT)itemImpostoPISNF.Item;

                        notaFiscalItemImposto.pis = new DFeImpostoPISDTO
                        {
                            situacaoTributariaPIS = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoPISNTNF.CST))
                        };
                    }
                    else if (itemImpostoPISNF.Item.GetType().Name == "TNFeInfNFeDetImpostoPISPISOutr") //Sit. Tributaria Outros
                    {
                        TNFeInfNFeDetImpostoPISPISOutr itemImpostoPISOutrosNF = (TNFeInfNFeDetImpostoPISPISOutr)itemImpostoPISNF.Item;

                        notaFiscalItemImposto.pis = new DFeImpostoPISDTO
                        {
                            situacaoTributariaPIS = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoPISOutrosNF.CST)),
                            //baseCalculoPIS = SetZeroOrValue(itemImpostoPISOutrosNF.vBC),
                            //aliquotaPIS = SetZeroOrValue(itemImpostoPISOutrosNF.pPIS),
                            valorPIS = SetZeroOrValue(itemImpostoPISOutrosNF.vPIS)
                        };
                    }
                    else if (itemImpostoPISNF.Item.GetType().Name == "TNFeInfNFeDetImpostoPISPISQtde") //Sit. Tributaria Qtde
                    {
                        TNFeInfNFeDetImpostoPISPISQtde itemImpostoPISQtde = (TNFeInfNFeDetImpostoPISPISQtde)itemImpostoPISNF.Item;

                        notaFiscalItemImposto.pis = new DFeImpostoPISDTO
                        {
                            situacaoTributariaPIS = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoPISQtde.CST)),
                            quantidadeBaseCalculoPIS = SetZeroOrValue(itemImpostoPISQtde.qBCProd),
                            valorPautadoPIS = SetZeroOrValue(itemImpostoPISQtde.vAliqProd),
                            valorPIS = SetZeroOrValue(itemImpostoPISQtde.vPIS)
                        };
                    }
                }

                ////Imposto COFINS
                if (itemImposto.COFINS != null)
                {
                    TNFeInfNFeDetImpostoCOFINS itemImpostoCOFINSNF = itemImposto.COFINS;

                    //Sit. Tributaria Aliq
                    if (itemImpostoCOFINSNF.Item.GetType().Name == "TNFeInfNFeDetImpostoCOFINSCOFINSAliq")
                    {
                        TNFeInfNFeDetImpostoCOFINSCOFINSAliq itemImpostoCOFINSAliqNF = (TNFeInfNFeDetImpostoCOFINSCOFINSAliq)itemImpostoCOFINSNF.Item;

                        notaFiscalItemImposto.cofins = new DFeImpostoCOFINSDTO
                        {
                            situacaoTributariaCOFINS = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoCOFINSAliqNF.CST)),
                            baseCalculoCOFINS = SetZeroOrValue(itemImpostoCOFINSAliqNF.vBC),
                            aliquotaCOFINS = SetZeroOrValue(itemImpostoCOFINSAliqNF.pCOFINS),
                            valorCOFINS = SetZeroOrValue(itemImpostoCOFINSAliqNF.vCOFINS)
                        };
                    }
                    else if (itemImpostoCOFINSNF.Item.GetType().Name == "TNFeInfNFeDetImpostoCOFINSCOFINSNT") //Sit. Tributaria NT
                    {
                        TNFeInfNFeDetImpostoCOFINSCOFINSNT itemImpostoCOFINSNTNF = (TNFeInfNFeDetImpostoCOFINSCOFINSNT)itemImpostoCOFINSNF.Item;

                        notaFiscalItemImposto.cofins = new DFeImpostoCOFINSDTO
                        {
                            situacaoTributariaCOFINS = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoCOFINSNTNF.CST))
                        };
                    }
                    else if (itemImpostoCOFINSNF.Item.GetType().Name == "TNFeInfNFeDetImpostoCOFINSCOFINSOutr") //Sit. Tributaria Outros
                    {
                        TNFeInfNFeDetImpostoCOFINSCOFINSOutr itemImpostoCOFINSOutrosNF = (TNFeInfNFeDetImpostoCOFINSCOFINSOutr)itemImpostoCOFINSNF.Item;

                        notaFiscalItemImposto.cofins = new DFeImpostoCOFINSDTO
                        {
                            situacaoTributariaCOFINS = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoCOFINSOutrosNF.CST)),
                            //baseCalculoCOFINS = SetZeroOrValue(itemImpostoCOFINSOutrosNF.vBC),
                            //aliquotaCOFINS = SetZeroOrValue(itemImpostoCOFINSOutrosNF.pCOFINS),
                            valorCOFINS = SetZeroOrValue(itemImpostoCOFINSOutrosNF.vCOFINS)
                        };
                    }
                    else if (itemImpostoCOFINSNF.Item.GetType().Name == "TNFeInfNFeDetImpostoCOFINSCOFINSQtde") //Sit. Tributaria Qtde
                    {
                        TNFeInfNFeDetImpostoCOFINSCOFINSQtde itemImpostoCOFINSQtde = (TNFeInfNFeDetImpostoCOFINSCOFINSQtde)itemImpostoCOFINSNF.Item;

                        notaFiscalItemImposto.cofins = new DFeImpostoCOFINSDTO
                        {
                            situacaoTributariaCOFINS = Convert.ToInt32(ConverterEnum.GetDescription(itemImpostoCOFINSQtde.CST)),
                            quantidadeBaseCalculoCOFINS = SetZeroOrValue(itemImpostoCOFINSQtde.qBCProd),
                            valorPautadoCOFINS = SetZeroOrValue(itemImpostoCOFINSQtde.vAliqProd),
                            valorCOFINS = SetZeroOrValue(itemImpostoCOFINSQtde.vCOFINS)
                        };
                    }
                }

                //Imposto PISST
                if (itemImposto.PISST != null)
                {
                    TNFeInfNFeDetImpostoPISST itemImpostoPISSTNF = itemImposto.PISST;

                    DFeImpostoPISDTO pis = new DFeImpostoPISDTO();

                    foreach (var itemPIS in itemImpostoPISSTNF.ItemsElementName)
                    {
                        int posicao = 0;

                        switch (ConverterEnum.GetDescription(itemPIS))
                        {
                            case "pPIS":
                            pis.aliquotaPIS = SetZeroOrValue(Convert.ToDecimal(itemImpostoPISSTNF.Items[posicao].ToString()));
                            posicao += 1;
                            break;

                            case "qBCProd":
                            pis.quantidadeBaseCalculoPIS = SetZeroOrValue(Convert.ToDecimal(itemImpostoPISSTNF.Items[posicao].ToString()));
                            posicao += 1;
                            break;

                            case "vAliqProd":
                            pis.valorPautadoPIS = SetZeroOrValue(Convert.ToDecimal(itemImpostoPISSTNF.Items[posicao].ToString()));
                            posicao += 1;
                            break;

                            case "vBC":
                            pis.baseCalculoPIS = SetZeroOrValue(Convert.ToDecimal(itemImpostoPISSTNF.Items[posicao].ToString()));
                            posicao += 1;
                            break;
                        };
                    };

                    pis.valorPIS = SetZeroOrValue(itemImpostoPISSTNF.vPIS);

                    notaFiscalItemImposto.pis = pis;
                }

                //Imposto COFINS ST
                if (itemImposto.COFINSST != null)
                {
                    TNFeInfNFeDetImpostoCOFINSST itemImpostoCOFINSSTNF = itemImposto.COFINSST;

                    DFeImpostoCOFINSDTO cofins = new DFeImpostoCOFINSDTO();

                    foreach (var itemCOFINS in itemImpostoCOFINSSTNF.ItemsElementName)
                    {
                        int posicao = 0;

                        switch (ConverterEnum.GetDescription(itemCOFINS))
                        {
                            case "pCOFINS":
                            cofins.aliquotaCOFINS = SetZeroOrValue(Convert.ToDecimal(itemImpostoCOFINSSTNF.Items[posicao].ToString()));
                            posicao += 1;
                            break;

                            case "qBCProd":
                            cofins.quantidadeBaseCalculoCOFINS = SetZeroOrValue(Convert.ToDecimal(itemImpostoCOFINSSTNF.Items[posicao].ToString()));
                            posicao += 1;
                            break;

                            case "vAliqProd":
                            cofins.valorPautadoCOFINS = SetZeroOrValue(Convert.ToDecimal(itemImpostoCOFINSSTNF.Items[posicao].ToString()));
                            posicao += 1;
                            break;

                            case "vBC":
                            cofins.baseCalculoCOFINS = SetZeroOrValue(Convert.ToDecimal(itemImpostoCOFINSSTNF.Items[posicao].ToString()));
                            posicao += 1;
                            break;
                        };
                    };

                    cofins.valorCOFINS = SetZeroOrValue(itemImpostoCOFINSSTNF.vCOFINS);

                    notaFiscalItemImposto.cofins = cofins;
                }

                TNFeInfNFeDetImpostoDevol impostoDevolvido = nfDet.impostoDevol;

                //Imposto Devolvido
                if (impostoDevolvido != null)
                {
                    //IPI
                    if (impostoDevolvido.IPI != null)
                    {
                        notaFiscalItemImposto.ipi.valorDevolvidoIPI = SetZeroOrValue(impostoDevolvido.IPI.vIPIDevol);
                    }
                }

                return notaFiscalItemImposto;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return null;
            }
        }

        private DFeItemDTO ItensNFeParser(DFeDTO documentoFiscal, TNFeInfNFeDet nfDet)
        {
            DFeItemDTO notaFiscalItem = new DFeItemDTO();

            ItemDto item = new ItemDto();
            UnidadeMedidaDTO unidadeMedida = new UnidadeMedidaDTO();
            ClassificacaoFiscalDTO classificacaoFiscal = new ClassificacaoFiscalDTO();

            TNFeInfNFeDetProd itemNF = nfDet.prod;

            unidadeMedida.codigo = itemNF.uCom;
            unidadeMedida.descricao = null;

            classificacaoFiscal.codigo = itemNF.NCM;
            classificacaoFiscal.codigoExcecaoTabelaIPI = itemNF.EXTIPI;

            item.Codigo = itemNF.cProd;
            item.Descricao = itemNF.xProd;
            item.UnidadeMedida = unidadeMedida;
            item.TipoItem = 0;
            item.CodigoBarra = itemNF.cEAN;
            item.ClassificacaoFiscal = classificacaoFiscal;
            item.CodigoListaServico = null;

            notaFiscalItem.numeroSequencia = int.Parse(nfDet.nItem);
            notaFiscalItem.item = item;
            notaFiscalItem.descricaoComplementar = itemNF.xProd;
            notaFiscalItem.codigoFCI = "";
            notaFiscalItem.codigoServicoMunicipal = "";
            notaFiscalItem.descricaoServicoMunicipal = "";
            notaFiscalItem.cfop = Convert.ToInt32(itemNF.CFOP);
            notaFiscalItem.cfopEmitente = Convert.ToInt32(itemNF.CFOP);
            //notaFiscalItem.cnaeEmitente = 0;
            notaFiscalItem.cfopComplemento = "";
            notaFiscalItem.naturezaOperacao = null;
            notaFiscalItem.codigoInformacaoAdicional = "";
            notaFiscalItem.unidadeMedida = unidadeMedida;
            notaFiscalItem.quantidade = SetZeroOrValue(itemNF.qCom);
            notaFiscalItem.valorUnidade = SetZeroOrValue(itemNF.vUnCom);
            notaFiscalItem.valorTotal = SetZeroOrValue(itemNF.vProd);
            notaFiscalItem.valorDescontoComercial = SetZeroOrValue(itemNF.vDesc);
            notaFiscalItem.valorDescontoZonaFranca = 0;
            notaFiscalItem.valorDespesaAduaneira = 0;
            notaFiscalItem.valorFrete = SetZeroOrValue(itemNF.vFrete);
            notaFiscalItem.valorSeguro = SetZeroOrValue(itemNF.vSeg);
            notaFiscalItem.valorOutrasDespesas = SetZeroOrValue(itemNF.vOutro);
            notaFiscalItem.movimentacaoFisica = 0;
            notaFiscalItem.controleMovimentacaoFiscal = 0;
            notaFiscalItem.codigoEspecificoBeneficioFiscal = "";
            notaFiscalItem.tipoDocumentoImportacao = 0;
            notaFiscalItem.atoConcessionarioDrawback = "";
            notaFiscalItem.numeroDocumentoImportacao = "";
            notaFiscalItem.registroExportacao = "";
            notaFiscalItem.origemCredito = 0;
            notaFiscalItem.codigoNaturezaBaseCalculoCreditos = "";
            notaFiscalItem.rateioProporcionalCredito = 0;
            notaFiscalItem.naturezaReceita = "";
            notaFiscalItem.naturezaFrete = 0;
            notaFiscalItem.tipoFrete = 0;
            notaFiscalItem.codigoContaContabilAnalitica = "";
            notaFiscalItem.centroCusto = null;
            notaFiscalItem.categoriaDocumentoFiscal = "";
            notaFiscalItem.numeroPedidoCliente = nfDet.prod.xPed;
            notaFiscalItem.linhaPedidoCliente = SetNullIntegerOrValue(nfDet.prod.nItemPed);
            notaFiscalItem.codigoReferenciaIntegracao = "";

            notaFiscalItem.imposto = ImpostoItensNFeParser(notaFiscalItem, nfDet);
            notaFiscalItem.operacao = null;
            notaFiscalItem.ressarcimentosComplementosICMSST = null;
            notaFiscalItem.importacoes = null;
            notaFiscalItem.informacoesAdicionais = null;

            notaFiscalItem.valorContabil = SetZeroOrValue(itemNF.vProd) - SetZeroOrValue(itemNF.vDesc) + SetZeroOrValue(itemNF.vFrete) + SetZeroOrValue(itemNF.vSeg) + SetZeroOrValue(itemNF.vOutro);

            if (notaFiscalItem.imposto.icmsst != null)
            {
                notaFiscalItem.valorContabil += notaFiscalItem.imposto.icmsst.valorICMSST + notaFiscalItem.imposto.icmsst.valorFCPST;
            }

            if (notaFiscalItem.imposto.ipi != null)
            {
                notaFiscalItem.valorContabil += notaFiscalItem.imposto.ipi.valorIPI;
            }

            return notaFiscalItem;
        }

        private DFeDTO ValoresNFeParser(DFeDTO documentoFiscal, TNFeInfNFeTotal nfTotal)
        {
            TNFeInfNFeTotalICMSTot nfTotalICMS = nfTotal.ICMSTot;
            if (nfTotalICMS != null)
            {
                DFeTotalDTO totais = new DFeTotalDTO
                {
                    icms = new DFeTotalICMSDTO
                    {
                        valorBaseICMS = SetZeroOrValue(nfTotalICMS.vBC),
                        valorICMS = SetZeroOrValue(nfTotalICMS.vICMS),
                        valorICMSUFDestino = SetZeroOrValue(nfTotalICMS.vICMSUFDest),
                        valorICMSUFRemetente = SetZeroOrValue(nfTotalICMS.vICMSUFRemet),
                        valorFCPUFDestino = SetZeroOrValue(nfTotalICMS.vFCP)
                    },
                    icmsst = new DFeTotalICMSSTDTO
                    {
                        valorBaseICMSST = SetZeroOrValue(nfTotalICMS.vBCST),
                        valorICMSST = SetZeroOrValue(nfTotalICMS.vST),
                        valorFCPST = SetZeroOrValue(nfTotalICMS.vFCPST),
                        valorFCPSTRetido = SetZeroOrValue(nfTotalICMS.vFCPSTRet)
                    },
                    ipi = new DFeTotalIPIDTO
                    {
                        valorIPI = SetZeroOrValue(nfTotalICMS.vIPI),
                        valorIPIDevolvido = SetZeroOrValue(nfTotalICMS.vIPIDevol)
                    },
                    pis = new DFeTotalPISDTO
                    {
                        valorPIS = SetZeroOrValue(nfTotalICMS.vPIS)
                    },
                    cofins = new DFeTotalCOFINSDTO
                    {
                        valorCOFINS = SetZeroOrValue(nfTotalICMS.vCOFINS)
                    },
                    descontoDespesaOutros = new DFeTotalDescontoDespesaOutroDTO
                    {
                        valorTotalDesconto = SetZeroOrValue(nfTotalICMS.vDesc),
                        valorFrete = SetZeroOrValue(nfTotalICMS.vFrete),
                        valorSeguro = SetZeroOrValue(nfTotalICMS.vSeg),
                        valorOutrasDespesas = SetZeroOrValue(nfTotalICMS.vOutro)
                    },

                    valorMercadorias = SetZeroOrValue(nfTotalICMS.vProd),
                    valorDocumento = SetZeroOrValue(nfTotalICMS.vNF)
                };

                documentoFiscal.totais = totais;
            }

            TNFeInfNFeTotalISSQNtot nfTotalISSQN = nfTotal.ISSQNtot;
            if (nfTotalISSQN != null)
            {
                documentoFiscal.totais.issqn.valorISSQN = SetZeroOrValue(nfTotalISSQN.vISS);
                documentoFiscal.totais.cofins.valorCOFINS = SetZeroOrValue(nfTotalISSQN.vCOFINS);
                documentoFiscal.totais.pis.valorPIS = SetZeroOrValue(nfTotalISSQN.vPIS);
                documentoFiscal.totais.valorDocumento = SetZeroOrValue(nfTotalISSQN.vServ);
            }

            return documentoFiscal;
        }

        public DFeDTO GenerateJSONTCO(TNFeInfNFe document, string cnpjContribuinte)
        {
            identificadorEmitente = GetTipoEmitente(SetEmptyOrValue(document.emit.Item), cnpjContribuinte);

            string chaveDocumento = GetChaveNFe(document.Id);

            DFeDTO documentoFiscal = ParserCabecalhoNFe(document);
            documentoFiscal = ParserValoresNFe(document, documentoFiscal);
            documentoFiscal = ParserItensNFe(document, documentoFiscal);

            return documentoFiscal;
        }

        public string GetChaveNFe(string infNFeId)
        {
            if (!string.IsNullOrEmpty(infNFeId))
            {
                return infNFeId.Replace("NFe", string.Empty);
            }

            return string.Empty;
        }

        public DocumentType GetTipoEmitente(string CNPJ, string cnpjContribuinte)
        {
            if (CNPJ == cnpjContribuinte)
            {
                return DocumentType.EmitenteEstabFiscal;
            }

            return DocumentType.EmitenteParceiro;
        }

        public DFeDTO ParserCabecalhoNFe(TNFeInfNFe document)
        {
            DFeDTO documentoFiscal = CabecalhoNFeParser(document);

            return documentoFiscal;
        }

        public DFeDTO ParserItensNFe(TNFeInfNFe document, DFeDTO documentoFiscal)
        {
            foreach (TNFeInfNFeDet nfDet in document.det)
            {
                DFeItemDTO notaFiscalItem = new DFeItemDTO();
                notaFiscalItem = ItensNFeParser(documentoFiscal, nfDet);
                documentoFiscal.itens.Add(notaFiscalItem);
            }

            return documentoFiscal;
        }

        public DFeDTO ParserValoresNFe(TNFeInfNFe document, DFeDTO documentoFiscal)
        {
            TNFeInfNFeTotal nfTotal = document.total;
            return ValoresNFeParser(documentoFiscal, nfTotal);
        }
    }
}