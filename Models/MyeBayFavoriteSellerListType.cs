    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class MyeBayFavoriteSellerListType
    {
        
        private int totalAvailableField;
        
        private bool totalAvailableFieldSpecified;
        
        private MyeBayFavoriteSellerType[] favoriteSellerField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int TotalAvailable
        {
            get
            {
                return this.totalAvailableField;
            }
            set
            {
                this.totalAvailableField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TotalAvailableSpecified
        {
            get
            {
                return this.totalAvailableFieldSpecified;
            }
            set
            {
                this.totalAvailableFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FavoriteSeller" )]
        public MyeBayFavoriteSellerType[] FavoriteSeller
        {
            get
            {
                return this.favoriteSellerField;
            }
            set
            {
                this.favoriteSellerField = value;
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
