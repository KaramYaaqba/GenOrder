    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ShippingInsuranceType
    {
        
        private InsuranceOptionCodeType insuranceOptionField;
        
        private bool insuranceOptionFieldSpecified;
        
        private FlatRateInsuranceRangeCostType[] flatRateInsuranceRangeCostField;
        
        private System.Xml.XmlElement[] anyField;
        
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
        [System.Xml.Serialization.XmlElementAttribute("FlatRateInsuranceRangeCost" )]
        public FlatRateInsuranceRangeCostType[] FlatRateInsuranceRangeCost
        {
            get
            {
                return this.flatRateInsuranceRangeCostField;
            }
            set
            {
                this.flatRateInsuranceRangeCostField = value;
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
