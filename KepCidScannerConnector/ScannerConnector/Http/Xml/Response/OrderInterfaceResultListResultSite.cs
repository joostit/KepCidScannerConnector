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
    public partial class OrderInterfaceResultListResultSite
    {

        private string idField;

        private bool islocalField;

        public OrderInterfaceResultListResultSite()
        {
            this.islocalField = false;
        }

        /// <remarks/>
        public string ID
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool islocal
        {
            get
            {
                return this.islocalField;
            }
            set
            {
                this.islocalField = value;
            }
        }
    }


}
