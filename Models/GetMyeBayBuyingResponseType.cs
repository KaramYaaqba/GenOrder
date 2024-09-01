    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetMyeBayBuyingResponseType : AbstractResponseType
    {
        
        private BuyingSummaryType buyingSummaryField;
        
        private PaginatedItemArrayType watchListField;
        
        private PaginatedItemArrayType bidListField;
        
        private PaginatedItemArrayType bestOfferListField;
        
        private PaginatedOrderTransactionArrayType wonListField;
        
        private PaginatedItemArrayType lostListField;
        
        private MyeBayFavoriteSearchListType favoriteSearchesField;
        
        private MyeBayFavoriteSellerListType favoriteSellersField;
        
        private ItemType[] secondChanceOfferField;
        
        private BidGroupType[] bidAssistantListField;
        
        private PaginatedOrderTransactionArrayType deletedFromWonListField;
        
        private PaginatedItemArrayType deletedFromLostListField;
        
        private UserDefinedListType[] userDefinedListField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public BuyingSummaryType BuyingSummary
        {
            get
            {
                return this.buyingSummaryField;
            }
            set
            {
                this.buyingSummaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaginatedItemArrayType WatchList
        {
            get
            {
                return this.watchListField;
            }
            set
            {
                this.watchListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaginatedItemArrayType BidList
        {
            get
            {
                return this.bidListField;
            }
            set
            {
                this.bidListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaginatedItemArrayType BestOfferList
        {
            get
            {
                return this.bestOfferListField;
            }
            set
            {
                this.bestOfferListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaginatedOrderTransactionArrayType WonList
        {
            get
            {
                return this.wonListField;
            }
            set
            {
                this.wonListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaginatedItemArrayType LostList
        {
            get
            {
                return this.lostListField;
            }
            set
            {
                this.lostListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MyeBayFavoriteSearchListType FavoriteSearches
        {
            get
            {
                return this.favoriteSearchesField;
            }
            set
            {
                this.favoriteSearchesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MyeBayFavoriteSellerListType FavoriteSellers
        {
            get
            {
                return this.favoriteSellersField;
            }
            set
            {
                this.favoriteSellersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SecondChanceOffer" )]
        public ItemType[] SecondChanceOffer
        {
            get
            {
                return this.secondChanceOfferField;
            }
            set
            {
                this.secondChanceOfferField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("BidGroup", IsNullable=false)]
        public BidGroupType[] BidAssistantList
        {
            get
            {
                return this.bidAssistantListField;
            }
            set
            {
                this.bidAssistantListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaginatedOrderTransactionArrayType DeletedFromWonList
        {
            get
            {
                return this.deletedFromWonListField;
            }
            set
            {
                this.deletedFromWonListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaginatedItemArrayType DeletedFromLostList
        {
            get
            {
                return this.deletedFromLostListField;
            }
            set
            {
                this.deletedFromLostListField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UserDefinedList" )]
        public UserDefinedListType[] UserDefinedList
        {
            get
            {
                return this.userDefinedListField;
            }
            set
            {
                this.userDefinedListField = value;
            }
        }
    }
