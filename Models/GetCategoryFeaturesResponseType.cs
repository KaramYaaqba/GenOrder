    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetCategoryFeaturesResponseType : AbstractResponseType
    {
        
        private string categoryVersionField;
        
        private System.DateTime updateTimeField;
        
        private bool updateTimeFieldSpecified;
        
        private CategoryFeatureType[] categoryField;
        
        private SiteDefaultsType siteDefaultsField;
        
        private FeatureDefinitionsType featureDefinitionsField;
        
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime UpdateTime
        {
            get
            {
                return this.updateTimeField;
            }
            set
            {
                this.updateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool UpdateTimeSpecified
        {
            get
            {
                return this.updateTimeFieldSpecified;
            }
            set
            {
                this.updateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Category" )]
        public CategoryFeatureType[] Category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SiteDefaultsType SiteDefaults
        {
            get
            {
                return this.siteDefaultsField;
            }
            set
            {
                this.siteDefaultsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public FeatureDefinitionsType FeatureDefinitions
        {
            get
            {
                return this.featureDefinitionsField;
            }
            set
            {
                this.featureDefinitionsField = value;
            }
        }
    }
