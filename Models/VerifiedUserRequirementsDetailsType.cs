    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class VerifiedUserRequirementsDetailsType
    {
        
        private bool verifiedUserField;
        
        private bool verifiedUserFieldSpecified;
        
        private int[] feedbackScoreField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool VerifiedUser
        {
            get
            {
                return this.verifiedUserField;
            }
            set
            {
                this.verifiedUserField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool VerifiedUserSpecified
        {
            get
            {
                return this.verifiedUserFieldSpecified;
            }
            set
            {
                this.verifiedUserFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FeedbackScore" )]
        public int[] FeedbackScore
        {
            get
            {
                return this.feedbackScoreField;
            }
            set
            {
                this.feedbackScoreField = value;
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
