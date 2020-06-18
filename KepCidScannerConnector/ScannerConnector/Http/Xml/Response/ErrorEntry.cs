using System;
using System.Collections.Generic;
using System.Text;

namespace ScannerConnector.Http.Xml.Response
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://3shape.com/ThreeShape.HI.Manager.OrderInterface/Results.xsd")]
    public partial class ErrorEntry
    {

        private string codeField;

        private string messageField;

        private string earIDField;

        private bool handledField;

        private bool handledFieldSpecified;

        /// <remarks/>
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }

        /// <remarks/>
        public string EarID
        {
            get
            {
                return this.earIDField;
            }
            set
            {
                this.earIDField = value;
            }
        }

        /// <remarks/>
        public bool Handled
        {
            get
            {
                return this.handledField;
            }
            set
            {
                this.handledField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HandledSpecified
        {
            get
            {
                return this.handledFieldSpecified;
            }
            set
            {
                this.handledFieldSpecified = value;
            }
        }
    }


}
