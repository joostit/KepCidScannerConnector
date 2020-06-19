using System;
using System.Collections.Generic;
using System.Text;

namespace ScannerConnector.Http.Xml.Commands
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.8.3928.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://3shape.com/ThreeShape.HI.Manager.OrderInterface/Commands.xsd")]
    public partial class CommandListCommandCopyScans : Command
    {

        private string sourceOrderIDField;

        private string sourceGroupIDField;

        private string destinationOrderIDField;

        private string destinationGroupIDField;

        private FileCopyMode modeField;

        /// <remarks/>
        public string SourceOrderID
        {
            get
            {
                return this.sourceOrderIDField;
            }
            set
            {
                this.sourceOrderIDField = value;
            }
        }

        /// <remarks/>
        public string SourceGroupID
        {
            get
            {
                return this.sourceGroupIDField;
            }
            set
            {
                this.sourceGroupIDField = value;
            }
        }

        /// <remarks/>
        public string DestinationOrderID
        {
            get
            {
                return this.destinationOrderIDField;
            }
            set
            {
                this.destinationOrderIDField = value;
            }
        }

        /// <remarks/>
        public string DestinationGroupID
        {
            get
            {
                return this.destinationGroupIDField;
            }
            set
            {
                this.destinationGroupIDField = value;
            }
        }

        /// <remarks/>
        public FileCopyMode Mode
        {
            get
            {
                return this.modeField;
            }
            set
            {
                this.modeField = value;
            }
        }
    }

}
