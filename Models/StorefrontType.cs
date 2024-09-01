    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class StorefrontType
    {
        
        private long storeCategoryIDField;
        
        private long storeCategory2IDField;
        
        private string storeCategoryNameField;
        
        private string storeCategory2NameField;
        
        private string storeURLField;
        
        private string storeNameField;
        
        private System.Xml.XmlElement[] anyField;
        
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
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long StoreCategory2ID
        {
            get
            {
                return this.storeCategory2IDField;
            }
            set
            {
                this.storeCategory2IDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string StoreCategoryName
        {
            get
            {
                return this.storeCategoryNameField;
            }
            set
            {
                this.storeCategoryNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string StoreCategory2Name
        {
            get
            {
                return this.storeCategory2NameField;
            }
            set
            {
                this.storeCategory2NameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI" )]
        public string StoreURL
        {
            get
            {
                return this.storeURLField;
            }
            set
            {
                this.storeURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string StoreName
        {
            get
            {
                return this.storeNameField;
            }
            set
            {
                this.storeNameField = value;
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
