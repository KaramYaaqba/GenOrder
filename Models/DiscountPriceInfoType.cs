    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class DiscountPriceInfoType
    {
        
        private AmountType originalRetailPriceField;
        
        private AmountType minimumAdvertisedPriceField;
        
        private MinimumAdvertisedPriceExposureCodeType minimumAdvertisedPriceExposureField;
        
        private bool minimumAdvertisedPriceExposureFieldSpecified;
        
        private PricingTreatmentCodeType pricingTreatmentField;
        
        private bool pricingTreatmentFieldSpecified;
        
        private bool soldOneBayField;
        
        private bool soldOffeBayField;
        
        private AmountType madeForOutletComparisonPriceField;
        
        private System.Xml.XmlElement[] anyField;
        
        public DiscountPriceInfoType()
        {
            this.soldOneBayField = false;
            this.soldOffeBayField = false;
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType OriginalRetailPrice
        {
            get
            {
                return this.originalRetailPriceField;
            }
            set
            {
                this.originalRetailPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType MinimumAdvertisedPrice
        {
            get
            {
                return this.minimumAdvertisedPriceField;
            }
            set
            {
                this.minimumAdvertisedPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MinimumAdvertisedPriceExposureCodeType MinimumAdvertisedPriceExposure
        {
            get
            {
                return this.minimumAdvertisedPriceExposureField;
            }
            set
            {
                this.minimumAdvertisedPriceExposureField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MinimumAdvertisedPriceExposureSpecified
        {
            get
            {
                return this.minimumAdvertisedPriceExposureFieldSpecified;
            }
            set
            {
                this.minimumAdvertisedPriceExposureFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PricingTreatmentCodeType PricingTreatment
        {
            get
            {
                return this.pricingTreatmentField;
            }
            set
            {
                this.pricingTreatmentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PricingTreatmentSpecified
        {
            get
            {
                return this.pricingTreatmentFieldSpecified;
            }
            set
            {
                this.pricingTreatmentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SoldOneBay
        {
            get
            {
                return this.soldOneBayField;
            }
            set
            {
                this.soldOneBayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool SoldOffeBay
        {
            get
            {
                return this.soldOffeBayField;
            }
            set
            {
                this.soldOffeBayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType MadeForOutletComparisonPrice
        {
            get
            {
                return this.madeForOutletComparisonPriceField;
            }
            set
            {
                this.madeForOutletComparisonPriceField = value;
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
