    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RefundLineType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AmountType
    {
        
        private CurrencyCodeType currencyIDField;
        
        private double valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CurrencyCodeType currencyID
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
        [System.Xml.Serialization.XmlTextAttribute()]
        public double Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }
