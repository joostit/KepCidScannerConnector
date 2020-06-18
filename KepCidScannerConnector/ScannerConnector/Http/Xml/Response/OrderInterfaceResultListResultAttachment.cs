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
    public partial class OrderInterfaceResultListResultAttachment
    {

        private string filenameField;

        private string sizeInBytesField;

        /// <remarks/>
        public string Filename
        {
            get
            {
                return this.filenameField;
            }
            set
            {
                this.filenameField = value;
            }
        }

        /// <remarks/>
        public string SizeInBytes
        {
            get
            {
                return this.sizeInBytesField;
            }
            set
            {
                this.sizeInBytesField = value;
            }
        }
    }


}
