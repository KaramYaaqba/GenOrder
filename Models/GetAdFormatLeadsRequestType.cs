    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetAdFormatLeadsRequestType : AbstractRequestType
    {
        
        private string itemIDField;
        
        private MessageStatusTypeCodeType statusField;
        
        private bool statusFieldSpecified;
        
        private bool includeMemberMessagesField;
        
        private bool includeMemberMessagesFieldSpecified;
        
        private System.DateTime startCreationTimeField;
        
        private bool startCreationTimeFieldSpecified;
        
        private System.DateTime endCreationTimeField;
        
        private bool endCreationTimeFieldSpecified;
        
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
        public MessageStatusTypeCodeType Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StatusSpecified
        {
            get
            {
                return this.statusFieldSpecified;
            }
            set
            {
                this.statusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IncludeMemberMessages
        {
            get
            {
                return this.includeMemberMessagesField;
            }
            set
            {
                this.includeMemberMessagesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeMemberMessagesSpecified
        {
            get
            {
                return this.includeMemberMessagesFieldSpecified;
            }
            set
            {
                this.includeMemberMessagesFieldSpecified = value;
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
    }
