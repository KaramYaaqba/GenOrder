    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetChallengeTokenResponseType : AbstractResponseType
    {
        
        private string challengeTokenField;
        
        private string imageChallengeURLField;
        
        private string audioChallengeURLField;
        
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
        public string ImageChallengeURL
        {
            get
            {
                return this.imageChallengeURLField;
            }
            set
            {
                this.imageChallengeURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string AudioChallengeURL
        {
            get
            {
                return this.audioChallengeURLField;
            }
            set
            {
                this.audioChallengeURLField = value;
            }
        }
    }
