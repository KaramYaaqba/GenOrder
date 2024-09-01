    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetMyeBayBuyingRequestType : AbstractRequestType
    {
        
        private ItemListCustomizationType watchListField;
        
        private ItemListCustomizationType bidListField;
        
        private ItemListCustomizationType bestOfferListField;
        
        private ItemListCustomizationType wonListField;
        
        private ItemListCustomizationType lostListField;
        
        private MyeBaySelectionType favoriteSearchesField;
        
        private MyeBaySelectionType favoriteSellersField;
        
        private MyeBaySelectionType secondChanceOfferField;
        
        private BidAssistantListType bidAssistantListField;
        
        private ItemListCustomizationType deletedFromWonListField;
        
        private ItemListCustomizationType deletedFromLostListField;
        
        private ItemListCustomizationType buyingSummaryField;
        
        private MyeBaySelectionType userDefinedListsField;
        
        private bool hideVariationsField;
        
        private bool hideVariationsFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemListCustomizationType WatchList
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
        public ItemListCustomizationType BidList
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
        public ItemListCustomizationType BestOfferList
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
        public ItemListCustomizationType WonList
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
        public ItemListCustomizationType LostList
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
        public MyeBaySelectionType FavoriteSearches
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
        public MyeBaySelectionType FavoriteSellers
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
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MyeBaySelectionType SecondChanceOffer
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
        [System.Xml.Serialization.XmlElementAttribute( )]
        public BidAssistantListType BidAssistantList
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
        public ItemListCustomizationType DeletedFromWonList
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
        public ItemListCustomizationType DeletedFromLostList
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
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemListCustomizationType BuyingSummary
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
        public MyeBaySelectionType UserDefinedLists
        {
            get
            {
                return this.userDefinedListsField;
            }
            set
            {
                this.userDefinedListsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool HideVariations
        {
            get
            {
                return this.hideVariationsField;
            }
            set
            {
                this.hideVariationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HideVariationsSpecified
        {
            get
            {
                return this.hideVariationsFieldSpecified;
            }
            set
            {
                this.hideVariationsFieldSpecified = value;
            }
        }
    }
