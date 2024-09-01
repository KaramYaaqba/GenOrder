    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class StoreCustomListingHeaderType
    {
        
        private StoreCustomListingHeaderDisplayCodeType displayTypeField;
        
        private bool displayTypeFieldSpecified;
        
        private bool logoField;
        
        private bool logoFieldSpecified;
        
        private bool searchBoxField;
        
        private bool searchBoxFieldSpecified;
        
        private StoreCustomListingHeaderLinkType[] linkToIncludeField;
        
        private bool addToFavoriteStoresField;
        
        private bool addToFavoriteStoresFieldSpecified;
        
        private bool signUpForStoreNewsletterField;
        
        private bool signUpForStoreNewsletterFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public StoreCustomListingHeaderDisplayCodeType DisplayType
        {
            get
            {
                return this.displayTypeField;
            }
            set
            {
                this.displayTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DisplayTypeSpecified
        {
            get
            {
                return this.displayTypeFieldSpecified;
            }
            set
            {
                this.displayTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool Logo
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LogoSpecified
        {
            get
            {
                return this.logoFieldSpecified;
            }
            set
            {
                this.logoFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool SearchBox
        {
            get
            {
                return this.searchBoxField;
            }
            set
            {
                this.searchBoxField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SearchBoxSpecified
        {
            get
            {
                return this.searchBoxFieldSpecified;
            }
            set
            {
                this.searchBoxFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LinkToInclude" )]
        public StoreCustomListingHeaderLinkType[] LinkToInclude
        {
            get
            {
                return this.linkToIncludeField;
            }
            set
            {
                this.linkToIncludeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool AddToFavoriteStores
        {
            get
            {
                return this.addToFavoriteStoresField;
            }
            set
            {
                this.addToFavoriteStoresField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AddToFavoriteStoresSpecified
        {
            get
            {
                return this.addToFavoriteStoresFieldSpecified;
            }
            set
            {
                this.addToFavoriteStoresFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool SignUpForStoreNewsletter
        {
            get
            {
                return this.signUpForStoreNewsletterField;
            }
            set
            {
                this.signUpForStoreNewsletterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SignUpForStoreNewsletterSpecified
        {
            get
            {
                return this.signUpForStoreNewsletterFieldSpecified;
            }
            set
            {
                this.signUpForStoreNewsletterFieldSpecified = value;
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
