    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ListingStartPriceDetailsType
    {
        
        private string descriptionField;
        
        private ListingTypeCodeType listingTypeField;
        
        private bool listingTypeFieldSpecified;
        
        private AmountType startPriceField;
        
        private string detailVersionField;
        
        private System.DateTime updateTimeField;
        
        private bool updateTimeFieldSpecified;
        
        private float minBuyItNowPricePercentField;
        
        private bool minBuyItNowPricePercentFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ListingTypeCodeType ListingType
        {
            get
            {
                return this.listingTypeField;
            }
            set
            {
                this.listingTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ListingTypeSpecified
        {
            get
            {
                return this.listingTypeFieldSpecified;
            }
            set
            {
                this.listingTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType StartPrice
        {
            get
            {
                return this.startPriceField;
            }
            set
            {
                this.startPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string DetailVersion
        {
            get
            {
                return this.detailVersionField;
            }
            set
            {
                this.detailVersionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime UpdateTime
        {
            get
            {
                return this.updateTimeField;
            }
            set
            {
                this.updateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UpdateTimeSpecified
        {
            get
            {
                return this.updateTimeFieldSpecified;
            }
            set
            {
                this.updateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public float MinBuyItNowPricePercent
        {
            get
            {
                return this.minBuyItNowPricePercentField;
            }
            set
            {
                this.minBuyItNowPricePercentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinBuyItNowPricePercentSpecified
        {
            get
            {
                return this.minBuyItNowPricePercentFieldSpecified;
            }
            set
            {
                this.minBuyItNowPricePercentFieldSpecified = value;
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
