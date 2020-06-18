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
    public partial class OrderInterfaceResultListResultGroup
    {

        private string idField;

        private string commentsField;

        private bool isOpenField;

        private string itemsField;

        private string minStatusField;

        /// <remarks/>
        public string ID
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
        public bool IsOpen
        {
            get
            {
                return this.isOpenField;
            }
            set
            {
                this.isOpenField = value;
            }
        }

        /// <remarks/>
        public string Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        public string MinStatus
        {
            get
            {
                return this.minStatusField;
            }
            set
            {
                this.minStatusField = value;
            }
        }
    }


}
