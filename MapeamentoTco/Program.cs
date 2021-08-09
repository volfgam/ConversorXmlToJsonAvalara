using Newtonsoft.Json;
using System;
using System.Xml;
using TCO.WebApi.Abstractions.DTO.DFe;
using TCOXMLJsonConverter.Integration;
using TCOXMLJsonConverter.ModelXMLNFe;
using TCOXMLJsonConverter.Serializable;

namespace MapeamentoTco
{
    internal class Program
    {
        private static DFeDTO LerXMLNFe(XmlDocument xmlDoc)
        {
            try
            {
                if (xmlDoc is not null)
                {
                    var serializable = new NFeSerialization();

                    var nfe = serializable.GetObjectFromFile<TNfeProc>(xmlDoc);

                    if (nfe is not null)
                    {
                        var documentNFe = nfe.NFe.infNFe;

                        var tcoNFEIntegration = new MapeamentoXMLTCOIntegration();
                        var cnpj = nfe.NFe.infNFe.emit.Item;
                        return tcoNFEIntegration.GenerateJSONTCO(documentNFe, cnpj);
                    }
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

            return null;
        }

        private static void Main(string[] args)
        {
            var docXML = new XmlDocument();

            //Caminho do XML
            docXML.Load(@"c:\\xml\31210671433528000100550010000009541679792387.xml");

            var nfeCru = XmlParaClasseEspelho(docXML);
            var nfePadraoAvalara = XmlParaClasseAvalara(docXML);

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("XML CRÚ CONVERTIDO PARA JSON");
            Console.WriteLine("------------------------------------------------------------");
            MostrarConsoleComoJson(nfeCru);

            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("XML CONVERTIDO PARA ENVIO PARA AVALARA");
            Console.WriteLine("------------------------------------------------------------");
            MostrarConsoleComoJson(nfePadraoAvalara);
        }

        private static void MostrarConsoleComoJson(object objetoAPrintar)
        {
            Console.WriteLine(JsonConvert.SerializeObject(objetoAPrintar, Newtonsoft.Json.Formatting.Indented));
        }

        private static DFeDTO XmlParaClasseAvalara(XmlDocument xmlDocument)
        {
            return LerXMLNFe(xmlDocument);
        }

        private static TNfeProc XmlParaClasseEspelho(XmlDocument xmlDocument)
        {
            var serialization = new NFeSerialization();

            return serialization.GetObjectFromFile<TNfeProc>(xmlDocument);
        }
    }
}