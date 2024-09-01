    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class CalculatedShippingRateType
    {
        
        private string originatingPostalCodeField;
        
        private MeasurementSystemCodeType measurementUnitField;
        
        private bool measurementUnitFieldSpecified;
        
        private AmountType packagingHandlingCostsField;
        
        private bool shippingIrregularField;
        
        private bool shippingIrregularFieldSpecified;
        
        private AmountType internationalPackagingHandlingCostsField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string OriginatingPostalCode
        {
            get
            {
                return this.originatingPostalCodeField;
            }
            set
            {
                this.originatingPostalCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MeasurementSystemCodeType MeasurementUnit
        {
            get
            {
                return this.measurementUnitField;
            }
            set
            {
                this.measurementUnitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MeasurementUnitSpecified
        {
            get
            {
                return this.measurementUnitFieldSpecified;
            }
            set
            {
                this.measurementUnitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType PackagingHandlingCosts
        {
            get
            {
                return this.packagingHandlingCostsField;
            }
            set
            {
                this.packagingHandlingCostsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ShippingIrregular
        {
            get
            {
                return this.shippingIrregularField;
            }
            set
            {
                this.shippingIrregularField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingIrregularSpecified
        {
            get
            {
                return this.shippingIrregularFieldSpecified;
            }
            set
            {
                this.shippingIrregularFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType InternationalPackagingHandlingCosts
        {
            get
            {
                return this.internationalPackagingHandlingCostsField;
            }
            set
            {
                this.internationalPackagingHandlingCostsField = value;
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
