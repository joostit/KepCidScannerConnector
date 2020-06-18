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
    public partial class OrderInterfaceResultListResult
    {

        private string messageField;

        private int errorCodeField;

        private bool errorCodeFieldSpecified;

        private OrderInterfaceResultListResultFlag flagField;

        private OrderInterfaceResultListResultVersionNumber versionNumberField;

        private OrderInterfaceResultListResultAttachment[] attachmentListField;

        private NameIDPair[] colorListField;

        private string[] createdOrderListField;

        private NameIDPair[] dispenserListField;

        private ErrorEntry[] errorListField;

        private NameIDPair[] faceplateListField;

        private OrderInterfaceResultListResultGroup[] groupListField;

        private NameIDPair[] modelListField;

        private NameIDPair[] offsetTemplateListField;

        private OrderInterfaceResultListResultOptionalComponent[] optionalComponentListField;

        private OrderInterfaceResultListResultCustomField[] customFieldListField;

        private OrderBriefDetails[] orderListField;

        private OrderShortInfo[] orderShortInfoListField;

        private NameIDPair[] shapeListField;

        private NameIDPair[] shellSizeListField;

        private OrderInterfaceResultListResultSite[] siteListField;

        private NameIDPair[] soundboreListField;

        private NameIDPair[] statusListField;

        private NameIDPair[] transducerListField;

        private NameIDPair[] ventListField;

        private NameIDPair[] waxListField;

        private OrderFullDetails orderField;

        private TestOrder queryCreateOrderField;

        private OrderInterfaceResultListResultScan scanField;

        private int accessLevelField;

        private bool accessLevelFieldSpecified;

        private bool successField;

        private bool successFieldSpecified;

        private string idField;

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
        public int ErrorCode
        {
            get
            {
                return this.errorCodeField;
            }
            set
            {
                this.errorCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ErrorCodeSpecified
        {
            get
            {
                return this.errorCodeFieldSpecified;
            }
            set
            {
                this.errorCodeFieldSpecified = value;
            }
        }

        /// <remarks/>
        public OrderInterfaceResultListResultFlag Flag
        {
            get
            {
                return this.flagField;
            }
            set
            {
                this.flagField = value;
            }
        }

        /// <remarks/>
        public OrderInterfaceResultListResultVersionNumber VersionNumber
        {
            get
            {
                return this.versionNumberField;
            }
            set
            {
                this.versionNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Attachment", IsNullable = false)]
        public OrderInterfaceResultListResultAttachment[] AttachmentList
        {
            get
            {
                return this.attachmentListField;
            }
            set
            {
                this.attachmentListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Color", IsNullable = false)]
        public NameIDPair[] ColorList
        {
            get
            {
                return this.colorListField;
            }
            set
            {
                this.colorListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OrderID", IsNullable = false)]
        public string[] CreatedOrderList
        {
            get
            {
                return this.createdOrderListField;
            }
            set
            {
                this.createdOrderListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Dispenser", IsNullable = false)]
        public NameIDPair[] DispenserList
        {
            get
            {
                return this.dispenserListField;
            }
            set
            {
                this.dispenserListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Error", IsNullable = false)]
        public ErrorEntry[] ErrorList
        {
            get
            {
                return this.errorListField;
            }
            set
            {
                this.errorListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Faceplate", IsNullable = false)]
        public NameIDPair[] FaceplateList
        {
            get
            {
                return this.faceplateListField;
            }
            set
            {
                this.faceplateListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Group", IsNullable = false)]
        public OrderInterfaceResultListResultGroup[] GroupList
        {
            get
            {
                return this.groupListField;
            }
            set
            {
                this.groupListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Model", IsNullable = false)]
        public NameIDPair[] ModelList
        {
            get
            {
                return this.modelListField;
            }
            set
            {
                this.modelListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OffsetTemplate", IsNullable = false)]
        public NameIDPair[] OffsetTemplateList
        {
            get
            {
                return this.offsetTemplateListField;
            }
            set
            {
                this.offsetTemplateListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OptionalComponent", IsNullable = false)]
        public OrderInterfaceResultListResultOptionalComponent[] OptionalComponentList
        {
            get
            {
                return this.optionalComponentListField;
            }
            set
            {
                this.optionalComponentListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CustomField", IsNullable = false)]
        public OrderInterfaceResultListResultCustomField[] CustomFieldList
        {
            get
            {
                return this.customFieldListField;
            }
            set
            {
                this.customFieldListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Order", IsNullable = false)]
        public OrderBriefDetails[] OrderList
        {
            get
            {
                return this.orderListField;
            }
            set
            {
                this.orderListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute(IsNullable = false)]
        public OrderShortInfo[] OrderShortInfoList
        {
            get
            {
                return this.orderShortInfoListField;
            }
            set
            {
                this.orderShortInfoListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Shape", IsNullable = false)]
        public NameIDPair[] ShapeList
        {
            get
            {
                return this.shapeListField;
            }
            set
            {
                this.shapeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ShellSize", IsNullable = false)]
        public NameIDPair[] ShellSizeList
        {
            get
            {
                return this.shellSizeListField;
            }
            set
            {
                this.shellSizeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Site", IsNullable = false)]
        public OrderInterfaceResultListResultSite[] SiteList
        {
            get
            {
                return this.siteListField;
            }
            set
            {
                this.siteListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Soundbore", IsNullable = false)]
        public NameIDPair[] SoundboreList
        {
            get
            {
                return this.soundboreListField;
            }
            set
            {
                this.soundboreListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Status", IsNullable = false)]
        public NameIDPair[] StatusList
        {
            get
            {
                return this.statusListField;
            }
            set
            {
                this.statusListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Transducer", IsNullable = false)]
        public NameIDPair[] TransducerList
        {
            get
            {
                return this.transducerListField;
            }
            set
            {
                this.transducerListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Vent", IsNullable = false)]
        public NameIDPair[] VentList
        {
            get
            {
                return this.ventListField;
            }
            set
            {
                this.ventListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Wax", IsNullable = false)]
        public NameIDPair[] WaxList
        {
            get
            {
                return this.waxListField;
            }
            set
            {
                this.waxListField = value;
            }
        }

        /// <remarks/>
        public OrderFullDetails Order
        {
            get
            {
                return this.orderField;
            }
            set
            {
                this.orderField = value;
            }
        }

        /// <remarks/>
        public TestOrder QueryCreateOrder
        {
            get
            {
                return this.queryCreateOrderField;
            }
            set
            {
                this.queryCreateOrderField = value;
            }
        }

        /// <remarks/>
        public OrderInterfaceResultListResultScan Scan
        {
            get
            {
                return this.scanField;
            }
            set
            {
                this.scanField = value;
            }
        }

        /// <remarks/>
        public int AccessLevel
        {
            get
            {
                return this.accessLevelField;
            }
            set
            {
                this.accessLevelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccessLevelSpecified
        {
            get
            {
                return this.accessLevelFieldSpecified;
            }
            set
            {
                this.accessLevelFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool success
        {
            get
            {
                return this.successField;
            }
            set
            {
                this.successField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool successSpecified
        {
            get
            {
                return this.successFieldSpecified;
            }
            set
            {
                this.successFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
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
    }


}
