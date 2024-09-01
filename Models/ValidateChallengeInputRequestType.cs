    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ValidateChallengeInputRequestType : AbstractRequestType
    {
        
        private string challengeTokenField;
        
        private string userInputField;
        
        private bool keepTokenValidField;
        
        private bool keepTokenValidFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ChallengeToken
        {
            get
            {
                return this.challengeTokenField;
            }
            set
            {
                this.challengeTokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string UserInput
        {
            get
            {
                return this.userInputField;
            }
            set
            {
                this.userInputField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool KeepTokenValid
        {
            get
            {
                return this.keepTokenValidField;
            }
            set
            {
                this.keepTokenValidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool KeepTokenValidSpecified
        {
            get
            {
                return this.keepTokenValidFieldSpecified;
            }
            set
            {
                this.keepTokenValidFieldSpecified = value;
            }
        }
    }
