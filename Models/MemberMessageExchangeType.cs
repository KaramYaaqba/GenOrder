    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class MemberMessageExchangeType
    {
        
        private ItemType itemField;
        
        private MemberMessageType questionField;
        
        private string[] responseField;
        
        private MessageStatusTypeCodeType messageStatusField;
        
        private bool messageStatusFieldSpecified;
        
        private System.DateTime creationDateField;
        
        private bool creationDateFieldSpecified;
        
        private System.DateTime lastModifiedDateField;
        
        private bool lastModifiedDateFieldSpecified;
        
        private MessageMediaType[] messageMediaField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MemberMessageType Question
        {
            get
            {
                return this.questionField;
            }
            set
            {
                this.questionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Response" )]
        public string[] Response
        {
            get
            {
                return this.responseField;
            }
            set
            {
                this.responseField = value;
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
        public System.DateTime LastModifiedDate
        {
            get
            {
                return this.lastModifiedDateField;
            }
            set
            {
                this.lastModifiedDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastModifiedDateSpecified
        {
            get
            {
                return this.lastModifiedDateFieldSpecified;
            }
            set
            {
                this.lastModifiedDateFieldSpecified = value;
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
