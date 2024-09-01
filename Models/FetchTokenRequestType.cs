    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class FetchTokenRequestType : AbstractRequestType
    {
        
        private string secretIDField;
        
        private string sessionIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SecretID
        {
            get
            {
                return this.secretIDField;
            }
            set
            {
                this.secretIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SessionID
        {
            get
            {
                return this.sessionIDField;
            }
            set
            {
                this.sessionIDField = value;
            }
        }
    }
