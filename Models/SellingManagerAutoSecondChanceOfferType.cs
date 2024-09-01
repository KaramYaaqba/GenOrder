    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellingManagerAutoSecondChanceOfferType
    {
        
        private SellingManagerAutoSecondChanceOfferTypeCodeType secondChanceOfferConditionField;
        
        private bool secondChanceOfferConditionFieldSpecified;
        
        private AmountType amountField;
        
        private float profitPercentField;
        
        private bool profitPercentFieldSpecified;
        
        private SecondChanceOfferDurationCodeType durationField;
        
        private bool durationFieldSpecified;
        
        private int listingHoldInventoryLevelField;
        
        private bool listingHoldInventoryLevelFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerAutoSecondChanceOfferTypeCodeType SecondChanceOfferCondition
        {
            get
            {
                return this.secondChanceOfferConditionField;
            }
            set
            {
                this.secondChanceOfferConditionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SecondChanceOfferConditionSpecified
        {
            get
            {
                return this.secondChanceOfferConditionFieldSpecified;
            }
            set
            {
                this.secondChanceOfferConditionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType Amount
        {
            get
            {
                return this.amountField;
            }
            set
            {
                this.amountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public float ProfitPercent
        {
            get
            {
                return this.profitPercentField;
            }
            set
            {
                this.profitPercentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ProfitPercentSpecified
        {
            get
            {
                return this.profitPercentFieldSpecified;
            }
            set
            {
                this.profitPercentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SecondChanceOfferDurationCodeType Duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DurationSpecified
        {
            get
            {
                return this.durationFieldSpecified;
            }
            set
            {
                this.durationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int ListingHoldInventoryLevel
        {
            get
            {
                return this.listingHoldInventoryLevelField;
            }
            set
            {
                this.listingHoldInventoryLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ListingHoldInventoryLevelSpecified
        {
            get
            {
                return this.listingHoldInventoryLevelFieldSpecified;
            }
            set
            {
                this.listingHoldInventoryLevelFieldSpecified = value;
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
