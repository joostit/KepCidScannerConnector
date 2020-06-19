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
    public partial class CommandListCommandErrorMark : Command
    {

        private string groupIDField;

        private string orderIDField;

        private string earIDField;

        private CommandListCommandErrorMarkOperation operationField;

        private string[] errorCodesField;

        private string errorDescriptionField;

        private bool resetStatusField;

        private bool resetStatusFieldSpecified;

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
        public CommandListCommandErrorMarkOperation Operation
        {
            get
            {
                return this.operationField;
            }
            set
            {
                this.operationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ID", IsNullable = false)]
        public string[] ErrorCodes
        {
            get
            {
                return this.errorCodesField;
            }
            set
            {
                this.errorCodesField = value;
            }
        }

        /// <remarks/>
        public string ErrorDescription
        {
            get
            {
                return this.errorDescriptionField;
            }
            set
            {
                this.errorDescriptionField = value;
            }
        }

        /// <remarks/>
        public bool ResetStatus
        {
            get
            {
                return this.resetStatusField;
            }
            set
            {
                this.resetStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResetStatusSpecified
        {
            get
            {
                return this.resetStatusFieldSpecified;
            }
            set
            {
                this.resetStatusFieldSpecified = value;
            }
        }
    }

}
