    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class TokenStatusType
    {
        
        private TokenStatusCodeType statusField;
        
        private bool statusFieldSpecified;
        
        private string eIASTokenField;
        
        private System.DateTime expirationTimeField;
        
        private bool expirationTimeFieldSpecified;
        
        private System.DateTime revocationTimeField;
        
        private bool revocationTimeFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public TokenStatusCodeType Status
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
        public string EIASToken
        {
            get
            {
                return this.eIASTokenField;
            }
            set
            {
                this.eIASTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime ExpirationTime
        {
            get
            {
                return this.expirationTimeField;
            }
            set
            {
                this.expirationTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExpirationTimeSpecified
        {
            get
            {
                return this.expirationTimeFieldSpecified;
            }
            set
            {
                this.expirationTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime RevocationTime
        {
            get
            {
                return this.revocationTimeField;
            }
            set
            {
                this.revocationTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RevocationTimeSpecified
        {
            get
            {
                return this.revocationTimeFieldSpecified;
            }
            set
            {
                this.revocationTimeFieldSpecified = value;
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
