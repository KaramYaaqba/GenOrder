    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class SellingManagerSearchType
    {
        
        private SellingManagerSearchTypeCodeType searchTypeField;
        
        private bool searchTypeFieldSpecified;
        
        private string searchValueField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerSearchTypeCodeType SearchType
        {
            get
            {
                return this.searchTypeField;
            }
            set
            {
                this.searchTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SearchTypeSpecified
        {
            get
            {
                return this.searchTypeFieldSpecified;
            }
            set
            {
                this.searchTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string SearchValue
        {
            get
            {
                return this.searchValueField;
            }
            set
            {
                this.searchValueField = value;
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
