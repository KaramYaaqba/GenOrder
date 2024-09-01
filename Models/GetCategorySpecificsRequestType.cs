    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetCategorySpecificsRequestType : AbstractRequestType
    {
        
        private string[] categoryIDField;
        
        private System.DateTime lastUpdateTimeField;
        
        private bool lastUpdateTimeFieldSpecified;
        
        private int maxNamesField;
        
        private bool maxNamesFieldSpecified;
        
        private int maxValuesPerNameField;
        
        private bool maxValuesPerNameFieldSpecified;
        
        private string nameField;
        
        private CategoryItemSpecificsType[] categorySpecificField;
        
        private bool excludeRelationshipsField;
        
        private bool excludeRelationshipsFieldSpecified;
        
        private bool includeConfidenceField;
        
        private bool includeConfidenceFieldSpecified;
        
        private bool categorySpecificsFileInfoField;
        
        private bool categorySpecificsFileInfoFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CategoryID" )]
        public string[] CategoryID
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
        public System.DateTime LastUpdateTime
        {
            get
            {
                return this.lastUpdateTimeField;
            }
            set
            {
                this.lastUpdateTimeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LastUpdateTimeSpecified
        {
            get
            {
                return this.lastUpdateTimeFieldSpecified;
            }
            set
            {
                this.lastUpdateTimeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MaxNames
        {
            get
            {
                return this.maxNamesField;
            }
            set
            {
                this.maxNamesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxNamesSpecified
        {
            get
            {
                return this.maxNamesFieldSpecified;
            }
            set
            {
                this.maxNamesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MaxValuesPerName
        {
            get
            {
                return this.maxValuesPerNameField;
            }
            set
            {
                this.maxValuesPerNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxValuesPerNameSpecified
        {
            get
            {
                return this.maxValuesPerNameFieldSpecified;
            }
            set
            {
                this.maxValuesPerNameFieldSpecified = value;
            }
        }
        
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
        [System.Xml.Serialization.XmlElementAttribute("CategorySpecific" )]
        public CategoryItemSpecificsType[] CategorySpecific
        {
            get
            {
                return this.categorySpecificField;
            }
            set
            {
                this.categorySpecificField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ExcludeRelationships
        {
            get
            {
                return this.excludeRelationshipsField;
            }
            set
            {
                this.excludeRelationshipsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExcludeRelationshipsSpecified
        {
            get
            {
                return this.excludeRelationshipsFieldSpecified;
            }
            set
            {
                this.excludeRelationshipsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IncludeConfidence
        {
            get
            {
                return this.includeConfidenceField;
            }
            set
            {
                this.includeConfidenceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeConfidenceSpecified
        {
            get
            {
                return this.includeConfidenceFieldSpecified;
            }
            set
            {
                this.includeConfidenceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool CategorySpecificsFileInfo
        {
            get
            {
                return this.categorySpecificsFileInfoField;
            }
            set
            {
                this.categorySpecificsFileInfoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CategorySpecificsFileInfoSpecified
        {
            get
            {
                return this.categorySpecificsFileInfoFieldSpecified;
            }
            set
            {
                this.categorySpecificsFileInfoFieldSpecified = value;
            }
        }
    }
