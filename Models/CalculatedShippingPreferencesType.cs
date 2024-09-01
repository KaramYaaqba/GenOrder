    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class CalculatedShippingPreferencesType
    {
        
        private AmountType calculatedShippingAmountForEntireOrderField;
        
        private CalculatedShippingChargeOptionCodeType calculatedShippingChargeOptionField;
        
        private bool calculatedShippingChargeOptionFieldSpecified;
        
        private CalculatedShippingRateOptionCodeType calculatedShippingRateOptionField;
        
        private bool calculatedShippingRateOptionFieldSpecified;
        
        private InsuranceOptionCodeType insuranceOptionField;
        
        private bool insuranceOptionFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType CalculatedShippingAmountForEntireOrder
        {
            get
            {
                return this.calculatedShippingAmountForEntireOrderField;
            }
            set
            {
                this.calculatedShippingAmountForEntireOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CalculatedShippingChargeOptionCodeType CalculatedShippingChargeOption
        {
            get
            {
                return this.calculatedShippingChargeOptionField;
            }
            set
            {
                this.calculatedShippingChargeOptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CalculatedShippingChargeOptionSpecified
        {
            get
            {
                return this.calculatedShippingChargeOptionFieldSpecified;
            }
            set
            {
                this.calculatedShippingChargeOptionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CalculatedShippingRateOptionCodeType CalculatedShippingRateOption
        {
            get
            {
                return this.calculatedShippingRateOptionField;
            }
            set
            {
                this.calculatedShippingRateOptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CalculatedShippingRateOptionSpecified
        {
            get
            {
                return this.calculatedShippingRateOptionFieldSpecified;
            }
            set
            {
                this.calculatedShippingRateOptionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public InsuranceOptionCodeType InsuranceOption
        {
            get
            {
                return this.insuranceOptionField;
            }
            set
            {
                this.insuranceOptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InsuranceOptionSpecified
        {
            get
            {
                return this.insuranceOptionFieldSpecified;
            }
            set
            {
                this.insuranceOptionFieldSpecified = value;
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
