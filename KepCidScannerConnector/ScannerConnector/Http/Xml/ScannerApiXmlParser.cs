using ScannerConnector.Http.Xml.Response;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace ScannerConnector.Http.Xml
{
    class ScannerApiXmlParser
    {

        public OrderInterface GetOrderResult(string httpBody)
        {
            OrderInterface result = null;
            MethodInfo method = typeof(XmlSerializer).GetMethod("set_Mode", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static);
            method.Invoke(null, new object[] { 1 });

            XmlSerializer serializer = new XmlSerializer(typeof(OrderInterface));

            using (TextReader reader = new StringReader(httpBody))
            {
                
                result = (OrderInterface)serializer.Deserialize(reader);
            }

            return result;
        }

    }
}
