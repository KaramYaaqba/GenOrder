    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class OfferType
    {
        
        private BidActionCodeType actionField;
        
        private bool actionFieldSpecified;
        
        private CurrencyCodeType currencyField;
        
        private bool currencyFieldSpecified;
        
        private string itemIDField;
        
        private AmountType maxBidField;
        
        private OfferDiscountsType discountsField;
        
        private int quantityField;
        
        private bool quantityFieldSpecified;
        
        private bool secondChanceEnabledField;
        
        private bool secondChanceEnabledFieldSpecified;
        
        private CurrencyCodeType siteCurrencyField;
        
        private bool siteCurrencyFieldSpecified;
        
        private System.DateTime timeBidField;
        
        private bool timeBidFieldSpecified;
        
        private AmountType highestBidField;
        
        private AmountType convertedPriceField;
        
        private string transactionIDField;
        
        private UserType userField;
        
        private bool userConsentField;
        
        private bool userConsentFieldSpecified;
        
        private int bidCountField;
        
        private bool bidCountFieldSpecified;
        
        private string messageField;
        
        private string bestOfferIDField;
        
        private AmountType myMaxBidField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public BidActionCodeType Action
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
        public AmountType MaxBid
        {
            get
            {
                return this.maxBidField;
            }
            set
            {
                this.maxBidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public OfferDiscountsType Discounts
        {
            get
            {
                return this.discountsField;
            }
            set
            {
                this.discountsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantitySpecified
        {
            get
            {
                return this.quantityFieldSpecified;
            }
            set
            {
                this.quantityFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool SecondChanceEnabled
        {
            get
            {
                return this.secondChanceEnabledField;
            }
            set
            {
                this.secondChanceEnabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SecondChanceEnabledSpecified
        {
            get
            {
                return this.secondChanceEnabledFieldSpecified;
            }
            set
            {
                this.secondChanceEnabledFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CurrencyCodeType SiteCurrency
        {
            get
            {
                return this.siteCurrencyField;
            }
            set
            {
                this.siteCurrencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SiteCurrencySpecified
        {
            get
            {
                return this.siteCurrencyFieldSpecified;
            }
            set
            {
                this.siteCurrencyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime TimeBid
        {
            get
            {
                return this.timeBidField;
            }
            set
            {
                this.timeBidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TimeBidSpecified
        {
            get
            {
                return this.timeBidFieldSpecified;
            }
            set
            {
                this.timeBidFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType HighestBid
        {
            get
            {
                return this.highestBidField;
            }
            set
            {
                this.highestBidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType ConvertedPrice
        {
            get
            {
                return this.convertedPriceField;
            }
            set
            {
                this.convertedPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string TransactionID
        {
            get
            {
                return this.transactionIDField;
            }
            set
            {
                this.transactionIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public UserType User
        {
            get
            {
                return this.userField;
            }
            set
            {
                this.userField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool UserConsent
        {
            get
            {
                return this.userConsentField;
            }
            set
            {
                this.userConsentField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UserConsentSpecified
        {
            get
            {
                return this.userConsentFieldSpecified;
            }
            set
            {
                this.userConsentFieldSpecified = value;
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
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string BestOfferID
        {
            get
            {
                return this.bestOfferIDField;
            }
            set
            {
                this.bestOfferIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType MyMaxBid
        {
            get
            {
                return this.myMaxBidField;
            }
            set
            {
                this.myMaxBidField = value;
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
