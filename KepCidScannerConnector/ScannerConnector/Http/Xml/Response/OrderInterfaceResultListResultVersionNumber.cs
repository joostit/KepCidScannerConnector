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
    public partial class OrderInterfaceResultListResultVersionNumber
    {

        private string orderInterfaceVersionNumberField;

        /// <remarks/>
        public string OrderInterfaceVersionNumber
        {
            get
            {
                return this.orderInterfaceVersionNumberField;
            }
            set
            {
                this.orderInterfaceVersionNumberField = value;
            }
        }
    }


}
