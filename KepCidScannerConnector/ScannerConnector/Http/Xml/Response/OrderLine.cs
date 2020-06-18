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
    public partial class OrderLine
    {

        private string orderLineIDField;

        private string groupIDField;

        private string categoryIDField;

        private string modelIDField;

        private string sizeIDField;

        private string faceplateIDField;

        private string ventIDField;

        private double ventMassTargetField;

        private bool ventMassTargetFieldSpecified;

        private double ventMassField;

        private bool ventMassFieldSpecified;

        private double ventLengthField;

        private bool ventLengthFieldSpecified;

        private double ventVolumeField;

        private bool ventVolumeFieldSpecified;

        private string waxIDField;

        private string transducerIDField;

        private string shapeIDField;

        private string soundboreIDField;

        private double soundboreMassTargetField;

        private bool soundboreMassTargetFieldSpecified;

        private double soundboreMassField;

        private bool soundboreMassFieldSpecified;

        private double soundboreLengthField;

        private bool soundboreLengthFieldSpecified;

        private double soundboreVolumeField;

        private bool soundboreVolumeFieldSpecified;

        private string colorIDField;

        private string wingLockIDField;

        private Side sideField;

        private string integratedTelecoilField;

        private string shellTypeField;

        private string statusCodeField;

        private string iDTagField;

        private string serialNoField;

        private string lastChangedField;

        private string lastChangedByField;

        private string[] optionalComponentsField;

        private string[] offsetTemplatesField;

        private OrderLineCustomOrderField[] customOrderFieldsField;

        private string modelerIDField;

        private OrderLineMessage[] errorMarksField;

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
        public string CategoryID
        {
            get
            {
                return this.categoryIDField;
            }
            set
            {
                this.categoryIDField = value;
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
        public double VentMass
        {
            get
            {
                return this.ventMassField;
            }
            set
            {
                this.ventMassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VentMassSpecified
        {
            get
            {
                return this.ventMassFieldSpecified;
            }
            set
            {
                this.ventMassFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double VentLength
        {
            get
            {
                return this.ventLengthField;
            }
            set
            {
                this.ventLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VentLengthSpecified
        {
            get
            {
                return this.ventLengthFieldSpecified;
            }
            set
            {
                this.ventLengthFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double VentVolume
        {
            get
            {
                return this.ventVolumeField;
            }
            set
            {
                this.ventVolumeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VentVolumeSpecified
        {
            get
            {
                return this.ventVolumeFieldSpecified;
            }
            set
            {
                this.ventVolumeFieldSpecified = value;
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
        public double SoundboreMass
        {
            get
            {
                return this.soundboreMassField;
            }
            set
            {
                this.soundboreMassField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SoundboreMassSpecified
        {
            get
            {
                return this.soundboreMassFieldSpecified;
            }
            set
            {
                this.soundboreMassFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double SoundboreLength
        {
            get
            {
                return this.soundboreLengthField;
            }
            set
            {
                this.soundboreLengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SoundboreLengthSpecified
        {
            get
            {
                return this.soundboreLengthFieldSpecified;
            }
            set
            {
                this.soundboreLengthFieldSpecified = value;
            }
        }

        /// <remarks/>
        public double SoundboreVolume
        {
            get
            {
                return this.soundboreVolumeField;
            }
            set
            {
                this.soundboreVolumeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SoundboreVolumeSpecified
        {
            get
            {
                return this.soundboreVolumeFieldSpecified;
            }
            set
            {
                this.soundboreVolumeFieldSpecified = value;
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
        public string ShellType
        {
            get
            {
                return this.shellTypeField;
            }
            set
            {
                this.shellTypeField = value;
            }
        }

        /// <remarks/>
        public string StatusCode
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
        public string LastChanged
        {
            get
            {
                return this.lastChangedField;
            }
            set
            {
                this.lastChangedField = value;
            }
        }

        /// <remarks/>
        public string LastChangedBy
        {
            get
            {
                return this.lastChangedByField;
            }
            set
            {
                this.lastChangedByField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ID", IsNullable = false)]
        public string[] OptionalComponents
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
        public string ModelerID
        {
            get
            {
                return this.modelerIDField;
            }
            set
            {
                this.modelerIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Message", IsNullable = false)]
        public OrderLineMessage[] ErrorMarks
        {
            get
            {
                return this.errorMarksField;
            }
            set
            {
                this.errorMarksField = value;
            }
        }
    }


}
