    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ContextSearchAssetType
    {
        
        private string keywordField;
        
        private CategoryType categoryField;
        
        private int rankingField;
        
        private bool rankingFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string Keyword
        {
            get
            {
                return this.keywordField;
            }
            set
            {
                this.keywordField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CategoryType Category
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
        public int Ranking
        {
            get
            {
                return this.rankingField;
            }
            set
            {
                this.rankingField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RankingSpecified
        {
            get
            {
                return this.rankingFieldSpecified;
            }
            set
            {
                this.rankingFieldSpecified = value;
            }
        }
    }
