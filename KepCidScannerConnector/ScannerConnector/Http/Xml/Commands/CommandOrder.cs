using System;
using System.Collections.Generic;
using System.Text;

namespace ScannerConnector.Http.Xml.Commands
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommandOrderAttachmentGetAll))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommandOrderAttachmentDeleteAll))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommandOrderAttachmentDelete))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommandOrderAttachmentAdd))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommandScanSave))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommandOrderUpdate))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommandOrderRemake))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommandOrderCreateOrUpdate))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommandOrderCreate))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://3shape.com/ThreeShape.HI.Manager.OrderInterface/Commands.xsd")]
    public partial class CommandOrder : Command
    {

        private string groupIDField;

        private string orderIDField;

        /// <remarks/>
        public string GroupID
        {
            get
            {
                return this.groupIDField;
            }
            set
            {
                this.groupIDField = value;
            }
        }

        /// <remarks/>
        public string OrderID
        {
            get
            {
                return this.orderIDField;
            }
            set
            {
                this.orderIDField = value;
            }
        }
    }

}
