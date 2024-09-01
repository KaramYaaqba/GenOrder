    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class MaximumItemRequirementsDetailsType
    {
        
        private int[] maximumItemCountField;
        
        private int[] minimumFeedbackScoreField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaximumItemCount" )]
        public int[] MaximumItemCount
        {
            get
            {
                return this.maximumItemCountField;
            }
            set
            {
                this.maximumItemCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MinimumFeedbackScore" )]
        public int[] MinimumFeedbackScore
        {
            get
            {
                return this.minimumFeedbackScoreField;
            }
            set
            {
                this.minimumFeedbackScoreField = value;
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
