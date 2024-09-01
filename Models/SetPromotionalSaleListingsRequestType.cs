    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SetPromotionalSaleListingsRequestType : AbstractRequestType
    {
        
        private long promotionalSaleIDField;
        
        private bool promotionalSaleIDFieldSpecified;
        
        private ModifyActionCodeType actionField;
        
        private bool actionFieldSpecified;
        
        private ItemIDArrayType promotionalSaleItemIDArrayField;
        
        private long storeCategoryIDField;
        
        private bool storeCategoryIDFieldSpecified;
        
        private long categoryIDField;
        
        private bool categoryIDFieldSpecified;
        
        private bool allFixedPriceItemsField;
        
        private bool allFixedPriceItemsFieldSpecified;
        
        private bool allStoreInventoryItemsField;
        
        private bool allStoreInventoryItemsFieldSpecified;
        
        private bool allAuctionItemsField;
        
        private bool allAuctionItemsFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long PromotionalSaleID
        {
            get
            {
                return this.promotionalSaleIDField;
            }
            set
            {
                this.promotionalSaleIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PromotionalSaleIDSpecified
        {
            get
            {
                return this.promotionalSaleIDFieldSpecified;
            }
            set
            {
                this.promotionalSaleIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ModifyActionCodeType Action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ActionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemIDArrayType PromotionalSaleItemIDArray
        {
            get
            {
                return this.promotionalSaleItemIDArrayField;
            }
            set
            {
                this.promotionalSaleItemIDArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long StoreCategoryID
        {
            get
            {
                return this.storeCategoryIDField;
            }
            set
            {
                this.storeCategoryIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StoreCategoryIDSpecified
        {
            get
            {
                return this.storeCategoryIDFieldSpecified;
            }
            set
            {
                this.storeCategoryIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long CategoryID
        {
            get
            {
                return this.categoryIDField;
            }
            set
            {
                this.categoryIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CategoryIDSpecified
        {
            get
            {
                return this.categoryIDFieldSpecified;
            }
            set
            {
                this.categoryIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool AllFixedPriceItems
        {
            get
            {
                return this.allFixedPriceItemsField;
            }
            set
            {
                this.allFixedPriceItemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AllFixedPriceItemsSpecified
        {
            get
            {
                return this.allFixedPriceItemsFieldSpecified;
            }
            set
            {
                this.allFixedPriceItemsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool AllStoreInventoryItems
        {
            get
            {
                return this.allStoreInventoryItemsField;
            }
            set
            {
                this.allStoreInventoryItemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AllStoreInventoryItemsSpecified
        {
            get
            {
                return this.allStoreInventoryItemsFieldSpecified;
            }
            set
            {
                this.allStoreInventoryItemsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool AllAuctionItems
        {
            get
            {
                return this.allAuctionItemsField;
            }
            set
            {
                this.allAuctionItemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AllAuctionItemsSpecified
        {
            get
            {
                return this.allAuctionItemsFieldSpecified;
            }
            set
            {
                this.allAuctionItemsFieldSpecified = value;
            }
        }
    }
