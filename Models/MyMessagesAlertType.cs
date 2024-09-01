    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class MyMessagesAlertType
    {
        
        private string senderField;
        
        private string recipientUserIDField;
        
        private string subjectField;
        
        private string priorityField;
        
        private string alertIDField;
        
        private string externalAlertIDField;
        
        private string contentTypeField;
        
        private string textField;
        
        private MyMessagesAlertResolutionStatusCode resolutionStatusField;
        
        private bool resolutionStatusFieldSpecified;
        
        private bool readField;
        
        private bool readFieldSpecified;
        
        private System.DateTime creationDateField;
        
        private bool creationDateFieldSpecified;
        
        private System.DateTime receiveDateField;
        
        private bool receiveDateFieldSpecified;
        
        private System.DateTime expirationDateField;
        
        private bool expirationDateFieldSpecified;
        
        private System.DateTime resolutionDateField;
        
        private bool resolutionDateFieldSpecified;
        
        private System.DateTime lastReadDateField;
        
        private bool lastReadDateFieldSpecified;
        
        private string itemIDField;
        
        private bool isTimedResolutionField;
        
        private bool isTimedResolutionFieldSpecified;
        
        private string actionURLField;
        
        private MyMessagesResponseDetailsType responseDetailsField;
        
        private MyMessagesForwardDetailsType forwardDetailsField;
        
        private MyMessagesFolderType folderField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Sender
        {
            get
            {
                return this.senderField;
            }
            set
            {
                this.senderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string RecipientUserID
        {
            get
            {
                return this.recipientUserIDField;
            }
            set
            {
                this.recipientUserIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Subject
        {
            get
            {
                return this.subjectField;
            }
            set
            {
                this.subjectField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string AlertID
        {
            get
            {
                return this.alertIDField;
            }
            set
            {
                this.alertIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ExternalAlertID
        {
            get
            {
                return this.externalAlertIDField;
            }
            set
            {
                this.externalAlertIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ContentType
        {
            get
            {
                return this.contentTypeField;
            }
            set
            {
                this.contentTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MyMessagesAlertResolutionStatusCode ResolutionStatus
        {
            get
            {
                return this.resolutionStatusField;
            }
            set
            {
                this.resolutionStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResolutionStatusSpecified
        {
            get
            {
                return this.resolutionStatusFieldSpecified;
            }
            set
            {
                this.resolutionStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool Read
        {
            get
            {
                return this.readField;
            }
            set
            {
                this.readField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReadSpecified
        {
            get
            {
                return this.readFieldSpecified;
            }
            set
            {
                this.readFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime CreationDate
        {
            get
            {
                return this.creationDateField;
            }
            set
            {
                this.creationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreationDateSpecified
        {
            get
            {
                return this.creationDateFieldSpecified;
            }
            set
            {
                this.creationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime ReceiveDate
        {
            get
            {
                return this.receiveDateField;
            }
            set
            {
                this.receiveDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReceiveDateSpecified
        {
            get
            {
                return this.receiveDateFieldSpecified;
            }
            set
            {
                this.receiveDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime ExpirationDate
        {
            get
            {
                return this.expirationDateField;
            }
            set
            {
                this.expirationDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpirationDateSpecified
        {
            get
            {
                return this.expirationDateFieldSpecified;
            }
            set
            {
                this.expirationDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime ResolutionDate
        {
            get
            {
                return this.resolutionDateField;
            }
            set
            {
                this.resolutionDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ResolutionDateSpecified
        {
            get
            {
                return this.resolutionDateFieldSpecified;
            }
            set
            {
                this.resolutionDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime LastReadDate
        {
            get
            {
                return this.lastReadDateField;
            }
            set
            {
                this.lastReadDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastReadDateSpecified
        {
            get
            {
                return this.lastReadDateFieldSpecified;
            }
            set
            {
                this.lastReadDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ItemID
        {
            get
            {
                return this.itemIDField;
            }
            set
            {
                this.itemIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IsTimedResolution
        {
            get
            {
                return this.isTimedResolutionField;
            }
            set
            {
                this.isTimedResolutionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IsTimedResolutionSpecified
        {
            get
            {
                return this.isTimedResolutionFieldSpecified;
            }
            set
            {
                this.isTimedResolutionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ActionURL
        {
            get
            {
                return this.actionURLField;
            }
            set
            {
                this.actionURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MyMessagesResponseDetailsType ResponseDetails
        {
            get
            {
                return this.responseDetailsField;
            }
            set
            {
                this.responseDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MyMessagesForwardDetailsType ForwardDetails
        {
            get
            {
                return this.forwardDetailsField;
            }
            set
            {
                this.forwardDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MyMessagesFolderType Folder
        {
            get
            {
                return this.folderField;
            }
            set
            {
                this.folderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute( )]
        public System.Xml.XmlElement[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }
