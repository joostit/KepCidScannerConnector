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
    public partial class CommandDispenserCreate : Command
    {

        private string clinicIDField;

        private string nameField;

        private string address1Field;

        private string address2Field;

        private string zipField;

        private string cityField;

        private string countryField;

        private string phoneField;

        private string clinicExtIDField;

        private bool isActiveField;

        private string contactPersonField;

        private string commentsField;

        private string fTPDirField;

        private string shortNameField;

        private string clinicExtID2Field;

        private string stateField;

        private string zIPPasswordField;

        private string remoteLoginField;

        private string remotePasswordField;

        private bool importExportIsEnableField;

        private string groupIDField;

        public CommandDispenserCreate()
        {
            this.isActiveField = true;
            this.importExportIsEnableField = true;
        }

        /// <remarks/>
        public string ClinicID
        {
            get
            {
                return this.clinicIDField;
            }
            set
            {
                this.clinicIDField = value;
            }
        }

        /// <remarks/>
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
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
        public string Phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        public string ClinicExtID
        {
            get
            {
                return this.clinicExtIDField;
            }
            set
            {
                this.clinicExtIDField = value;
            }
        }

        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool IsActive
        {
            get
            {
                return this.isActiveField;
            }
            set
            {
                this.isActiveField = value;
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
        public string FTPDir
        {
            get
            {
                return this.fTPDirField;
            }
            set
            {
                this.fTPDirField = value;
            }
        }

        /// <remarks/>
        public string ShortName
        {
            get
            {
                return this.shortNameField;
            }
            set
            {
                this.shortNameField = value;
            }
        }

        /// <remarks/>
        public string ClinicExtID2
        {
            get
            {
                return this.clinicExtID2Field;
            }
            set
            {
                this.clinicExtID2Field = value;
            }
        }

        /// <remarks/>
        public string State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        public string ZIPPassword
        {
            get
            {
                return this.zIPPasswordField;
            }
            set
            {
                this.zIPPasswordField = value;
            }
        }

        /// <remarks/>
        public string RemoteLogin
        {
            get
            {
                return this.remoteLoginField;
            }
            set
            {
                this.remoteLoginField = value;
            }
        }

        /// <remarks/>
        public string RemotePassword
        {
            get
            {
                return this.remotePasswordField;
            }
            set
            {
                this.remotePasswordField = value;
            }
        }

        /// <remarks/>
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool ImportExportIsEnable
        {
            get
            {
                return this.importExportIsEnableField;
            }
            set
            {
                this.importExportIsEnableField = value;
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
    }

}
