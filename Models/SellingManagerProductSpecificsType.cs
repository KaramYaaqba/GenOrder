    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellingManagerProductSpecificsType
    {
        
        private string primaryCategoryIDField;
        
        private VariationsType variationsField;
        
        private NameValueListType[] itemSpecificsField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string PrimaryCategoryID
        {
            get
            {
                return this.primaryCategoryIDField;
            }
            set
            {
                this.primaryCategoryIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public VariationsType Variations
        {
            get
            {
                return this.variationsField;
            }
            set
            {
                this.variationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("NameValueList", IsNullable=false)]
        public NameValueListType[] ItemSpecifics
        {
            get
            {
                return this.itemSpecificsField;
            }
            set
            {
                this.itemSpecificsField = value;
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
