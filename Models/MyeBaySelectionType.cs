    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class MyeBaySelectionType
    {
        
        private bool includeField;
        
        private bool includeFieldSpecified;
        
        private bool includeItemCountField;
        
        private bool includeItemCountFieldSpecified;
        
        private bool includeFavoriteSearcheCountField;
        
        private bool includeFavoriteSearcheCountFieldSpecified;
        
        private bool includeFavoriteSellerCountField;
        
        private bool includeFavoriteSellerCountFieldSpecified;
        
        private SortOrderCodeType sortField;
        
        private bool sortFieldSpecified;
        
        private int maxResultsField;
        
        private bool maxResultsFieldSpecified;
        
        private string userDefinedListNameField;
        
        private bool includeListContentsField;
        
        private bool includeListContentsFieldSpecified;
        
        private System.Xml.XmlElement[] anyField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool Include
        {
            get
            {
                return this.includeField;
            }
            set
            {
                this.includeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeSpecified
        {
            get
            {
                return this.includeFieldSpecified;
            }
            set
            {
                this.includeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IncludeItemCount
        {
            get
            {
                return this.includeItemCountField;
            }
            set
            {
                this.includeItemCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeItemCountSpecified
        {
            get
            {
                return this.includeItemCountFieldSpecified;
            }
            set
            {
                this.includeItemCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IncludeFavoriteSearcheCount
        {
            get
            {
                return this.includeFavoriteSearcheCountField;
            }
            set
            {
                this.includeFavoriteSearcheCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeFavoriteSearcheCountSpecified
        {
            get
            {
                return this.includeFavoriteSearcheCountFieldSpecified;
            }
            set
            {
                this.includeFavoriteSearcheCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IncludeFavoriteSellerCount
        {
            get
            {
                return this.includeFavoriteSellerCountField;
            }
            set
            {
                this.includeFavoriteSellerCountField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeFavoriteSellerCountSpecified
        {
            get
            {
                return this.includeFavoriteSellerCountFieldSpecified;
            }
            set
            {
                this.includeFavoriteSellerCountFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SortOrderCodeType Sort
        {
            get
            {
                return this.sortField;
            }
            set
            {
                this.sortField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SortSpecified
        {
            get
            {
                return this.sortFieldSpecified;
            }
            set
            {
                this.sortFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int MaxResults
        {
            get
            {
                return this.maxResultsField;
            }
            set
            {
                this.maxResultsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool MaxResultsSpecified
        {
            get
            {
                return this.maxResultsFieldSpecified;
            }
            set
            {
                this.maxResultsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string UserDefinedListName
        {
            get
            {
                return this.userDefinedListNameField;
            }
            set
            {
                this.userDefinedListNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IncludeListContents
        {
            get
            {
                return this.includeListContentsField;
            }
            set
            {
                this.includeListContentsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeListContentsSpecified
        {
            get
            {
                return this.includeListContentsFieldSpecified;
            }
            set
            {
                this.includeListContentsFieldSpecified = value;
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
