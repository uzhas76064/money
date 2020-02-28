using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ValuteParser
{
    public class UsdParser
    {
        XmlTextReader reader = new XmlTextReader("http://www.cbr.ru/scripts/XML_daily.asp");
        private string USDXml = "";
        private decimal usdVal;

        private string GetUsdXml()
        {
            while(reader.Read())
            {
                switch(reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if(reader.Name == "Valute")
                        {
                            if(reader.HasAttributes)
                            {
                                while(reader.MoveToNextAttribute())
                                {
                                    if(reader.Name == "ID")
                                    {
                                        if(reader.Value == "R01235")
                                        {
                                            reader.MoveToElement();
                                            USDXml = reader.ReadOuterXml();
                                        }
                                    }
                                }
                            }
                        }
                        break;
                }
            }

            return USDXml;
        }

        public decimal UsdXmlToDecimal()
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(GetUsdXml());
            XmlNode xmlNode = xmlDocument.SelectSingleNode("Valute/Value");

            usdVal = Convert.ToDecimal(xmlNode.InnerText);
            return usdVal;
        }
    }
}
