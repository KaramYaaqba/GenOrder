    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetCategoriesRequestType : AbstractRequestType
    {
        
        private string categorySiteIDField;
        
        private string[] categoryParentField;
        
        private int levelLimitField;
        
        private bool levelLimitFieldSpecified;
        
        private bool viewAllNodesField;
        
        private bool viewAllNodesFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string CategorySiteID
        {
            get
            {
                return this.categorySiteIDField;
            }
            set
            {
                this.categorySiteIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CategoryParent" )]
        public string[] CategoryParent
        {
            get
            {
                return this.categoryParentField;
            }
            set
            {
                this.categoryParentField = value;
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
    }
