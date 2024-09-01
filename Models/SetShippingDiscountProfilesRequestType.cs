    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SetShippingDiscountProfilesRequestType : AbstractRequestType
    {
        
        private CurrencyCodeType currencyIDField;
        
        private bool currencyIDFieldSpecified;
        
        private CombinedPaymentPeriodCodeType combinedDurationField;
        
        private bool combinedDurationFieldSpecified;
        
        private ModifyActionCodeType modifyActionCodeField;
        
        private bool modifyActionCodeFieldSpecified;
        
        private FlatShippingDiscountType flatShippingDiscountField;
        
        private CalculatedShippingDiscountType calculatedShippingDiscountField;
        
        private CalculatedHandlingDiscountType calculatedHandlingDiscountField;
        
        private PromotionalShippingDiscountDetailsType promotionalShippingDiscountDetailsField;
        
        private ShippingInsuranceType shippingInsuranceField;
        
        private ShippingInsuranceType internationalShippingInsuranceField;
        
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ModifyActionCodeType ModifyActionCode
        {
            get
            {
                return this.modifyActionCodeField;
            }
            set
            {
                this.modifyActionCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModifyActionCodeSpecified
        {
            get
            {
                return this.modifyActionCodeFieldSpecified;
            }
            set
            {
                this.modifyActionCodeFieldSpecified = value;
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
    }
