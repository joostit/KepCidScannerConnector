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
    public partial class CommandWithRestriction : Command
    {

        private string categoryIDField;

        private string modelIDField;

        private string sizeIDField;

        private string integratedTelecoilField;

        private string faceplateIDField;

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
    }

}
