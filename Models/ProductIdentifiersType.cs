    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ProductIdentifiersType
    {
        
        private GroupValidationRulesType validationRulesField;
        
        private NameRecommendationType[] nameRecommendationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public GroupValidationRulesType ValidationRules
        {
            get
            {
                return this.validationRulesField;
            }
            set
            {
                this.validationRulesField = value;
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
    }
