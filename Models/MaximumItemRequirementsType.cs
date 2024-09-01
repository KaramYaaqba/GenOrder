    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class MaximumItemRequirementsType
    {
        
        private int maximumItemCountField;
        
        private bool maximumItemCountFieldSpecified;
        
        private int minimumFeedbackScoreField;
        
        private bool minimumFeedbackScoreFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MaximumItemCount
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaximumItemCountSpecified
        {
            get
            {
                return this.maximumItemCountFieldSpecified;
            }
            set
            {
                this.maximumItemCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MinimumFeedbackScore
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinimumFeedbackScoreSpecified
        {
            get
            {
                return this.minimumFeedbackScoreFieldSpecified;
            }
            set
            {
                this.minimumFeedbackScoreFieldSpecified = value;
            }
        }
    }
