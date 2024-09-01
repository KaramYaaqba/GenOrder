    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class CombinedPaymentPreferencesType
    {
        
        private CalculatedShippingPreferencesType calculatedShippingPreferencesField;
        
        private CombinedPaymentOptionCodeType combinedPaymentOptionField;
        
        private bool combinedPaymentOptionFieldSpecified;
        
        private CombinedPaymentPeriodCodeType combinedPaymentPeriodField;
        
        private bool combinedPaymentPeriodFieldSpecified;
        
        private FlatShippingPreferencesType flatShippingPreferencesField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CalculatedShippingPreferencesType CalculatedShippingPreferences
        {
            get
            {
                return this.calculatedShippingPreferencesField;
            }
            set
            {
                this.calculatedShippingPreferencesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CombinedPaymentOptionCodeType CombinedPaymentOption
        {
            get
            {
                return this.combinedPaymentOptionField;
            }
            set
            {
                this.combinedPaymentOptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CombinedPaymentOptionSpecified
        {
            get
            {
                return this.combinedPaymentOptionFieldSpecified;
            }
            set
            {
                this.combinedPaymentOptionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CombinedPaymentPeriodCodeType CombinedPaymentPeriod
        {
            get
            {
                return this.combinedPaymentPeriodField;
            }
            set
            {
                this.combinedPaymentPeriodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CombinedPaymentPeriodSpecified
        {
            get
            {
                return this.combinedPaymentPeriodFieldSpecified;
            }
            set
            {
                this.combinedPaymentPeriodFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public FlatShippingPreferencesType FlatShippingPreferences
        {
            get
            {
                return this.flatShippingPreferencesField;
            }
            set
            {
                this.flatShippingPreferencesField = value;
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
