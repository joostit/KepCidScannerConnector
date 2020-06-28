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

        public string GetOrderInterfaceString(OrderInterface commands)
        {
            string result = null;

            using (TextWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, commands);
                result = writer.ToString();
            }

            return result;
        }

        public string GetShapeListCommand()
        {
            OrderInterface orderInterfaceObject = new OrderInterface();
            orderInterfaceObject.CommandList = new CommandList();
            orderInterfaceObject.CommandList.CommandGetShapeList = new CommandWithRestriction[1];

            CommandWithRestriction commandWithRestriction = new CommandWithRestriction();
            commandWithRestriction.id = "1";

            orderInterfaceObject.CommandList.CommandGetShapeList[0] = commandWithRestriction;

            string xmlString = GetOrderInterfaceString(orderInterfaceObject);
            return xmlString;
        }

    }
}
