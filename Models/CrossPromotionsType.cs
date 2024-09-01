    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class CrossPromotionsType
    {
        
        private string itemIDField;
        
        private PromotionSchemeCodeType primarySchemeField;
        
        private bool primarySchemeFieldSpecified;
        
        private PromotionMethodCodeType promotionMethodField;
        
        private bool promotionMethodFieldSpecified;
        
        private string sellerIDField;
        
        private bool shippingDiscountField;
        
        private string storeNameField;
        
        private PromotedItemType[] promotedItemField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ItemID
        {
            get
            {
                return this.itemIDField;
            }
            set
            {
                this.itemIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PromotionSchemeCodeType PrimaryScheme
        {
            get
            {
                return this.primarySchemeField;
            }
            set
            {
                this.primarySchemeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PrimarySchemeSpecified
        {
            get
            {
                return this.primarySchemeFieldSpecified;
            }
            set
            {
                this.primarySchemeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PromotionMethodCodeType PromotionMethod
        {
            get
            {
                return this.promotionMethodField;
            }
            set
            {
                this.promotionMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PromotionMethodSpecified
        {
            get
            {
                return this.promotionMethodFieldSpecified;
            }
            set
            {
                this.promotionMethodFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SellerID
        {
            get
            {
                return this.sellerIDField;
            }
            set
            {
                this.sellerIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ShippingDiscount
        {
            get
            {
                return this.shippingDiscountField;
            }
            set
            {
                this.shippingDiscountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string StoreName
        {
            get
            {
                return this.storeNameField;
            }
            set
            {
                this.storeNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PromotedItem" )]
        public PromotedItemType[] PromotedItem
        {
            get
            {
                return this.promotedItemField;
            }
            set
            {
                this.promotedItemField = value;
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
