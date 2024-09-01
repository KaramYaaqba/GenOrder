    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetCategoryMappingsResponseType : AbstractResponseType
    {
        
        private CategoryMappingType[] categoryMappingField;
        
        private string categoryVersionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CategoryMapping" )]
        public CategoryMappingType[] CategoryMapping
        {
            get
            {
                return this.categoryMappingField;
            }
            set
            {
                this.categoryMappingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CategoryVersion
        {
            get
            {
                return this.categoryVersionField;
            }
            set
            {
                this.categoryVersionField = value;
            }
        }
    }
