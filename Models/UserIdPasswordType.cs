    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class UserIdPasswordType
    {
        
        private string appIdField;
        
        private string devIdField;
        
        private string authCertField;
        
        private string usernameField;
        
        private string passwordField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string AppId
        {
            get
            {
                return this.appIdField;
            }
            set
            {
                this.appIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DevId
        {
            get
            {
                return this.devIdField;
            }
            set
            {
                this.devIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string AuthCert
        {
            get
            {
                return this.authCertField;
            }
            set
            {
                this.authCertField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Username
        {
            get
            {
                return this.usernameField;
            }
            set
            {
                this.usernameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Password
        {
            get
            {
                return this.passwordField;
            }
            set
            {
                this.passwordField = value;
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
