    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetTokenStatusResponseType : AbstractResponseType
    {
        
        private TokenStatusType tokenStatusField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public TokenStatusType TokenStatus
        {
            get
            {
                return this.tokenStatusField;
            }
            set
            {
                this.tokenStatusField = value;
            }
        }
    }
