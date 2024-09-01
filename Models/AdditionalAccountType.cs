    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AdditionalAccountType
    {
        
        private AmountType balanceField;
        
        private CurrencyCodeType currencyField;
        
        private bool currencyFieldSpecified;
        
        private string accountCodeField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType Balance
        {
            get
            {
                return this.balanceField;
            }
            set
            {
                this.balanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CurrencyCodeType Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CurrencySpecified
        {
            get
            {
                return this.currencyFieldSpecified;
            }
            set
            {
                this.currencyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string AccountCode
        {
            get
            {
                return this.accountCodeField;
            }
            set
            {
                this.accountCodeField = value;
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
