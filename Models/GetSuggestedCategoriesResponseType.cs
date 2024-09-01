    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetSuggestedCategoriesResponseType : AbstractResponseType
    {
        
        private SuggestedCategoryArrayType suggestedCategoryArrayField;
        
        private int categoryCountField;
        
        private bool categoryCountFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SuggestedCategoryArrayType SuggestedCategoryArray
        {
            get
            {
                return this.suggestedCategoryArrayField;
            }
            set
            {
                this.suggestedCategoryArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int CategoryCount
        {
            get
            {
                return this.categoryCountField;
            }
            set
            {
                this.categoryCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CategoryCountSpecified
        {
            get
            {
                return this.categoryCountFieldSpecified;
            }
            set
            {
                this.categoryCountFieldSpecified = value;
            }
        }
    }
