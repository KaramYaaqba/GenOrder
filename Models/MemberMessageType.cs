    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class MemberMessageType
    {
        
        private MessageTypeCodeType messageTypeField;
        
        private bool messageTypeFieldSpecified;
        
        private QuestionTypeCodeType questionTypeField;
        
        private bool questionTypeFieldSpecified;
        
        private bool emailCopyToSenderField;
        
        private bool emailCopyToSenderFieldSpecified;
        
        private bool hideSendersEmailAddressField;
        
        private bool hideSendersEmailAddressFieldSpecified;
        
        private bool displayToPublicField;
        
        private bool displayToPublicFieldSpecified;
        
        private string senderIDField;
        
        private string senderEmailField;
        
        private string[] recipientIDField;
        
        private string subjectField;
        
        private string bodyField;
        
        private string messageIDField;
        
        private string parentMessageIDField;
        
        private MessageMediaType[] messageMediaField;
        
        private System.Xml.XmlElement[] anyField;
        
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
        public bool EmailCopyToSender
        {
            get
            {
                return this.emailCopyToSenderField;
            }
            set
            {
                this.emailCopyToSenderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EmailCopyToSenderSpecified
        {
            get
            {
                return this.emailCopyToSenderFieldSpecified;
            }
            set
            {
                this.emailCopyToSenderFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool HideSendersEmailAddress
        {
            get
            {
                return this.hideSendersEmailAddressField;
            }
            set
            {
                this.hideSendersEmailAddressField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HideSendersEmailAddressSpecified
        {
            get
            {
                return this.hideSendersEmailAddressFieldSpecified;
            }
            set
            {
                this.hideSendersEmailAddressFieldSpecified = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SenderEmail
        {
            get
            {
                return this.senderEmailField;
            }
            set
            {
                this.senderEmailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RecipientID" )]
        public string[] RecipientID
        {
            get
            {
                return this.recipientIDField;
            }
            set
            {
                this.recipientIDField = value;
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
        public string Body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
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
        public string ParentMessageID
        {
            get
            {
                return this.parentMessageIDField;
            }
            set
            {
                this.parentMessageIDField = value;
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
