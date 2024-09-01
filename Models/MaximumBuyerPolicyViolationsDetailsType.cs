    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class MaximumBuyerPolicyViolationsDetailsType
    {
        
        private NumberOfPolicyViolationsDetailsType numberOfPolicyViolationsField;
        
        private PolicyViolationDurationDetailsType[] policyViolationDurationField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public NumberOfPolicyViolationsDetailsType NumberOfPolicyViolations
        {
            get
            {
                return this.numberOfPolicyViolationsField;
            }
            set
            {
                this.numberOfPolicyViolationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PolicyViolationDuration" )]
        public PolicyViolationDurationDetailsType[] PolicyViolationDuration
        {
            get
            {
                return this.policyViolationDurationField;
            }
            set
            {
                this.policyViolationDurationField = value;
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
