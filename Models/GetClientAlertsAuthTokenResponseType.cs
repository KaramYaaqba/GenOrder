    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetClientAlertsAuthTokenResponseType : AbstractResponseType
    {
        
        private string clientAlertsAuthTokenField;
        
        private System.DateTime hardExpirationTimeField;
        
        private bool hardExpirationTimeFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ClientAlertsAuthToken
        {
            get
            {
                return this.clientAlertsAuthTokenField;
            }
            set
            {
                this.clientAlertsAuthTokenField = value;
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
    }
