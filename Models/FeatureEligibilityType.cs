    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class FeatureEligibilityType
    {
        
        private bool qualifiesForBuyItNowField;
        
        private bool qualifiesForBuyItNowFieldSpecified;
        
        private bool qualifiesForBuyItNowMultipleField;
        
        private bool qualifiesForBuyItNowMultipleFieldSpecified;
        
        private bool qualifiedForFixedPriceOneDayDurationField;
        
        private bool qualifiedForFixedPriceOneDayDurationFieldSpecified;
        
        private bool qualifiesForVariationsField;
        
        private bool qualifiesForVariationsFieldSpecified;
        
        private bool qualifiedForAuctionOneDayDurationField;
        
        private bool qualifiedForAuctionOneDayDurationFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool QualifiesForBuyItNow
        {
            get
            {
                return this.qualifiesForBuyItNowField;
            }
            set
            {
                this.qualifiesForBuyItNowField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QualifiesForBuyItNowSpecified
        {
            get
            {
                return this.qualifiesForBuyItNowFieldSpecified;
            }
            set
            {
                this.qualifiesForBuyItNowFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool QualifiesForBuyItNowMultiple
        {
            get
            {
                return this.qualifiesForBuyItNowMultipleField;
            }
            set
            {
                this.qualifiesForBuyItNowMultipleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QualifiesForBuyItNowMultipleSpecified
        {
            get
            {
                return this.qualifiesForBuyItNowMultipleFieldSpecified;
            }
            set
            {
                this.qualifiesForBuyItNowMultipleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool QualifiedForFixedPriceOneDayDuration
        {
            get
            {
                return this.qualifiedForFixedPriceOneDayDurationField;
            }
            set
            {
                this.qualifiedForFixedPriceOneDayDurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QualifiedForFixedPriceOneDayDurationSpecified
        {
            get
            {
                return this.qualifiedForFixedPriceOneDayDurationFieldSpecified;
            }
            set
            {
                this.qualifiedForFixedPriceOneDayDurationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool QualifiesForVariations
        {
            get
            {
                return this.qualifiesForVariationsField;
            }
            set
            {
                this.qualifiesForVariationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QualifiesForVariationsSpecified
        {
            get
            {
                return this.qualifiesForVariationsFieldSpecified;
            }
            set
            {
                this.qualifiesForVariationsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool QualifiedForAuctionOneDayDuration
        {
            get
            {
                return this.qualifiedForAuctionOneDayDurationField;
            }
            set
            {
                this.qualifiedForAuctionOneDayDurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QualifiedForAuctionOneDayDurationSpecified
        {
            get
            {
                return this.qualifiedForAuctionOneDayDurationFieldSpecified;
            }
            set
            {
                this.qualifiedForAuctionOneDayDurationFieldSpecified = value;
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
