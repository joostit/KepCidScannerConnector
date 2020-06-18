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
    public partial class TestOrderLine
    {

        private TestResult orderLineIDField;

        private TestResult groupIDField;

        private TestResult modelIDField;

        private TestResult sizeIDField;

        private TestResult faceplateIDField;

        private TestResult ventIDField;

        private TestResult waxIDField;

        private TestResult transducerIDField;

        private TestResult shapeIDField;

        private TestResult soundboreIDField;

        private TestResult colorIDField;

        private TestResult sideField;

        private TestResult integratedFaceplateField;

        private TestResult iDTagField;

        private TestOrderLineOptionalComponents optionalComponentsField;

        private string[] offsetTemplatesField;

        /// <remarks/>
        public TestResult OrderLineID
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
        public TestResult GroupID
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
        public TestResult ModelID
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
        public TestResult SizeID
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
        public TestResult FaceplateID
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
        public TestResult VentID
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
        public TestResult WaxID
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
        public TestResult TransducerID
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
        public TestResult ShapeID
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
        public TestResult SoundboreID
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
        public TestResult ColorID
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
        public TestResult Side
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
        public TestResult IntegratedFaceplate
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
        public TestResult IDTag
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
        public TestOrderLineOptionalComponents OptionalComponents
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
    }


}
