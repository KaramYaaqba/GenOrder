    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class DisputeMessageType
    {
        
        private int messageIDField;
        
        private bool messageIDFieldSpecified;
        
        private DisputeMessageSourceCodeType messageSourceField;
        
        private bool messageSourceFieldSpecified;
        
        private System.DateTime messageCreationTimeField;
        
        private bool messageCreationTimeFieldSpecified;
        
        private string messageTextField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MessageID
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MessageIDSpecified
        {
            get
            {
                return this.messageIDFieldSpecified;
            }
            set
            {
                this.messageIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public DisputeMessageSourceCodeType MessageSource
        {
            get
            {
                return this.messageSourceField;
            }
            set
            {
                this.messageSourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MessageSourceSpecified
        {
            get
            {
                return this.messageSourceFieldSpecified;
            }
            set
            {
                this.messageSourceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime MessageCreationTime
        {
            get
            {
                return this.messageCreationTimeField;
            }
            set
            {
                this.messageCreationTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MessageCreationTimeSpecified
        {
            get
            {
                return this.messageCreationTimeFieldSpecified;
            }
            set
            {
                this.messageCreationTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string MessageText
        {
            get
            {
                return this.messageTextField;
            }
            set
            {
                this.messageTextField = value;
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
