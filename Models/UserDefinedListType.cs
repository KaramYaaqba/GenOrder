    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class UserDefinedListType
    {
        
        private string nameField;
        
        private int itemCountField;
        
        private bool itemCountFieldSpecified;
        
        private int favoriteSearcheCountField;
        
        private bool favoriteSearcheCountFieldSpecified;
        
        private int favoriteSellerCountField;
        
        private bool favoriteSellerCountFieldSpecified;
        
        private ItemType[] itemArrayField;
        
        private MyeBayFavoriteSearchListType favoriteSearchesField;
        
        private MyeBayFavoriteSellerListType favoriteSellersField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
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
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int FavoriteSearcheCount
        {
            get
            {
                return this.favoriteSearcheCountField;
            }
            set
            {
                this.favoriteSearcheCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FavoriteSearcheCountSpecified
        {
            get
            {
                return this.favoriteSearcheCountFieldSpecified;
            }
            set
            {
                this.favoriteSearcheCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int FavoriteSellerCount
        {
            get
            {
                return this.favoriteSellerCountField;
            }
            set
            {
                this.favoriteSellerCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FavoriteSellerCountSpecified
        {
            get
            {
                return this.favoriteSellerCountFieldSpecified;
            }
            set
            {
                this.favoriteSellerCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("Item", IsNullable=false)]
        public ItemType[] ItemArray
        {
            get
            {
                return this.itemArrayField;
            }
            set
            {
                this.itemArrayField = value;
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
