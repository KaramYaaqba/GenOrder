    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellerDiscountsType
    {
        
        private AmountType originalItemPriceField;
        
        private AmountType originalItemShippingCostField;
        
        private string originalShippingServiceField;
        
        private SellerDiscountType[] sellerDiscountField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType OriginalItemPrice
        {
            get
            {
                return this.originalItemPriceField;
            }
            set
            {
                this.originalItemPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType OriginalItemShippingCost
        {
            get
            {
                return this.originalItemShippingCostField;
            }
            set
            {
                this.originalItemShippingCostField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="token" )]
        public string OriginalShippingService
        {
            get
            {
                return this.originalShippingServiceField;
            }
            set
            {
                this.originalShippingServiceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SellerDiscount" )]
        public SellerDiscountType[] SellerDiscount
        {
            get
            {
                return this.sellerDiscountField;
            }
            set
            {
                this.sellerDiscountField = value;
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
