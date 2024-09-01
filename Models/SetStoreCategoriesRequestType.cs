    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SetStoreCategoriesRequestType : AbstractRequestType
    {
        
        private StoreCategoryUpdateActionCodeType actionField;
        
        private bool actionFieldSpecified;
        
        private long itemDestinationCategoryIDField;
        
        private bool itemDestinationCategoryIDFieldSpecified;
        
        private long destinationParentCategoryIDField;
        
        private bool destinationParentCategoryIDFieldSpecified;
        
        private StoreCustomCategoryType[] storeCategoriesField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public StoreCategoryUpdateActionCodeType Action
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
        public long ItemDestinationCategoryID
        {
            get
            {
                return this.itemDestinationCategoryIDField;
            }
            set
            {
                this.itemDestinationCategoryIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemDestinationCategoryIDSpecified
        {
            get
            {
                return this.itemDestinationCategoryIDFieldSpecified;
            }
            set
            {
                this.itemDestinationCategoryIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long DestinationParentCategoryID
        {
            get
            {
                return this.destinationParentCategoryIDField;
            }
            set
            {
                this.destinationParentCategoryIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DestinationParentCategoryIDSpecified
        {
            get
            {
                return this.destinationParentCategoryIDFieldSpecified;
            }
            set
            {
                this.destinationParentCategoryIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("CustomCategory", IsNullable=false)]
        public StoreCustomCategoryType[] StoreCategories
        {
            get
            {
                return this.storeCategoriesField;
            }
            set
            {
                this.storeCategoriesField = value;
            }
        }
    }
