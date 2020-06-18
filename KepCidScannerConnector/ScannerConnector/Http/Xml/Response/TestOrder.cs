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
    public partial class TestOrder
    {

        private TestResult orderIDField;

        private TestResult dispenserIDField;

        private TestResult deliveryDateField;

        private TestResult allowChangesField;

        private TestResult warrantyField;

        private TestResult shellOnlyField;

        private TestResult reUseField;

        private TestResult orderLineElementField;

        private TestOrderLine orderLineField;

        private bool orderOverAllResultField;

        private bool orderOverAllResultFieldSpecified;

        /// <remarks/>
        public TestResult OrderID
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
        public TestResult DispenserID
        {
            get
            {
                return this.dispenserIDField;
            }
            set
            {
                this.dispenserIDField = value;
            }
        }

        /// <remarks/>
        public TestResult DeliveryDate
        {
            get
            {
                return this.deliveryDateField;
            }
            set
            {
                this.deliveryDateField = value;
            }
        }

        /// <remarks/>
        public TestResult AllowChanges
        {
            get
            {
                return this.allowChangesField;
            }
            set
            {
                this.allowChangesField = value;
            }
        }

        /// <remarks/>
        public TestResult Warranty
        {
            get
            {
                return this.warrantyField;
            }
            set
            {
                this.warrantyField = value;
            }
        }

        /// <remarks/>
        public TestResult ShellOnly
        {
            get
            {
                return this.shellOnlyField;
            }
            set
            {
                this.shellOnlyField = value;
            }
        }

        /// <remarks/>
        public TestResult ReUse
        {
            get
            {
                return this.reUseField;
            }
            set
            {
                this.reUseField = value;
            }
        }

        /// <remarks/>
        public TestResult OrderLineElement
        {
            get
            {
                return this.orderLineElementField;
            }
            set
            {
                this.orderLineElementField = value;
            }
        }

        /// <remarks/>
        public TestOrderLine OrderLine
        {
            get
            {
                return this.orderLineField;
            }
            set
            {
                this.orderLineField = value;
            }
        }

        /// <remarks/>
        public bool OrderOverAllResult
        {
            get
            {
                return this.orderOverAllResultField;
            }
            set
            {
                this.orderOverAllResultField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrderOverAllResultSpecified
        {
            get
            {
                return this.orderOverAllResultFieldSpecified;
            }
            set
            {
                this.orderOverAllResultFieldSpecified = value;
            }
        }
    }


}
