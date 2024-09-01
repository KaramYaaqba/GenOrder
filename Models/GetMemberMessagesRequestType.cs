    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetMemberMessagesRequestType : AbstractRequestType
    {
        
        private string itemIDField;
        
        private MessageTypeCodeType mailMessageTypeField;
        
        private bool mailMessageTypeFieldSpecified;
        
        private MessageStatusTypeCodeType messageStatusField;
        
        private bool messageStatusFieldSpecified;
        
        private bool displayToPublicField;
        
        private bool displayToPublicFieldSpecified;
        
        private System.DateTime startCreationTimeField;
        
        private bool startCreationTimeFieldSpecified;
        
        private System.DateTime endCreationTimeField;
        
        private bool endCreationTimeFieldSpecified;
        
        private PaginationType paginationField;
        
        private string memberMessageIDField;
        
        private string senderIDField;
        
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
        public MessageTypeCodeType MailMessageType
        {
            get
            {
                return this.mailMessageTypeField;
            }
            set
            {
                this.mailMessageTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MailMessageTypeSpecified
        {
            get
            {
                return this.mailMessageTypeFieldSpecified;
            }
            set
            {
                this.mailMessageTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MessageStatusTypeCodeType MessageStatus
        {
            get
            {
                return this.messageStatusField;
            }
            set
            {
                this.messageStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MessageStatusSpecified
        {
            get
            {
                return this.messageStatusFieldSpecified;
            }
            set
            {
                this.messageStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool DisplayToPublic
        {
            get
            {
                return this.displayToPublicField;
            }
            set
            {
                this.displayToPublicField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisplayToPublicSpecified
        {
            get
            {
                return this.displayToPublicFieldSpecified;
            }
            set
            {
                this.displayToPublicFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime StartCreationTime
        {
            get
            {
                return this.startCreationTimeField;
            }
            set
            {
                this.startCreationTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StartCreationTimeSpecified
        {
            get
            {
                return this.startCreationTimeFieldSpecified;
            }
            set
            {
                this.startCreationTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime EndCreationTime
        {
            get
            {
                return this.endCreationTimeField;
            }
            set
            {
                this.endCreationTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndCreationTimeSpecified
        {
            get
            {
                return this.endCreationTimeFieldSpecified;
            }
            set
            {
                this.endCreationTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaginationType Pagination
        {
            get
            {
                return this.paginationField;
            }
            set
            {
                this.paginationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string MemberMessageID
        {
            get
            {
                return this.memberMessageIDField;
            }
            set
            {
                this.memberMessageIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SenderID
        {
            get
            {
                return this.senderIDField;
            }
            set
            {
                this.senderIDField = value;
            }
        }
    }
