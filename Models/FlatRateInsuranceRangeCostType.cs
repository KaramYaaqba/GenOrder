    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class FlatRateInsuranceRangeCostType
    {
        
        private FlatRateInsuranceRangeCodeType flatRateInsuranceRangeField;
        
        private bool flatRateInsuranceRangeFieldSpecified;
        
        private AmountType insuranceCostField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public FlatRateInsuranceRangeCodeType FlatRateInsuranceRange
        {
            get
            {
                return this.flatRateInsuranceRangeField;
            }
            set
            {
                this.flatRateInsuranceRangeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FlatRateInsuranceRangeSpecified
        {
            get
            {
                return this.flatRateInsuranceRangeFieldSpecified;
            }
            set
            {
                this.flatRateInsuranceRangeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType InsuranceCost
        {
            get
            {
                return this.insuranceCostField;
            }
            set
            {
                this.insuranceCostField = value;
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
