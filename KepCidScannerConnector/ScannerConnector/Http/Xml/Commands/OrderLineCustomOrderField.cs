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
    public partial class OrderLineCustomOrderField
    {

        private string fieldIDField;

        private string entryIDField;

        private string textValueField;

        private ListItemUpdateMethod methodField;

        private bool methodFieldSpecified;

        /// <remarks/>
        public string FieldID
        {
            get
            {
                return this.fieldIDField;
            }
            set
            {
                this.fieldIDField = value;
            }
        }

        /// <remarks/>
        public string EntryID
        {
            get
            {
                return this.entryIDField;
            }
            set
            {
                this.entryIDField = value;
            }
        }

        /// <remarks/>
        public string TextValue
        {
            get
            {
                return this.textValueField;
            }
            set
            {
                this.textValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ListItemUpdateMethod method
        {
            get
            {
                return this.methodField;
            }
            set
            {
                this.methodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool methodSpecified
        {
            get
            {
                return this.methodFieldSpecified;
            }
            set
            {
                this.methodFieldSpecified = value;
            }
        }
    }

}
