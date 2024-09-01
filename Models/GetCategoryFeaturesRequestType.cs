    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetCategoryFeaturesRequestType : AbstractRequestType
    {
        
        private string categoryIDField;
        
        private int levelLimitField;
        
        private bool levelLimitFieldSpecified;
        
        private bool viewAllNodesField;
        
        private bool viewAllNodesFieldSpecified;
        
        private FeatureIDCodeType[] featureIDField;
        
        private bool allFeaturesForCategoryField;
        
        private bool allFeaturesForCategoryFieldSpecified;
        
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
        public bool ViewAllNodes
        {
            get
            {
                return this.viewAllNodesField;
            }
            set
            {
                this.viewAllNodesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ViewAllNodesSpecified
        {
            get
            {
                return this.viewAllNodesFieldSpecified;
            }
            set
            {
                this.viewAllNodesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FeatureID" )]
        public FeatureIDCodeType[] FeatureID
        {
            get
            {
                return this.featureIDField;
            }
            set
            {
                this.featureIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool AllFeaturesForCategory
        {
            get
            {
                return this.allFeaturesForCategoryField;
            }
            set
            {
                this.allFeaturesForCategoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AllFeaturesForCategorySpecified
        {
            get
            {
                return this.allFeaturesForCategoryFieldSpecified;
            }
            set
            {
                this.allFeaturesForCategoryFieldSpecified = value;
            }
        }
    }
