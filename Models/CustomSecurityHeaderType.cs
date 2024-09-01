    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class CustomSecurityHeaderType
    {
        
        private string eBayAuthTokenField;
        
        private string hardExpirationWarningField;
        
        private UserIdPasswordType credentialsField;
        
        private string notificationSignatureField;
        
        private System.Xml.XmlElement[] anyField;
        
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
        public string HardExpirationWarning
        {
            get
            {
                return this.hardExpirationWarningField;
            }
            set
            {
                this.hardExpirationWarningField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public UserIdPasswordType Credentials
        {
            get
            {
                return this.credentialsField;
            }
            set
            {
                this.credentialsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string NotificationSignature
        {
            get
            {
                return this.notificationSignatureField;
            }
            set
            {
                this.notificationSignatureField = value;
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
