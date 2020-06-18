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
    public partial class OrderInterfaceResultListResultCustomField : NameIDPair
    {

        private string typeField;

        private NameIDPair[] customFieldEntryListField;

        /// <remarks/>
        public string Type
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

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CustomFieldEntry", typeof(NameIDPair), IsNullable = false)]
        public NameIDPair[] CustomFieldEntryList
        {
            get
            {
                return this.customFieldEntryListField;
            }
            set
            {
                this.customFieldEntryListField = value;
            }
        }
    }


}
