    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class PromotionalShippingDiscountDetailsType
    {
        
        private DiscountNameCodeType discountNameField;
        
        private bool discountNameFieldSpecified;
        
        private AmountType shippingCostField;
        
        private AmountType orderAmountField;
        
        private int itemCountField;
        
        private bool itemCountFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public DiscountNameCodeType DiscountName
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
        public AmountType ShippingCost
        {
            get
            {
                return this.shippingCostField;
            }
            set
            {
                this.shippingCostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType OrderAmount
        {
            get
            {
                return this.orderAmountField;
            }
            set
            {
                this.orderAmountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int ItemCount
        {
            get
            {
                return this.itemCountField;
            }
            set
            {
                this.itemCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemCountSpecified
        {
            get
            {
                return this.itemCountFieldSpecified;
            }
            set
            {
                this.itemCountFieldSpecified = value;
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
