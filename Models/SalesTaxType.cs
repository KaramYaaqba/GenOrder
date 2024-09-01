    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SalesTaxType
    {
        
        private float salesTaxPercentField;
        
        private bool salesTaxPercentFieldSpecified;
        
        private string salesTaxStateField;
        
        private bool shippingIncludedInTaxField;
        
        private bool shippingIncludedInTaxFieldSpecified;
        
        private AmountType salesTaxAmountField;
        
        private System.Xml.XmlElement[] anyField;
        
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
        public string SalesTaxState
        {
            get
            {
                return this.salesTaxStateField;
            }
            set
            {
                this.salesTaxStateField = value;
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
        public AmountType SalesTaxAmount
        {
            get
            {
                return this.salesTaxAmountField;
            }
            set
            {
                this.salesTaxAmountField = value;
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
