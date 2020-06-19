using System;
using System.Collections.Generic;
using System.Text;

namespace ScannerConnector.Http.Xml.Commands
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://3shape.com/ThreeShape.HI.Manager.OrderInterface/Commands.xsd")]
    public partial class CommandOrderCreateOrUpdate : CommandOrder
    {

        private string dispenserIDField;

        private string dispenserOrderNoField;

        private System.DateTime deliveryDateField;

        private bool deliveryDateFieldSpecified;

        private string patientFirstNameField;

        private string patientLastNameField;

        private string patientReferenceField;

        private bool patientShippingAddressField;

        private string patientAddress1Field;

        private string patientAddress2Field;

        private string patientZipField;

        private string patientCityField;

        private bool allowChangesField;

        private bool warrantyField;

        private bool shellOnlyField;

        private bool shellOnlyFieldSpecified;

        private bool reUseField;

        private bool reUseFieldSpecified;

        private string commentsField;

        private OrderLine[] orderLineField;

        private Status statusCodeField;

        private bool statusCodeFieldSpecified;

        public CommandOrderCreateOrUpdate()
        {
            this.patientShippingAddressField = false;
            this.allowChangesField = false;
            this.warrantyField = false;
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
        [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DeliveryDateSpecified
        {
            get
            {
                return this.deliveryDateFieldSpecified;
            }
            set
            {
                this.deliveryDateFieldSpecified = value;
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
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool PatientShippingAddress
        {
            get
            {
                return this.patientShippingAddressField;
            }
            set
            {
                this.patientShippingAddressField = value;
            }
        }

        /// <remarks/>
        public string PatientAddress1
        {
            get
            {
                return this.patientAddress1Field;
            }
            set
            {
                this.patientAddress1Field = value;
            }
        }

        /// <remarks/>
        public string PatientAddress2
        {
            get
            {
                return this.patientAddress2Field;
            }
            set
            {
                this.patientAddress2Field = value;
            }
        }

        /// <remarks/>
        public string PatientZip
        {
            get
            {
                return this.patientZipField;
            }
            set
            {
                this.patientZipField = value;
            }
        }

        /// <remarks/>
        public string PatientCity
        {
            get
            {
                return this.patientCityField;
            }
            set
            {
                this.patientCityField = value;
            }
        }

        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(false)]
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
        [System.ComponentModel.DefaultValueAttribute(false)]
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

        /// <remarks/>
        public Status StatusCode
        {
            get
            {
                return this.statusCodeField;
            }
            set
            {
                this.statusCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusCodeSpecified
        {
            get
            {
                return this.statusCodeFieldSpecified;
            }
            set
            {
                this.statusCodeFieldSpecified = value;
            }
        }
    }

}
