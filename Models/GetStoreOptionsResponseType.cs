    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetStoreOptionsResponseType : AbstractResponseType
    {
        
        private StoreThemeArrayType basicThemeArrayField;
        
        private StoreThemeArrayType advancedThemeArrayField;
        
        private StoreLogoType[] logoArrayField;
        
        private StoreSubscriptionType[] subscriptionArrayField;
        
        private int maxCategoriesField;
        
        private bool maxCategoriesFieldSpecified;
        
        private int maxCategoryLevelsField;
        
        private bool maxCategoryLevelsFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public StoreThemeArrayType BasicThemeArray
        {
            get
            {
                return this.basicThemeArrayField;
            }
            set
            {
                this.basicThemeArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public StoreThemeArrayType AdvancedThemeArray
        {
            get
            {
                return this.advancedThemeArrayField;
            }
            set
            {
                this.advancedThemeArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("Logo", IsNullable=false)]
        public StoreLogoType[] LogoArray
        {
            get
            {
                return this.logoArrayField;
            }
            set
            {
                this.logoArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("Subscription", IsNullable=false)]
        public StoreSubscriptionType[] SubscriptionArray
        {
            get
            {
                return this.subscriptionArrayField;
            }
            set
            {
                this.subscriptionArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MaxCategories
        {
            get
            {
                return this.maxCategoriesField;
            }
            set
            {
                this.maxCategoriesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxCategoriesSpecified
        {
            get
            {
                return this.maxCategoriesFieldSpecified;
            }
            set
            {
                this.maxCategoriesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MaxCategoryLevels
        {
            get
            {
                return this.maxCategoryLevelsField;
            }
            set
            {
                this.maxCategoryLevelsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxCategoryLevelsSpecified
        {
            get
            {
                return this.maxCategoryLevelsFieldSpecified;
            }
            set
            {
                this.maxCategoryLevelsFieldSpecified = value;
            }
        }
    }
