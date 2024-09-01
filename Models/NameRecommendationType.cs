    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class NameRecommendationType
    {
        
        private string nameField;
        
        private RelevanceIndicatorType relevanceIndicatorField;
        
        private RecommendationValidationRulesType validationRulesField;
        
        private ValueRecommendationType[] valueRecommendationField;
        
        private string helpURLField;
        
        private ItemSpecificSourceCodeType sourceField;
        
        private bool sourceFieldSpecified;
        
        private string helpTextField;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public RelevanceIndicatorType RelevanceIndicator
        {
            get
            {
                return this.relevanceIndicatorField;
            }
            set
            {
                this.relevanceIndicatorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public RecommendationValidationRulesType ValidationRules
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
        [System.Xml.Serialization.XmlElementAttribute("ValueRecommendation" )]
        public ValueRecommendationType[] ValueRecommendation
        {
            get
            {
                return this.valueRecommendationField;
            }
            set
            {
                this.valueRecommendationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="anyURI" )]
        public string HelpURL
        {
            get
            {
                return this.helpURLField;
            }
            set
            {
                this.helpURLField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemSpecificSourceCodeType Source
        {
            get
            {
                return this.sourceField;
            }
            set
            {
                this.sourceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SourceSpecified
        {
            get
            {
                return this.sourceFieldSpecified;
            }
            set
            {
                this.sourceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string HelpText
        {
            get
            {
                return this.helpTextField;
            }
            set
            {
                this.helpTextField = value;
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
