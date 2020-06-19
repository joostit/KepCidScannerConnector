using System;
using System.Collections.Generic;
using System.Text;

namespace ScannerConnector.Http.Xml.Commands
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommandModelGetList))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommandDispenserCreate))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommandGroupGetList))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommandGroup))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommandGroupCreate))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommandOrderGetCreatedList))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommandWithRestriction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommandOrder))]
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
    public partial class Command
    {

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

}
