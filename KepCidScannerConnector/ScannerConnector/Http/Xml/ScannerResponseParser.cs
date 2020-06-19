using ScannerConnector.Http.Xml.Response;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace ScannerConnector.Http.Xml
{
    class ScannerResponseParser
    {

        XmlSerializer deserializer;

        public ScannerResponseParser()
        {
            deserializer = new XmlSerializer(typeof(OrderInterface));
        }

        public OrderInterface GetOrderResult(string httpBody)
        {
            OrderInterface result = null;

            using (TextReader reader = new StringReader(httpBody))
            {
                result = (OrderInterface)deserializer.Deserialize(reader);
            }

            return result;
        }

    }
}
