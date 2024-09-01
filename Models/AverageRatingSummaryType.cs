    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AverageRatingSummaryType
    {
        
        private FeedbackSummaryPeriodCodeType feedbackSummaryPeriodField;
        
        private bool feedbackSummaryPeriodFieldSpecified;
        
        private AverageRatingDetailsType[] averageRatingDetailsField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public FeedbackSummaryPeriodCodeType FeedbackSummaryPeriod
        {
            get
            {
                return this.feedbackSummaryPeriodField;
            }
            set
            {
                this.feedbackSummaryPeriodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FeedbackSummaryPeriodSpecified
        {
            get
            {
                return this.feedbackSummaryPeriodFieldSpecified;
            }
            set
            {
                this.feedbackSummaryPeriodFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AverageRatingDetails" )]
        public AverageRatingDetailsType[] AverageRatingDetails
        {
            get
            {
                return this.averageRatingDetailsField;
            }
            set
            {
                this.averageRatingDetailsField = value;
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
