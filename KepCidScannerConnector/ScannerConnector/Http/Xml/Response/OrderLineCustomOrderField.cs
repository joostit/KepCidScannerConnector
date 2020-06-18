using System;
using System.Collections.Generic;
using System.Text;

namespace ScannerConnector.Http.Xml.Response
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://3shape.com/ThreeShape.HI.Manager.OrderInterface/Results.xsd")]
    public partial class OrderLineCustomOrderField
    {

        private string fieldIDField;

        private string entryIDField;

        private string textValueField;

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
    }


}
