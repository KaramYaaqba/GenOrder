    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class MyeBayFavoriteSearchType
    {
        
        private string searchNameField;
        
        private string searchQueryField;
        
        private string queryKeywordsField;
        
        private string categoryIDField;
        
        private SimpleItemSortCodeType itemSortField;
        
        private bool itemSortFieldSpecified;
        
        private SortOrderCodeType sortOrderField;
        
        private bool sortOrderFieldSpecified;
        
        private System.DateTime endTimeFromField;
        
        private bool endTimeFromFieldSpecified;
        
        private System.DateTime endTimeToField;
        
        private bool endTimeToFieldSpecified;
        
        private int maxDistanceField;
        
        private bool maxDistanceFieldSpecified;
        
        private string postalCodeField;
        
        private ItemTypeCodeType itemTypeField;
        
        private bool itemTypeFieldSpecified;
        
        private AmountType priceMaxField;
        
        private AmountType priceMinField;
        
        private CurrencyCodeType currencyField;
        
        private bool currencyFieldSpecified;
        
        private int bidCountMaxField;
        
        private bool bidCountMaxFieldSpecified;
        
        private int bidCountMinField;
        
        private bool bidCountMinFieldSpecified;
        
        private SearchFlagCodeType[] searchFlagField;
        
        private PaymentMethodSearchCodeType paymentMethodField;
        
        private bool paymentMethodFieldSpecified;
        
        private PreferredLocationCodeType preferredLocationField;
        
        private bool preferredLocationFieldSpecified;
        
        private string[] sellerIDField;
        
        private string[] sellerIDExcludeField;
        
        private CountryCodeType itemsAvailableToField;
        
        private bool itemsAvailableToFieldSpecified;
        
        private CountryCodeType itemsLocatedInField;
        
        private bool itemsLocatedInFieldSpecified;
        
        private SellerBusinessCodeType sellerBusinessTypeField;
        
        private bool sellerBusinessTypeFieldSpecified;
        
        private ItemConditionCodeType conditionField;
        
        private bool conditionFieldSpecified;
        
        private int quantityField;
        
        private bool quantityFieldSpecified;
        
        private QuantityOperatorCodeType quantityOperatorField;
        
        private bool quantityOperatorFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SearchName
        {
            get
            {
                return this.searchNameField;
            }
            set
            {
                this.searchNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SearchQuery
        {
            get
            {
                return this.searchQueryField;
            }
            set
            {
                this.searchQueryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string QueryKeywords
        {
            get
            {
                return this.queryKeywordsField;
            }
            set
            {
                this.queryKeywordsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CategoryID
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
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SimpleItemSortCodeType ItemSort
        {
            get
            {
                return this.itemSortField;
            }
            set
            {
                this.itemSortField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemSortSpecified
        {
            get
            {
                return this.itemSortFieldSpecified;
            }
            set
            {
                this.itemSortFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SortOrderCodeType SortOrder
        {
            get
            {
                return this.sortOrderField;
            }
            set
            {
                this.sortOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SortOrderSpecified
        {
            get
            {
                return this.sortOrderFieldSpecified;
            }
            set
            {
                this.sortOrderFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime EndTimeFrom
        {
            get
            {
                return this.endTimeFromField;
            }
            set
            {
                this.endTimeFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndTimeFromSpecified
        {
            get
            {
                return this.endTimeFromFieldSpecified;
            }
            set
            {
                this.endTimeFromFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime EndTimeTo
        {
            get
            {
                return this.endTimeToField;
            }
            set
            {
                this.endTimeToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndTimeToSpecified
        {
            get
            {
                return this.endTimeToFieldSpecified;
            }
            set
            {
                this.endTimeToFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MaxDistance
        {
            get
            {
                return this.maxDistanceField;
            }
            set
            {
                this.maxDistanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxDistanceSpecified
        {
            get
            {
                return this.maxDistanceFieldSpecified;
            }
            set
            {
                this.maxDistanceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemTypeCodeType ItemType
        {
            get
            {
                return this.itemTypeField;
            }
            set
            {
                this.itemTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemTypeSpecified
        {
            get
            {
                return this.itemTypeFieldSpecified;
            }
            set
            {
                this.itemTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType PriceMax
        {
            get
            {
                return this.priceMaxField;
            }
            set
            {
                this.priceMaxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType PriceMin
        {
            get
            {
                return this.priceMinField;
            }
            set
            {
                this.priceMinField = value;
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
        public int BidCountMax
        {
            get
            {
                return this.bidCountMaxField;
            }
            set
            {
                this.bidCountMaxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BidCountMaxSpecified
        {
            get
            {
                return this.bidCountMaxFieldSpecified;
            }
            set
            {
                this.bidCountMaxFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int BidCountMin
        {
            get
            {
                return this.bidCountMinField;
            }
            set
            {
                this.bidCountMinField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BidCountMinSpecified
        {
            get
            {
                return this.bidCountMinFieldSpecified;
            }
            set
            {
                this.bidCountMinFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SearchFlag" )]
        public SearchFlagCodeType[] SearchFlag
        {
            get
            {
                return this.searchFlagField;
            }
            set
            {
                this.searchFlagField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaymentMethodSearchCodeType PaymentMethod
        {
            get
            {
                return this.paymentMethodField;
            }
            set
            {
                this.paymentMethodField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PaymentMethodSpecified
        {
            get
            {
                return this.paymentMethodFieldSpecified;
            }
            set
            {
                this.paymentMethodFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PreferredLocationCodeType PreferredLocation
        {
            get
            {
                return this.preferredLocationField;
            }
            set
            {
                this.preferredLocationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PreferredLocationSpecified
        {
            get
            {
                return this.preferredLocationFieldSpecified;
            }
            set
            {
                this.preferredLocationFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SellerID" )]
        public string[] SellerID
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
        [System.Xml.Serialization.XmlElementAttribute("SellerIDExclude" )]
        public string[] SellerIDExclude
        {
            get
            {
                return this.sellerIDExcludeField;
            }
            set
            {
                this.sellerIDExcludeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CountryCodeType ItemsAvailableTo
        {
            get
            {
                return this.itemsAvailableToField;
            }
            set
            {
                this.itemsAvailableToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemsAvailableToSpecified
        {
            get
            {
                return this.itemsAvailableToFieldSpecified;
            }
            set
            {
                this.itemsAvailableToFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CountryCodeType ItemsLocatedIn
        {
            get
            {
                return this.itemsLocatedInField;
            }
            set
            {
                this.itemsLocatedInField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemsLocatedInSpecified
        {
            get
            {
                return this.itemsLocatedInFieldSpecified;
            }
            set
            {
                this.itemsLocatedInFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellerBusinessCodeType SellerBusinessType
        {
            get
            {
                return this.sellerBusinessTypeField;
            }
            set
            {
                this.sellerBusinessTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SellerBusinessTypeSpecified
        {
            get
            {
                return this.sellerBusinessTypeFieldSpecified;
            }
            set
            {
                this.sellerBusinessTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemConditionCodeType Condition
        {
            get
            {
                return this.conditionField;
            }
            set
            {
                this.conditionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ConditionSpecified
        {
            get
            {
                return this.conditionFieldSpecified;
            }
            set
            {
                this.conditionFieldSpecified = value;
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
        public QuantityOperatorCodeType QuantityOperator
        {
            get
            {
                return this.quantityOperatorField;
            }
            set
            {
                this.quantityOperatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QuantityOperatorSpecified
        {
            get
            {
                return this.quantityOperatorFieldSpecified;
            }
            set
            {
                this.quantityOperatorFieldSpecified = value;
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
