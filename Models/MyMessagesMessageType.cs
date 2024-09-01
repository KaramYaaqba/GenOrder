    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class MyMessagesMessageType
    {
        
        private string senderField;
        
        private string recipientUserIDField;
        
        private string sendToNameField;
        
        private string subjectField;
        
        private string messageIDField;
        
        private string externalMessageIDField;
        
        private string contentTypeField;
        
        private string textField;
        
        private bool flaggedField;
        
        private bool flaggedFieldSpecified;
        
        private bool readField;
        
        private bool readFieldSpecified;
        
        private System.DateTime creationDateField;
        
        private bool creationDateFieldSpecified;
        
        private System.DateTime receiveDateField;
        
        private bool receiveDateFieldSpecified;
        
        private System.DateTime expirationDateField;
        
        private bool expirationDateFieldSpecified;
        
        private string itemIDField;
        
        private MyMessagesResponseDetailsType responseDetailsField;
        
        private MyMessagesForwardDetailsType forwardDetailsField;
        
        private MyMessagesFolderType folderField;
        
        private string contentField;
        
        private MessageTypeCodeType messageTypeField;
        
        private bool messageTypeFieldSpecified;
        
        private ListingStatusCodeType listingStatusField;
        
        private bool listingStatusFieldSpecified;
        
        private QuestionTypeCodeType questionTypeField;
        
        private bool questionTypeFieldSpecified;
        
        private bool repliedField;
        
        private bool repliedFieldSpecified;
        
        private bool highPriorityField;
        
        private bool highPriorityFieldSpecified;
        
        private System.DateTime itemEndTimeField;
        
        private bool itemEndTimeFieldSpecified;
        
        private string itemTitleField;
        
        private MessageMediaType[] messageMediaField;
        
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
        public string SendToName
        {
            get
            {
                return this.sendToNameField;
            }
            set
            {
                this.sendToNameField = value;
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
        public string MessageID
        {
            get
            {
                return this.messageIDField;
            }
            set
            {
                this.messageIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ExternalMessageID
        {
            get
            {
                return this.externalMessageIDField;
            }
            set
            {
                this.externalMessageIDField = value;
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
        public bool Flagged
        {
            get
            {
                return this.flaggedField;
            }
            set
            {
                this.flaggedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FlaggedSpecified
        {
            get
            {
                return this.flaggedFieldSpecified;
            }
            set
            {
                this.flaggedFieldSpecified = value;
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
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Content
        {
            get
            {
                return this.contentField;
            }
            set
            {
                this.contentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MessageTypeCodeType MessageType
        {
            get
            {
                return this.messageTypeField;
            }
            set
            {
                this.messageTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MessageTypeSpecified
        {
            get
            {
                return this.messageTypeFieldSpecified;
            }
            set
            {
                this.messageTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ListingStatusCodeType ListingStatus
        {
            get
            {
                return this.listingStatusField;
            }
            set
            {
                this.listingStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ListingStatusSpecified
        {
            get
            {
                return this.listingStatusFieldSpecified;
            }
            set
            {
                this.listingStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public QuestionTypeCodeType QuestionType
        {
            get
            {
                return this.questionTypeField;
            }
            set
            {
                this.questionTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuestionTypeSpecified
        {
            get
            {
                return this.questionTypeFieldSpecified;
            }
            set
            {
                this.questionTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool Replied
        {
            get
            {
                return this.repliedField;
            }
            set
            {
                this.repliedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RepliedSpecified
        {
            get
            {
                return this.repliedFieldSpecified;
            }
            set
            {
                this.repliedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool HighPriority
        {
            get
            {
                return this.highPriorityField;
            }
            set
            {
                this.highPriorityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HighPrioritySpecified
        {
            get
            {
                return this.highPriorityFieldSpecified;
            }
            set
            {
                this.highPriorityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime ItemEndTime
        {
            get
            {
                return this.itemEndTimeField;
            }
            set
            {
                this.itemEndTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemEndTimeSpecified
        {
            get
            {
                return this.itemEndTimeFieldSpecified;
            }
            set
            {
                this.itemEndTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ItemTitle
        {
            get
            {
                return this.itemTitleField;
            }
            set
            {
                this.itemTitleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MessageMedia" )]
        public MessageMediaType[] MessageMedia
        {
            get
            {
                return this.messageMediaField;
            }
            set
            {
                this.messageMediaField = value;
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
