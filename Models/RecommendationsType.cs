    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class RecommendationsType
    {
        
        private string categoryIDField;
        
        private ProductIdentifiersType[] productIdentifiersField;
        
        private NameRecommendationType[] nameRecommendationField;
        
        private bool updatedField;
        
        private bool updatedFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CategoryID
        {
            get
            {
                return this.categoryIDField;
            }
            set
            {
                this.categoryIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductIdentifiers" )]
        public ProductIdentifiersType[] ProductIdentifiers
        {
            get
            {
                return this.productIdentifiersField;
            }
            set
            {
                this.productIdentifiersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NameRecommendation" )]
        public NameRecommendationType[] NameRecommendation
        {
            get
            {
                return this.nameRecommendationField;
            }
            set
            {
                this.nameRecommendationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool Updated
        {
            get
            {
                return this.updatedField;
            }
            set
            {
                this.updatedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UpdatedSpecified
        {
            get
            {
                return this.updatedFieldSpecified;
            }
            set
            {
                this.updatedFieldSpecified = value;
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
