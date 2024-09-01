    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetStoreRequestType : AbstractRequestType
    {
        
        private bool categoryStructureOnlyField;
        
        private bool categoryStructureOnlyFieldSpecified;
        
        private long rootCategoryIDField;
        
        private bool rootCategoryIDFieldSpecified;
        
        private int levelLimitField;
        
        private bool levelLimitFieldSpecified;
        
        private string userIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool CategoryStructureOnly
        {
            get
            {
                return this.categoryStructureOnlyField;
            }
            set
            {
                this.categoryStructureOnlyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CategoryStructureOnlySpecified
        {
            get
            {
                return this.categoryStructureOnlyFieldSpecified;
            }
            set
            {
                this.categoryStructureOnlyFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long RootCategoryID
        {
            get
            {
                return this.rootCategoryIDField;
            }
            set
            {
                this.rootCategoryIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RootCategoryIDSpecified
        {
            get
            {
                return this.rootCategoryIDFieldSpecified;
            }
            set
            {
                this.rootCategoryIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int LevelLimit
        {
            get
            {
                return this.levelLimitField;
            }
            set
            {
                this.levelLimitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LevelLimitSpecified
        {
            get
            {
                return this.levelLimitFieldSpecified;
            }
            set
            {
                this.levelLimitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string UserID
        {
            get
            {
                return this.userIDField;
            }
            set
            {
                this.userIDField = value;
            }
        }
    }
