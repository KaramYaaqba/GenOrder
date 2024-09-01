    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ProductSuggestionType
    {
        
        private string titleField;
        
        private string ePIDField;
        
        private string stockPhotoField;
        
        private bool recommendedField;
        
        private bool recommendedFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Title
        {
            get
            {
                return this.titleField;
            }
            set
            {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string EPID
        {
            get
            {
                return this.ePIDField;
            }
            set
            {
                this.ePIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string StockPhoto
        {
            get
            {
                return this.stockPhotoField;
            }
            set
            {
                this.stockPhotoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool Recommended
        {
            get
            {
                return this.recommendedField;
            }
            set
            {
                this.recommendedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RecommendedSpecified
        {
            get
            {
                return this.recommendedFieldSpecified;
            }
            set
            {
                this.recommendedFieldSpecified = value;
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
