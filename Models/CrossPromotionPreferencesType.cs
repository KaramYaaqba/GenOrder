    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class CrossPromotionPreferencesType
    {
        
        private bool crossPromotionEnabledField;
        
        private bool crossPromotionEnabledFieldSpecified;
        
        private ItemFormatSortFilterCodeType crossSellItemFormatSortFilterField;
        
        private bool crossSellItemFormatSortFilterFieldSpecified;
        
        private GallerySortFilterCodeType crossSellGallerySortFilterField;
        
        private bool crossSellGallerySortFilterFieldSpecified;
        
        private ItemSortFilterCodeType crossSellItemSortFilterField;
        
        private bool crossSellItemSortFilterFieldSpecified;
        
        private ItemFormatSortFilterCodeType upSellItemFormatSortFilterField;
        
        private bool upSellItemFormatSortFilterFieldSpecified;
        
        private GallerySortFilterCodeType upSellGallerySortFilterField;
        
        private bool upSellGallerySortFilterFieldSpecified;
        
        private ItemSortFilterCodeType upSellItemSortFilterField;
        
        private bool upSellItemSortFilterFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool CrossPromotionEnabled
        {
            get
            {
                return this.crossPromotionEnabledField;
            }
            set
            {
                this.crossPromotionEnabledField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CrossPromotionEnabledSpecified
        {
            get
            {
                return this.crossPromotionEnabledFieldSpecified;
            }
            set
            {
                this.crossPromotionEnabledFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemFormatSortFilterCodeType CrossSellItemFormatSortFilter
        {
            get
            {
                return this.crossSellItemFormatSortFilterField;
            }
            set
            {
                this.crossSellItemFormatSortFilterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CrossSellItemFormatSortFilterSpecified
        {
            get
            {
                return this.crossSellItemFormatSortFilterFieldSpecified;
            }
            set
            {
                this.crossSellItemFormatSortFilterFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public GallerySortFilterCodeType CrossSellGallerySortFilter
        {
            get
            {
                return this.crossSellGallerySortFilterField;
            }
            set
            {
                this.crossSellGallerySortFilterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CrossSellGallerySortFilterSpecified
        {
            get
            {
                return this.crossSellGallerySortFilterFieldSpecified;
            }
            set
            {
                this.crossSellGallerySortFilterFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemSortFilterCodeType CrossSellItemSortFilter
        {
            get
            {
                return this.crossSellItemSortFilterField;
            }
            set
            {
                this.crossSellItemSortFilterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CrossSellItemSortFilterSpecified
        {
            get
            {
                return this.crossSellItemSortFilterFieldSpecified;
            }
            set
            {
                this.crossSellItemSortFilterFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemFormatSortFilterCodeType UpSellItemFormatSortFilter
        {
            get
            {
                return this.upSellItemFormatSortFilterField;
            }
            set
            {
                this.upSellItemFormatSortFilterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UpSellItemFormatSortFilterSpecified
        {
            get
            {
                return this.upSellItemFormatSortFilterFieldSpecified;
            }
            set
            {
                this.upSellItemFormatSortFilterFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public GallerySortFilterCodeType UpSellGallerySortFilter
        {
            get
            {
                return this.upSellGallerySortFilterField;
            }
            set
            {
                this.upSellGallerySortFilterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UpSellGallerySortFilterSpecified
        {
            get
            {
                return this.upSellGallerySortFilterFieldSpecified;
            }
            set
            {
                this.upSellGallerySortFilterFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemSortFilterCodeType UpSellItemSortFilter
        {
            get
            {
                return this.upSellItemSortFilterField;
            }
            set
            {
                this.upSellItemSortFilterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UpSellItemSortFilterSpecified
        {
            get
            {
                return this.upSellItemSortFilterFieldSpecified;
            }
            set
            {
                this.upSellItemSortFilterFieldSpecified = value;
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
