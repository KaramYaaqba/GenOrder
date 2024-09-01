    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AverageRatingDetailsType
    {
        
        private FeedbackRatingDetailCodeType ratingDetailField;
        
        private bool ratingDetailFieldSpecified;
        
        private double ratingField;
        
        private bool ratingFieldSpecified;
        
        private int ratingCountField;
        
        private bool ratingCountFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public FeedbackRatingDetailCodeType RatingDetail
        {
            get
            {
                return this.ratingDetailField;
            }
            set
            {
                this.ratingDetailField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RatingDetailSpecified
        {
            get
            {
                return this.ratingDetailFieldSpecified;
            }
            set
            {
                this.ratingDetailFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public double Rating
        {
            get
            {
                return this.ratingField;
            }
            set
            {
                this.ratingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RatingSpecified
        {
            get
            {
                return this.ratingFieldSpecified;
            }
            set
            {
                this.ratingFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int RatingCount
        {
            get
            {
                return this.ratingCountField;
            }
            set
            {
                this.ratingCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RatingCountSpecified
        {
            get
            {
                return this.ratingCountFieldSpecified;
            }
            set
            {
                this.ratingCountFieldSpecified = value;
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
