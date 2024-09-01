    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class PromotionDetailsType
    {
        
        private AmountType promotionPriceField;
        
        private PromotionItemPriceTypeCodeType promotionPriceTypeField;
        
        private bool promotionPriceTypeFieldSpecified;
        
        private int bidCountField;
        
        private bool bidCountFieldSpecified;
        
        private AmountType convertedPromotionPriceField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType PromotionPrice
        {
            get
            {
                return this.promotionPriceField;
            }
            set
            {
                this.promotionPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PromotionItemPriceTypeCodeType PromotionPriceType
        {
            get
            {
                return this.promotionPriceTypeField;
            }
            set
            {
                this.promotionPriceTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PromotionPriceTypeSpecified
        {
            get
            {
                return this.promotionPriceTypeFieldSpecified;
            }
            set
            {
                this.promotionPriceTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int BidCount
        {
            get
            {
                return this.bidCountField;
            }
            set
            {
                this.bidCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BidCountSpecified
        {
            get
            {
                return this.bidCountFieldSpecified;
            }
            set
            {
                this.bidCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType ConvertedPromotionPrice
        {
            get
            {
                return this.convertedPromotionPriceField;
            }
            set
            {
                this.convertedPromotionPriceField = value;
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
