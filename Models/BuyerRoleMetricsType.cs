    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class BuyerRoleMetricsType
    {
        
        private int positiveFeedbackLeftCountField;
        
        private bool positiveFeedbackLeftCountFieldSpecified;
        
        private int negativeFeedbackLeftCountField;
        
        private bool negativeFeedbackLeftCountFieldSpecified;
        
        private int neutralFeedbackLeftCountField;
        
        private bool neutralFeedbackLeftCountFieldSpecified;
        
        private float feedbackLeftPercentField;
        
        private bool feedbackLeftPercentFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int PositiveFeedbackLeftCount
        {
            get
            {
                return this.positiveFeedbackLeftCountField;
            }
            set
            {
                this.positiveFeedbackLeftCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PositiveFeedbackLeftCountSpecified
        {
            get
            {
                return this.positiveFeedbackLeftCountFieldSpecified;
            }
            set
            {
                this.positiveFeedbackLeftCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int NegativeFeedbackLeftCount
        {
            get
            {
                return this.negativeFeedbackLeftCountField;
            }
            set
            {
                this.negativeFeedbackLeftCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NegativeFeedbackLeftCountSpecified
        {
            get
            {
                return this.negativeFeedbackLeftCountFieldSpecified;
            }
            set
            {
                this.negativeFeedbackLeftCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int NeutralFeedbackLeftCount
        {
            get
            {
                return this.neutralFeedbackLeftCountField;
            }
            set
            {
                this.neutralFeedbackLeftCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NeutralFeedbackLeftCountSpecified
        {
            get
            {
                return this.neutralFeedbackLeftCountFieldSpecified;
            }
            set
            {
                this.neutralFeedbackLeftCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public float FeedbackLeftPercent
        {
            get
            {
                return this.feedbackLeftPercentField;
            }
            set
            {
                this.feedbackLeftPercentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FeedbackLeftPercentSpecified
        {
            get
            {
                return this.feedbackLeftPercentFieldSpecified;
            }
            set
            {
                this.feedbackLeftPercentFieldSpecified = value;
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
