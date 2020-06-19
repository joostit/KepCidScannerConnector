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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://3shape.com/ThreeShape.HI.Manager.OrderInterface/Commands.xsd")]
    public partial class OrderLine
    {

        private Status statusCodeField;

        private bool statusCodeFieldSpecified;

        private string orderLineIDField;

        private string groupIDField;

        private string modelIDField;

        private string sizeIDField;

        private string shellThicknessIDField;

        private string integratedTelecoilField;

        private string faceplateIDField;

        private string ventIDField;

        private double ventMassTargetField;

        private bool ventMassTargetFieldSpecified;

        private string waxIDField;

        private string transducerIDField;

        private string shapeIDField;

        private string soundboreIDField;

        private double soundboreMassTargetField;

        private bool soundboreMassTargetFieldSpecified;

        private string colorIDField;

        private string wingLockIDField;

        private Side sideField;

        private string integratedFaceplateField;

        private string iDTagField;

        private string serialNoField;

        private OrderLineID[] unqualifiedComponentsField;

        private OrderLineID1[] optionalComponentsField;

        private OrderLineCustomOrderField[] customOrderFieldsField;

        private OrderLineFiltering filteringField;

        private string[] offsetTemplatesField;

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

        /// <remarks/>
        public string OrderLineID
        {
            get
            {
                return this.orderLineIDField;
            }
            set
            {
                this.orderLineIDField = value;
            }
        }

        /// <remarks/>
        public string GroupID
        {
            get
            {
                return this.groupIDField;
            }
            set
            {
                this.groupIDField = value;
            }
        }

        /// <remarks/>
        public string ModelID
        {
            get
            {
                return this.modelIDField;
            }
            set
            {
                this.modelIDField = value;
            }
        }

        /// <remarks/>
        public string SizeID
        {
            get
            {
                return this.sizeIDField;
            }
            set
            {
                this.sizeIDField = value;
            }
        }

        /// <remarks/>
        public string ShellThicknessID
        {
            get
            {
                return this.shellThicknessIDField;
            }
            set
            {
                this.shellThicknessIDField = value;
            }
        }

        /// <remarks/>
        public string IntegratedTelecoil
        {
            get
            {
                return this.integratedTelecoilField;
            }
            set
            {
                this.integratedTelecoilField = value;
            }
        }

        /// <remarks/>
        public string FaceplateID
        {
            get
            {
                return this.faceplateIDField;
            }
            set
            {
                this.faceplateIDField = value;
            }
        }

        /// <remarks/>
        public string VentID
        {
            get
            {
                return this.ventIDField;
            }
            set
            {
                this.ventIDField = value;
            }
        }

        /// <remarks/>
        public double VentMassTarget
        {
            get
            {
                return this.ventMassTargetField;
            }
            set
            {
                this.ventMassTargetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VentMassTargetSpecified
        {
            get
            {
                return this.ventMassTargetFieldSpecified;
            }
            set
            {
                this.ventMassTargetFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string WaxID
        {
            get
            {
                return this.waxIDField;
            }
            set
            {
                this.waxIDField = value;
            }
        }

        /// <remarks/>
        public string TransducerID
        {
            get
            {
                return this.transducerIDField;
            }
            set
            {
                this.transducerIDField = value;
            }
        }

        /// <remarks/>
        public string ShapeID
        {
            get
            {
                return this.shapeIDField;
            }
            set
            {
                this.shapeIDField = value;
            }
        }

        /// <remarks/>
        public string SoundboreID
        {
            get
            {
                return this.soundboreIDField;
            }
            set
            {
                this.soundboreIDField = value;
            }
        }

        /// <remarks/>
        public double SoundboreMassTarget
        {
            get
            {
                return this.soundboreMassTargetField;
            }
            set
            {
                this.soundboreMassTargetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SoundboreMassTargetSpecified
        {
            get
            {
                return this.soundboreMassTargetFieldSpecified;
            }
            set
            {
                this.soundboreMassTargetFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string ColorID
        {
            get
            {
                return this.colorIDField;
            }
            set
            {
                this.colorIDField = value;
            }
        }

        /// <remarks/>
        public string WingLockID
        {
            get
            {
                return this.wingLockIDField;
            }
            set
            {
                this.wingLockIDField = value;
            }
        }

        /// <remarks/>
        public Side Side
        {
            get
            {
                return this.sideField;
            }
            set
            {
                this.sideField = value;
            }
        }

        /// <remarks/>
        public string IntegratedFaceplate
        {
            get
            {
                return this.integratedFaceplateField;
            }
            set
            {
                this.integratedFaceplateField = value;
            }
        }

        /// <remarks/>
        public string IDTag
        {
            get
            {
                return this.iDTagField;
            }
            set
            {
                this.iDTagField = value;
            }
        }

        /// <remarks/>
        public string SerialNo
        {
            get
            {
                return this.serialNoField;
            }
            set
            {
                this.serialNoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ID", IsNullable = false)]
        public OrderLineID[] UnqualifiedComponents
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

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ID", IsNullable = false)]
        public OrderLineID1[] OptionalComponents
        {
            get
            {
                return this.optionalComponentsField;
            }
            set
            {
                this.optionalComponentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CustomOrderField", IsNullable = false)]
        public OrderLineCustomOrderField[] CustomOrderFields
        {
            get
            {
                return this.customOrderFieldsField;
            }
            set
            {
                this.customOrderFieldsField = value;
            }
        }

        /// <remarks/>
        public OrderLineFiltering Filtering
        {
            get
            {
                return this.filteringField;
            }
            set
            {
                this.filteringField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ID", IsNullable = false)]
        public string[] OffsetTemplates
        {
            get
            {
                return this.offsetTemplatesField;
            }
            set
            {
                this.offsetTemplatesField = value;
            }
        }
    }

}
