using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ScannerConnector.Http.Xml.Response
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://3shape.com/ThreeShape.HI.Manager.OrderInterface/Results.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://3shape.com/ThreeShape.HI.Manager.OrderInterface/Results.xsd", IsNullable = false)]
    public partial class OrderInterface
    {

        private OrderInterfaceResultList resultListField;

        private string messageField;

        private OrderInterfaceError errorField;

        private bool errorFieldSpecified;

        private double versionField;

        private OrderInterfaceType typeField;

        /// <remarks/>
        public OrderInterfaceResultList ResultList
        {
            get
            {
                return this.resultListField;
            }
            set
            {
                this.resultListField = value;
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
        public OrderInterfaceError Error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ErrorSpecified
        {
            get
            {
                return this.errorFieldSpecified;
            }
            set
            {
                this.errorFieldSpecified = value;
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
        public OrderInterfaceType type
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
