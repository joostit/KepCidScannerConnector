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
    public partial class OrderFullDetails
    {

        private string orderIDField;

        private string masterOrderIDField;

        private string dispenserIDField;

        private string dispenserOrderNoField;

        private string contactPersonField;

        private System.DateTime createDateField;

        private System.DateTime orderDateField;

        private System.DateTime deliveryDateField;

        private string patientFirstNameField;

        private string patientLastNameField;

        private string patientReferenceField;

        private string address1Field;

        private string address2Field;

        private string zipField;

        private string cityField;

        private string countryField;

        private bool allowChangesField;

        private bool allowChangesFieldSpecified;

        private bool warrantyField;

        private bool warrantyFieldSpecified;

        private bool shellOnlyField;

        private bool shellOnlyFieldSpecified;

        private bool reUseField;

        private bool reUseFieldSpecified;

        private string commentsField;

        private string remakeCodeField;

        private string accountField;

        private OrderLine[] orderLineField;

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
        public string MasterOrderID
        {
            get
            {
                return this.masterOrderIDField;
            }
            set
            {
                this.masterOrderIDField = value;
            }
        }

        /// <remarks/>
        public string DispenserID
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
        public string DispenserOrderNo
        {
            get
            {
                return this.dispenserOrderNoField;
            }
            set
            {
                this.dispenserOrderNoField = value;
            }
        }

        /// <remarks/>
        public string ContactPerson
        {
            get
            {
                return this.contactPersonField;
            }
            set
            {
                this.contactPersonField = value;
            }
        }

        /// <remarks/>
        public System.DateTime CreateDate
        {
            get
            {
                return this.createDateField;
            }
            set
            {
                this.createDateField = value;
            }
        }

        /// <remarks/>
        public System.DateTime OrderDate
        {
            get
            {
                return this.orderDateField;
            }
            set
            {
                this.orderDateField = value;
            }
        }

        /// <remarks/>
        public System.DateTime DeliveryDate
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
        public string PatientFirstName
        {
            get
            {
                return this.patientFirstNameField;
            }
            set
            {
                this.patientFirstNameField = value;
            }
        }

        /// <remarks/>
        public string PatientLastName
        {
            get
            {
                return this.patientLastNameField;
            }
            set
            {
                this.patientLastNameField = value;
            }
        }

        /// <remarks/>
        public string PatientReference
        {
            get
            {
                return this.patientReferenceField;
            }
            set
            {
                this.patientReferenceField = value;
            }
        }

        /// <remarks/>
        public string Address1
        {
            get
            {
                return this.address1Field;
            }
            set
            {
                this.address1Field = value;
            }
        }

        /// <remarks/>
        public string Address2
        {
            get
            {
                return this.address2Field;
            }
            set
            {
                this.address2Field = value;
            }
        }

        /// <remarks/>
        public string Zip
        {
            get
            {
                return this.zipField;
            }
            set
            {
                this.zipField = value;
            }
        }

        /// <remarks/>
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        public bool AllowChanges
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AllowChangesSpecified
        {
            get
            {
                return this.allowChangesFieldSpecified;
            }
            set
            {
                this.allowChangesFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool Warranty
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool WarrantySpecified
        {
            get
            {
                return this.warrantyFieldSpecified;
            }
            set
            {
                this.warrantyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool ShellOnly
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShellOnlySpecified
        {
            get
            {
                return this.shellOnlyFieldSpecified;
            }
            set
            {
                this.shellOnlyFieldSpecified = value;
            }
        }

        /// <remarks/>
        public bool ReUse
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReUseSpecified
        {
            get
            {
                return this.reUseFieldSpecified;
            }
            set
            {
                this.reUseFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        public string RemakeCode
        {
            get
            {
                return this.remakeCodeField;
            }
            set
            {
                this.remakeCodeField = value;
            }
        }

        /// <remarks/>
        public string Account
        {
            get
            {
                return this.accountField;
            }
            set
            {
                this.accountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrderLine")]
        public OrderLine[] OrderLine
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
    }


}
