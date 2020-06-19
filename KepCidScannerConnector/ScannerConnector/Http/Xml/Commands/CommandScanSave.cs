using System;
using System.Collections.Generic;
using System.Text;

namespace ScannerConnector.Http.Xml.Commands
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://3shape.com/ThreeShape.HI.Manager.OrderInterface/Commands.xsd")]
    public partial class CommandScanSave : CommandOrder
    {

        private CommandScanSaveScan[] scanField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Scan")]
        public CommandScanSaveScan[] Scan
        {
            get
            {
                return this.scanField;
            }
            set
            {
                this.scanField = value;
            }
        }
    }

}
