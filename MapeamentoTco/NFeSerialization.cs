using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace TCOXMLJsonConverter.Serializable
{
    public class NFeSerialization
    {
        public T GetObjectFromFile<T>(XmlDocument myXMLFile) where T : class
        {
            var serialize = new XmlSerializer(typeof(T));

            try
            {
                TextReader sr = null;

                const string quote = "\"";

                string elementoXMLEndereco = string.Concat("xmlns = ", quote, "http://www.portalfiscal.inf.br/nfe", quote);

                if (myXMLFile.FirstChild.Name == "NFe")
                {
                    sr = new StringReader(string.Concat("<nfeProc ", elementoXMLEndereco, ">", myXMLFile.InnerXml, "</nfeProc>"));
                }
                else
                {
                    sr = new StringReader(myXMLFile.InnerXml);
                }

                var nfeCarregada = serialize.Deserialize(sr);

                return (T)nfeCarregada;
            }
            catch (Exception ex)
            {
                ex.Message.ToString();
                return null;
            }
        }
    }
}