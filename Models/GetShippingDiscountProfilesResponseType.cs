    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetShippingDiscountProfilesResponseType : AbstractResponseType
    {
        
        private CurrencyCodeType currencyIDField;
        
        private bool currencyIDFieldSpecified;
        
        private FlatShippingDiscountType flatShippingDiscountField;
        
        private CalculatedShippingDiscountType calculatedShippingDiscountField;
        
        private bool promotionalShippingDiscountField;
        
        private bool promotionalShippingDiscountFieldSpecified;
        
        private CalculatedHandlingDiscountType calculatedHandlingDiscountField;
        
        private PromotionalShippingDiscountDetailsType promotionalShippingDiscountDetailsField;
        
        private ShippingInsuranceType shippingInsuranceField;
        
        private ShippingInsuranceType internationalShippingInsuranceField;
        
        private CombinedPaymentPeriodCodeType combinedDurationField;
        
        private bool combinedDurationFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CurrencyCodeType CurrencyID
        {
            get
            {
                return this.currencyIDField;
            }
            set
            {
                this.currencyIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CurrencyIDSpecified
        {
            get
            {
                return this.currencyIDFieldSpecified;
            }
            set
            {
                this.currencyIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public FlatShippingDiscountType FlatShippingDiscount
        {
            get
            {
                return this.flatShippingDiscountField;
            }
            set
            {
                this.flatShippingDiscountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CalculatedShippingDiscountType CalculatedShippingDiscount
        {
            get
            {
                return this.calculatedShippingDiscountField;
            }
            set
            {
                this.calculatedShippingDiscountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool PromotionalShippingDiscount
        {
            get
            {
                return this.promotionalShippingDiscountField;
            }
            set
            {
                this.promotionalShippingDiscountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PromotionalShippingDiscountSpecified
        {
            get
            {
                return this.promotionalShippingDiscountFieldSpecified;
            }
            set
            {
                this.promotionalShippingDiscountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CalculatedHandlingDiscountType CalculatedHandlingDiscount
        {
            get
            {
                return this.calculatedHandlingDiscountField;
            }
            set
            {
                this.calculatedHandlingDiscountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PromotionalShippingDiscountDetailsType PromotionalShippingDiscountDetails
        {
            get
            {
                return this.promotionalShippingDiscountDetailsField;
            }
            set
            {
                this.promotionalShippingDiscountDetailsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ShippingInsuranceType ShippingInsurance
        {
            get
            {
                return this.shippingInsuranceField;
            }
            set
            {
                this.shippingInsuranceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ShippingInsuranceType InternationalShippingInsurance
        {
            get
            {
                return this.internationalShippingInsuranceField;
            }
            set
            {
                this.internationalShippingInsuranceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CombinedPaymentPeriodCodeType CombinedDuration
        {
            get
            {
                return this.combinedDurationField;
            }
            set
            {
                this.combinedDurationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CombinedDurationSpecified
        {
            get
            {
                return this.combinedDurationFieldSpecified;
            }
            set
            {
                this.combinedDurationFieldSpecified = value;
            }
        }
    }
