    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class FetchTokenResponseType : AbstractResponseType
    {
        
        private string eBayAuthTokenField;
        
        private System.DateTime hardExpirationTimeField;
        
        private bool hardExpirationTimeFieldSpecified;
        
        private string rESTTokenField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string eBayAuthToken
        {
            get
            {
                return this.eBayAuthTokenField;
            }
            set
            {
                this.eBayAuthTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime HardExpirationTime
        {
            get
            {
                return this.hardExpirationTimeField;
            }
            set
            {
                this.hardExpirationTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HardExpirationTimeSpecified
        {
            get
            {
                return this.hardExpirationTimeFieldSpecified;
            }
            set
            {
                this.hardExpirationTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string RESTToken
        {
            get
            {
                return this.rESTTokenField;
            }
            set
            {
                this.rESTTokenField = value;
            }
        }
    }
