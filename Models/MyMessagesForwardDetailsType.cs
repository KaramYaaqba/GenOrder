    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class MyMessagesForwardDetailsType
    {
        
        private System.DateTime userForwardDateField;
        
        private bool userForwardDateFieldSpecified;
        
        private string forwardMessageEncodingField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime UserForwardDate
        {
            get
            {
                return this.userForwardDateField;
            }
            set
            {
                this.userForwardDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserForwardDateSpecified
        {
            get
            {
                return this.userForwardDateFieldSpecified;
            }
            set
            {
                this.userForwardDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ForwardMessageEncoding
        {
            get
            {
                return this.forwardMessageEncodingField;
            }
            set
            {
                this.forwardMessageEncodingField = value;
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
