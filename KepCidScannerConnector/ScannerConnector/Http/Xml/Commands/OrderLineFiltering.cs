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
    public partial class OrderLineFiltering
    {

        private OrderLineFilteringID[] idField;

        private OrderLineFilteringID1[] unqualifiedComponentsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ID")]
        public OrderLineFilteringID[] ID
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

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ID", IsNullable = false)]
        public OrderLineFilteringID1[] UnqualifiedComponents
        {
            get
            {
                return this.unqualifiedComponentsField;
            }
            set
            {
                this.unqualifiedComponentsField = value;
            }
        }
    }

}
