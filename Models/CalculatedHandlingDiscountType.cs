    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class CalculatedHandlingDiscountType
    {
        
        private HandlingNameCodeType discountNameField;
        
        private bool discountNameFieldSpecified;
        
        private AmountType orderHandlingAmountField;
        
        private AmountType eachAdditionalAmountField;
        
        private AmountType eachAdditionalOffAmountField;
        
        private float eachAdditionalPercentOffField;
        
        private bool eachAdditionalPercentOffFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public HandlingNameCodeType DiscountName
        {
            get
            {
                return this.discountNameField;
            }
            set
            {
                this.discountNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DiscountNameSpecified
        {
            get
            {
                return this.discountNameFieldSpecified;
            }
            set
            {
                this.discountNameFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType OrderHandlingAmount
        {
            get
            {
                return this.orderHandlingAmountField;
            }
            set
            {
                this.orderHandlingAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType EachAdditionalAmount
        {
            get
            {
                return this.eachAdditionalAmountField;
            }
            set
            {
                this.eachAdditionalAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType EachAdditionalOffAmount
        {
            get
            {
                return this.eachAdditionalOffAmountField;
            }
            set
            {
                this.eachAdditionalOffAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public float EachAdditionalPercentOff
        {
            get
            {
                return this.eachAdditionalPercentOffField;
            }
            set
            {
                this.eachAdditionalPercentOffField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EachAdditionalPercentOffSpecified
        {
            get
            {
                return this.eachAdditionalPercentOffFieldSpecified;
            }
            set
            {
                this.eachAdditionalPercentOffFieldSpecified = value;
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
