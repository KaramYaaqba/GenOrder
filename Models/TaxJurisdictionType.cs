    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class TaxJurisdictionType
    {
        
        private string jurisdictionIDField;
        
        private float salesTaxPercentField;
        
        private bool salesTaxPercentFieldSpecified;
        
        private bool shippingIncludedInTaxField;
        
        private bool shippingIncludedInTaxFieldSpecified;
        
        private string jurisdictionNameField;
        
        private string detailVersionField;
        
        private System.DateTime updateTimeField;
        
        private bool updateTimeFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string JurisdictionID
        {
            get
            {
                return this.jurisdictionIDField;
            }
            set
            {
                this.jurisdictionIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public float SalesTaxPercent
        {
            get
            {
                return this.salesTaxPercentField;
            }
            set
            {
                this.salesTaxPercentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SalesTaxPercentSpecified
        {
            get
            {
                return this.salesTaxPercentFieldSpecified;
            }
            set
            {
                this.salesTaxPercentFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ShippingIncludedInTax
        {
            get
            {
                return this.shippingIncludedInTaxField;
            }
            set
            {
                this.shippingIncludedInTaxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ShippingIncludedInTaxSpecified
        {
            get
            {
                return this.shippingIncludedInTaxFieldSpecified;
            }
            set
            {
                this.shippingIncludedInTaxFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string JurisdictionName
        {
            get
            {
                return this.jurisdictionNameField;
            }
            set
            {
                this.jurisdictionNameField = value;
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
