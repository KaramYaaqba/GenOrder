    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellingManagerAutoRelistType
    {
        
        private SellingManagerAutoRelistTypeCodeType typeField;
        
        private bool typeFieldSpecified;
        
        private SellingManagerAutoRelistOptionCodeType relistConditionField;
        
        private bool relistConditionFieldSpecified;
        
        private int relistAfterDaysField;
        
        private bool relistAfterDaysFieldSpecified;
        
        private int relistAfterHoursField;
        
        private bool relistAfterHoursFieldSpecified;
        
        private System.DateTime relistAtSpecificTimeOfDayField;
        
        private bool relistAtSpecificTimeOfDayFieldSpecified;
        
        private BestOfferDetailsType bestOfferDetailsField;
        
        private int listingHoldInventoryLevelField;
        
        private bool listingHoldInventoryLevelFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerAutoRelistTypeCodeType Type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TypeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }
            set
            {
                this.typeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerAutoRelistOptionCodeType RelistCondition
        {
            get
            {
                return this.relistConditionField;
            }
            set
            {
                this.relistConditionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RelistConditionSpecified
        {
            get
            {
                return this.relistConditionFieldSpecified;
            }
            set
            {
                this.relistConditionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int RelistAfterDays
        {
            get
            {
                return this.relistAfterDaysField;
            }
            set
            {
                this.relistAfterDaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RelistAfterDaysSpecified
        {
            get
            {
                return this.relistAfterDaysFieldSpecified;
            }
            set
            {
                this.relistAfterDaysFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int RelistAfterHours
        {
            get
            {
                return this.relistAfterHoursField;
            }
            set
            {
                this.relistAfterHoursField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RelistAfterHoursSpecified
        {
            get
            {
                return this.relistAfterHoursFieldSpecified;
            }
            set
            {
                this.relistAfterHoursFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="time" )]
        public System.DateTime RelistAtSpecificTimeOfDay
        {
            get
            {
                return this.relistAtSpecificTimeOfDayField;
            }
            set
            {
                this.relistAtSpecificTimeOfDayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RelistAtSpecificTimeOfDaySpecified
        {
            get
            {
                return this.relistAtSpecificTimeOfDayFieldSpecified;
            }
            set
            {
                this.relistAtSpecificTimeOfDayFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public BestOfferDetailsType BestOfferDetails
        {
            get
            {
                return this.bestOfferDetailsField;
            }
            set
            {
                this.bestOfferDetailsField = value;
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
