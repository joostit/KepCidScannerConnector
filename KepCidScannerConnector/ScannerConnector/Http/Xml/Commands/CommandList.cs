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
    public partial class CommandList
    {

        private CommandWithRestriction[] commandGetColorListField;

        private CommandOrderGetCreatedList[] commandGetCreatedOrderListField;

        private Command[] commandGetDispenserListField;

        private CommandWithRestriction[] commandGetFaceplateListField;

        private CommandGroupGetList[] commandGetGroupListField;

        private CommandModelGetList[] commandGetModelListField;

        private CommandWithRestriction[] commandGetOffsetTemplateListField;

        private CommandWithRestriction[] commandGetOptionalComponentListField;

        private CommandGroup[] commandGetOrderListField;

        private CommandGroup[] commandGetOrdersShortInfoField;

        private Command commandGetSitesField;

        private CommandWithRestriction[] commandGetSoundboreListField;

        private CommandWithRestriction[] commandGetShapeListField;

        private Command[] commandGetShellSizeListField;

        private Command[] commandGetStatusListField;

        private CommandWithRestriction[] commandGetTransducerListField;

        private CommandWithRestriction[] commandGetVentListField;

        private CommandWithRestriction[] commandGetWaxListField;

        private CommandWithRestriction[] commandGetCustomFieldListField;

        private CommandListCommandErrorMark[] commandErrorMarkField;

        private CommandListCommandGetErrors[] commandGetErrorsField;

        private CommandListCommandEarLocked[] commandEarLockedField;

        private CommandListCommandLockEar[] commandLockEarField;

        private CommandGroup[] commandCloseGroupField;

        private CommandGroupCreate[] commandCreateGroupField;

        private CommandGroup[] commandFinalizeGroupField;

        private CommandGroup[] commandOpenGroupField;

        private CommandListCommandCopyScans[] commandCopyScansField;

        private CommandOrderCreate[] commandCreateOrderField;

        private CommandOrderCreateOrUpdate[] commandCreateOrUpdateOrderField;

        private CommandOrder[] commandDeleteOrderField;

        private CommandOrderCreate[] commandQueryCreateOrderField;

        private CommandOrder[] commandReadOrderField;

        private CommandOrderRemake[] commandRemakeOrderField;

        private CommandListCommandTransferOrder[] commandTransferOrderField;

        private CommandListCommandReturnOrder[] commandReturnOrderField;

        private CommandOrderUpdate[] commandUpdateOrderField;

        private CommandListCommandGetScan[] commandGetScanField;

        private CommandScanSave[] commandSaveScanField;

        private CommandOrderAttachmentAdd[] commandAddOrderAttachmentField;

        private CommandOrderAttachmentDelete[] commandDeleteOrderAttachmentField;

        private CommandOrderAttachmentDeleteAll[] commandDeleteAllOrderAttachmentsField;

        private CommandOrderAttachmentGetAll[] commandGetAllOrderAttachmentsField;

        private CommandListCommandScanExists[] commandScanExistsField;

        private CommandListCommandMoveOrderToGroup[] commandMoveOrderToGroupField;

        private CommandListCommandCheckLogin commandCheckLoginField;

        private CommandDispenserCreate[] commandCreateDispenserField;

        private Command[] commandGetVersionNumberField;

        private CommandListCommandSearch commandSearchField;

        private CommandListCommandSiteExists[] commandSiteExistsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandGetColorList")]
        public CommandWithRestriction[] CommandGetColorList
        {
            get
            {
                return this.commandGetColorListField;
            }
            set
            {
                this.commandGetColorListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandGetCreatedOrderList")]
        public CommandOrderGetCreatedList[] CommandGetCreatedOrderList
        {
            get
            {
                return this.commandGetCreatedOrderListField;
            }
            set
            {
                this.commandGetCreatedOrderListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandGetDispenserList")]
        public Command[] CommandGetDispenserList
        {
            get
            {
                return this.commandGetDispenserListField;
            }
            set
            {
                this.commandGetDispenserListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandGetFaceplateList")]
        public CommandWithRestriction[] CommandGetFaceplateList
        {
            get
            {
                return this.commandGetFaceplateListField;
            }
            set
            {
                this.commandGetFaceplateListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandGetGroupList")]
        public CommandGroupGetList[] CommandGetGroupList
        {
            get
            {
                return this.commandGetGroupListField;
            }
            set
            {
                this.commandGetGroupListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandGetModelList")]
        public CommandModelGetList[] CommandGetModelList
        {
            get
            {
                return this.commandGetModelListField;
            }
            set
            {
                this.commandGetModelListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandGetOffsetTemplateList")]
        public CommandWithRestriction[] CommandGetOffsetTemplateList
        {
            get
            {
                return this.commandGetOffsetTemplateListField;
            }
            set
            {
                this.commandGetOffsetTemplateListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandGetOptionalComponentList")]
        public CommandWithRestriction[] CommandGetOptionalComponentList
        {
            get
            {
                return this.commandGetOptionalComponentListField;
            }
            set
            {
                this.commandGetOptionalComponentListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandGetOrderList")]
        public CommandGroup[] CommandGetOrderList
        {
            get
            {
                return this.commandGetOrderListField;
            }
            set
            {
                this.commandGetOrderListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandGetOrdersShortInfo")]
        public CommandGroup[] CommandGetOrdersShortInfo
        {
            get
            {
                return this.commandGetOrdersShortInfoField;
            }
            set
            {
                this.commandGetOrdersShortInfoField = value;
            }
        }

        /// <remarks/>
        public Command CommandGetSites
        {
            get
            {
                return this.commandGetSitesField;
            }
            set
            {
                this.commandGetSitesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandGetSoundboreList")]
        public CommandWithRestriction[] CommandGetSoundboreList
        {
            get
            {
                return this.commandGetSoundboreListField;
            }
            set
            {
                this.commandGetSoundboreListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandGetShapeList")]
        public CommandWithRestriction[] CommandGetShapeList
        {
            get
            {
                return this.commandGetShapeListField;
            }
            set
            {
                this.commandGetShapeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandGetShellSizeList")]
        public Command[] CommandGetShellSizeList
        {
            get
            {
                return this.commandGetShellSizeListField;
            }
            set
            {
                this.commandGetShellSizeListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandGetStatusList")]
        public Command[] CommandGetStatusList
        {
            get
            {
                return this.commandGetStatusListField;
            }
            set
            {
                this.commandGetStatusListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandGetTransducerList")]
        public CommandWithRestriction[] CommandGetTransducerList
        {
            get
            {
                return this.commandGetTransducerListField;
            }
            set
            {
                this.commandGetTransducerListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandGetVentList")]
        public CommandWithRestriction[] CommandGetVentList
        {
            get
            {
                return this.commandGetVentListField;
            }
            set
            {
                this.commandGetVentListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandGetWaxList")]
        public CommandWithRestriction[] CommandGetWaxList
        {
            get
            {
                return this.commandGetWaxListField;
            }
            set
            {
                this.commandGetWaxListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandGetCustomFieldList")]
        public CommandWithRestriction[] CommandGetCustomFieldList
        {
            get
            {
                return this.commandGetCustomFieldListField;
            }
            set
            {
                this.commandGetCustomFieldListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandErrorMark")]
        public CommandListCommandErrorMark[] CommandErrorMark
        {
            get
            {
                return this.commandErrorMarkField;
            }
            set
            {
                this.commandErrorMarkField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandGetErrors")]
        public CommandListCommandGetErrors[] CommandGetErrors
        {
            get
            {
                return this.commandGetErrorsField;
            }
            set
            {
                this.commandGetErrorsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandEarLocked")]
        public CommandListCommandEarLocked[] CommandEarLocked
        {
            get
            {
                return this.commandEarLockedField;
            }
            set
            {
                this.commandEarLockedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandLockEar")]
        public CommandListCommandLockEar[] CommandLockEar
        {
            get
            {
                return this.commandLockEarField;
            }
            set
            {
                this.commandLockEarField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandCloseGroup")]
        public CommandGroup[] CommandCloseGroup
        {
            get
            {
                return this.commandCloseGroupField;
            }
            set
            {
                this.commandCloseGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandCreateGroup")]
        public CommandGroupCreate[] CommandCreateGroup
        {
            get
            {
                return this.commandCreateGroupField;
            }
            set
            {
                this.commandCreateGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandFinalizeGroup")]
        public CommandGroup[] CommandFinalizeGroup
        {
            get
            {
                return this.commandFinalizeGroupField;
            }
            set
            {
                this.commandFinalizeGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandOpenGroup")]
        public CommandGroup[] CommandOpenGroup
        {
            get
            {
                return this.commandOpenGroupField;
            }
            set
            {
                this.commandOpenGroupField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandCopyScans")]
        public CommandListCommandCopyScans[] CommandCopyScans
        {
            get
            {
                return this.commandCopyScansField;
            }
            set
            {
                this.commandCopyScansField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandCreateOrder")]
        public CommandOrderCreate[] CommandCreateOrder
        {
            get
            {
                return this.commandCreateOrderField;
            }
            set
            {
                this.commandCreateOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandCreateOrUpdateOrder")]
        public CommandOrderCreateOrUpdate[] CommandCreateOrUpdateOrder
        {
            get
            {
                return this.commandCreateOrUpdateOrderField;
            }
            set
            {
                this.commandCreateOrUpdateOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandDeleteOrder")]
        public CommandOrder[] CommandDeleteOrder
        {
            get
            {
                return this.commandDeleteOrderField;
            }
            set
            {
                this.commandDeleteOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandQueryCreateOrder")]
        public CommandOrderCreate[] CommandQueryCreateOrder
        {
            get
            {
                return this.commandQueryCreateOrderField;
            }
            set
            {
                this.commandQueryCreateOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandReadOrder")]
        public CommandOrder[] CommandReadOrder
        {
            get
            {
                return this.commandReadOrderField;
            }
            set
            {
                this.commandReadOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandRemakeOrder")]
        public CommandOrderRemake[] CommandRemakeOrder
        {
            get
            {
                return this.commandRemakeOrderField;
            }
            set
            {
                this.commandRemakeOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandTransferOrder")]
        public CommandListCommandTransferOrder[] CommandTransferOrder
        {
            get
            {
                return this.commandTransferOrderField;
            }
            set
            {
                this.commandTransferOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandReturnOrder")]
        public CommandListCommandReturnOrder[] CommandReturnOrder
        {
            get
            {
                return this.commandReturnOrderField;
            }
            set
            {
                this.commandReturnOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandUpdateOrder")]
        public CommandOrderUpdate[] CommandUpdateOrder
        {
            get
            {
                return this.commandUpdateOrderField;
            }
            set
            {
                this.commandUpdateOrderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandGetScan")]
        public CommandListCommandGetScan[] CommandGetScan
        {
            get
            {
                return this.commandGetScanField;
            }
            set
            {
                this.commandGetScanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandSaveScan")]
        public CommandScanSave[] CommandSaveScan
        {
            get
            {
                return this.commandSaveScanField;
            }
            set
            {
                this.commandSaveScanField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandAddOrderAttachment")]
        public CommandOrderAttachmentAdd[] CommandAddOrderAttachment
        {
            get
            {
                return this.commandAddOrderAttachmentField;
            }
            set
            {
                this.commandAddOrderAttachmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandDeleteOrderAttachment")]
        public CommandOrderAttachmentDelete[] CommandDeleteOrderAttachment
        {
            get
            {
                return this.commandDeleteOrderAttachmentField;
            }
            set
            {
                this.commandDeleteOrderAttachmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandDeleteAllOrderAttachments")]
        public CommandOrderAttachmentDeleteAll[] CommandDeleteAllOrderAttachments
        {
            get
            {
                return this.commandDeleteAllOrderAttachmentsField;
            }
            set
            {
                this.commandDeleteAllOrderAttachmentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandGetAllOrderAttachments")]
        public CommandOrderAttachmentGetAll[] CommandGetAllOrderAttachments
        {
            get
            {
                return this.commandGetAllOrderAttachmentsField;
            }
            set
            {
                this.commandGetAllOrderAttachmentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandScanExists")]
        public CommandListCommandScanExists[] CommandScanExists
        {
            get
            {
                return this.commandScanExistsField;
            }
            set
            {
                this.commandScanExistsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandMoveOrderToGroup")]
        public CommandListCommandMoveOrderToGroup[] CommandMoveOrderToGroup
        {
            get
            {
                return this.commandMoveOrderToGroupField;
            }
            set
            {
                this.commandMoveOrderToGroupField = value;
            }
        }

        /// <remarks/>
        public CommandListCommandCheckLogin CommandCheckLogin
        {
            get
            {
                return this.commandCheckLoginField;
            }
            set
            {
                this.commandCheckLoginField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandCreateDispenser")]
        public CommandDispenserCreate[] CommandCreateDispenser
        {
            get
            {
                return this.commandCreateDispenserField;
            }
            set
            {
                this.commandCreateDispenserField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandGetVersionNumber")]
        public Command[] CommandGetVersionNumber
        {
            get
            {
                return this.commandGetVersionNumberField;
            }
            set
            {
                this.commandGetVersionNumberField = value;
            }
        }

        /// <remarks/>
        public CommandListCommandSearch CommandSearch
        {
            get
            {
                return this.commandSearchField;
            }
            set
            {
                this.commandSearchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommandSiteExists")]
        public CommandListCommandSiteExists[] CommandSiteExists
        {
            get
            {
                return this.commandSiteExistsField;
            }
            set
            {
                this.commandSiteExistsField = value;
            }
        }
    }

}
