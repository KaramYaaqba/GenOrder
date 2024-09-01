    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellerFavoriteItemPreferencesType
    {
        
        private string searchKeywordsField;
        
        private long storeCategoryIDField;
        
        private bool storeCategoryIDFieldSpecified;
        
        private ListingTypeCodeType listingTypeField;
        
        private bool listingTypeFieldSpecified;
        
        private StoreItemListSortOrderCodeType searchSortOrderField;
        
        private bool searchSortOrderFieldSpecified;
        
        private AmountType minPriceField;
        
        private AmountType maxPriceField;
        
        private string[] favoriteItemIDField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SearchKeywords
        {
            get
            {
                return this.searchKeywordsField;
            }
            set
            {
                this.searchKeywordsField = value;
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
        public ListingTypeCodeType ListingType
        {
            get
            {
                return this.listingTypeField;
            }
            set
            {
                this.listingTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ListingTypeSpecified
        {
            get
            {
                return this.listingTypeFieldSpecified;
            }
            set
            {
                this.listingTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public StoreItemListSortOrderCodeType SearchSortOrder
        {
            get
            {
                return this.searchSortOrderField;
            }
            set
            {
                this.searchSortOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SearchSortOrderSpecified
        {
            get
            {
                return this.searchSortOrderFieldSpecified;
            }
            set
            {
                this.searchSortOrderFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType MinPrice
        {
            get
            {
                return this.minPriceField;
            }
            set
            {
                this.minPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType MaxPrice
        {
            get
            {
                return this.maxPriceField;
            }
            set
            {
                this.maxPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FavoriteItemID" )]
        public string[] FavoriteItemID
        {
            get
            {
                return this.favoriteItemIDField;
            }
            set
            {
                this.favoriteItemIDField = value;
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
