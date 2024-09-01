    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class StoreType
    {
        
        private string nameField;
        
        private string uRLPathField;
        
        private string uRLField;
        
        private StoreSubscriptionLevelCodeType subscriptionLevelField;
        
        private bool subscriptionLevelFieldSpecified;
        
        private string descriptionField;
        
        private StoreLogoType logoField;
        
        private StoreThemeType themeField;
        
        private StoreHeaderStyleCodeType headerStyleField;
        
        private bool headerStyleFieldSpecified;
        
        private long homePageField;
        
        private bool homePageFieldSpecified;
        
        private StoreItemListLayoutCodeType itemListLayoutField;
        
        private bool itemListLayoutFieldSpecified;
        
        private StoreItemListSortOrderCodeType itemListSortOrderField;
        
        private bool itemListSortOrderFieldSpecified;
        
        private StoreCustomHeaderLayoutCodeType customHeaderLayoutField;
        
        private bool customHeaderLayoutFieldSpecified;
        
        private string customHeaderField;
        
        private bool exportListingsField;
        
        private bool exportListingsFieldSpecified;
        
        private StoreCustomCategoryType[] customCategoriesField;
        
        private StoreCustomListingHeaderType customListingHeaderField;
        
        private MerchDisplayCodeType merchDisplayField;
        
        private bool merchDisplayFieldSpecified;
        
        private System.DateTime lastOpenedTimeField;
        
        private bool lastOpenedTimeFieldSpecified;
        
        private bool titleWithCompatibilityField;
        
        private bool titleWithCompatibilityFieldSpecified;
        
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
        public string URLPath
        {
            get
            {
                return this.uRLPathField;
            }
            set
            {
                this.uRLPathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI" )]
        public string URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public StoreSubscriptionLevelCodeType SubscriptionLevel
        {
            get
            {
                return this.subscriptionLevelField;
            }
            set
            {
                this.subscriptionLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SubscriptionLevelSpecified
        {
            get
            {
                return this.subscriptionLevelFieldSpecified;
            }
            set
            {
                this.subscriptionLevelFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public StoreLogoType Logo
        {
            get
            {
                return this.logoField;
            }
            set
            {
                this.logoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public StoreThemeType Theme
        {
            get
            {
                return this.themeField;
            }
            set
            {
                this.themeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public StoreHeaderStyleCodeType HeaderStyle
        {
            get
            {
                return this.headerStyleField;
            }
            set
            {
                this.headerStyleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HeaderStyleSpecified
        {
            get
            {
                return this.headerStyleFieldSpecified;
            }
            set
            {
                this.headerStyleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long HomePage
        {
            get
            {
                return this.homePageField;
            }
            set
            {
                this.homePageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HomePageSpecified
        {
            get
            {
                return this.homePageFieldSpecified;
            }
            set
            {
                this.homePageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public StoreItemListLayoutCodeType ItemListLayout
        {
            get
            {
                return this.itemListLayoutField;
            }
            set
            {
                this.itemListLayoutField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemListLayoutSpecified
        {
            get
            {
                return this.itemListLayoutFieldSpecified;
            }
            set
            {
                this.itemListLayoutFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public StoreItemListSortOrderCodeType ItemListSortOrder
        {
            get
            {
                return this.itemListSortOrderField;
            }
            set
            {
                this.itemListSortOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemListSortOrderSpecified
        {
            get
            {
                return this.itemListSortOrderFieldSpecified;
            }
            set
            {
                this.itemListSortOrderFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public StoreCustomHeaderLayoutCodeType CustomHeaderLayout
        {
            get
            {
                return this.customHeaderLayoutField;
            }
            set
            {
                this.customHeaderLayoutField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CustomHeaderLayoutSpecified
        {
            get
            {
                return this.customHeaderLayoutFieldSpecified;
            }
            set
            {
                this.customHeaderLayoutFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CustomHeader
        {
            get
            {
                return this.customHeaderField;
            }
            set
            {
                this.customHeaderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ExportListings
        {
            get
            {
                return this.exportListingsField;
            }
            set
            {
                this.exportListingsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExportListingsSpecified
        {
            get
            {
                return this.exportListingsFieldSpecified;
            }
            set
            {
                this.exportListingsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("CustomCategory", IsNullable=false)]
        public StoreCustomCategoryType[] CustomCategories
        {
            get
            {
                return this.customCategoriesField;
            }
            set
            {
                this.customCategoriesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public StoreCustomListingHeaderType CustomListingHeader
        {
            get
            {
                return this.customListingHeaderField;
            }
            set
            {
                this.customListingHeaderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public MerchDisplayCodeType MerchDisplay
        {
            get
            {
                return this.merchDisplayField;
            }
            set
            {
                this.merchDisplayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MerchDisplaySpecified
        {
            get
            {
                return this.merchDisplayFieldSpecified;
            }
            set
            {
                this.merchDisplayFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime LastOpenedTime
        {
            get
            {
                return this.lastOpenedTimeField;
            }
            set
            {
                this.lastOpenedTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastOpenedTimeSpecified
        {
            get
            {
                return this.lastOpenedTimeFieldSpecified;
            }
            set
            {
                this.lastOpenedTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool TitleWithCompatibility
        {
            get
            {
                return this.titleWithCompatibilityField;
            }
            set
            {
                this.titleWithCompatibilityField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TitleWithCompatibilitySpecified
        {
            get
            {
                return this.titleWithCompatibilityFieldSpecified;
            }
            set
            {
                this.titleWithCompatibilityFieldSpecified = value;
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
