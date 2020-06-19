using System;
using System.Collections.Generic;
using System.Text;

namespace ScannerConnector.Http.Xml.Commands
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://3shape.com/ThreeShape.HI.Manager.OrderInterface/Commands.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://3shape.com/ThreeShape.HI.Manager.OrderInterface/Commands.xsd", IsNullable = false)]
    public partial class OrderInterface
    {

        private CommandList commandListField;

        private double versionField;

        private CommandListType typeField;

        /// <remarks/>
        public CommandList CommandList
        {
            get
            {
                return this.commandListField;
            }
            set
            {
                this.commandListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public double version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CommandListType type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }

}
