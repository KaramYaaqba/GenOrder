    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ValidateChallengeInputResponseType : AbstractResponseType
    {
        
        private bool validTokenField;
        
        private bool validTokenFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ValidToken
        {
            get
            {
                return this.validTokenField;
            }
            set
            {
                this.validTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ValidTokenSpecified
        {
            get
            {
                return this.validTokenFieldSpecified;
            }
            set
            {
                this.validTokenFieldSpecified = value;
            }
        }
    }
