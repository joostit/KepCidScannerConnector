using System;
using System.Collections.Generic;
using System.Text;

namespace ScannerConnector.Http.Xml.Commands
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://3shape.com/ThreeShape.HI.Manager.OrderInterface/Commands.xsd")]
    public partial class CommandListCommandSearch : Command
    {

        private string orderIDField;

        private Status minStatusField;

        private bool minStatusFieldSpecified;

        private Status maxStatusField;

        private bool maxStatusFieldSpecified;

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

        /// <remarks/>
        public Status MinStatus
        {
            get
            {
                return this.minStatusField;
            }
            set
            {
                this.minStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinStatusSpecified
        {
            get
            {
                return this.minStatusFieldSpecified;
            }
            set
            {
                this.minStatusFieldSpecified = value;
            }
        }

        /// <remarks/>
        public Status MaxStatus
        {
            get
            {
                return this.maxStatusField;
            }
            set
            {
                this.maxStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxStatusSpecified
        {
            get
            {
                return this.maxStatusFieldSpecified;
            }
            set
            {
                this.maxStatusFieldSpecified = value;
            }
        }
    }

}
