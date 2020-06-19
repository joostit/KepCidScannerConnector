using ScannerConnector.Http.Xml.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace ScannerConnector.Http.Xml
{
    class ScannerCommandParser
    {

        private XmlSerializer serializer;

        public ScannerCommandParser()
        {
            serializer = new XmlSerializer(typeof(OrderInterface));
        }

        public string GetOrderResult(OrderInterface commands)
        {
            string result = null;

            using (TextWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, commands);
                result = writer.ToString();
            }

            return result;
        }

    }
}
