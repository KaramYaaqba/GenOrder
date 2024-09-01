    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetSellingManagerInventoryRequestType : AbstractRequestType
    {
        
        private SellingManagerProductSortCodeType sortField;
        
        private bool sortFieldSpecified;
        
        private long folderIDField;
        
        private bool folderIDFieldSpecified;
        
        private PaginationType paginationField;
        
        private SortOrderCodeType sortOrderField;
        
        private bool sortOrderFieldSpecified;
        
        private SellingManagerSearchType searchField;
        
        private long storeCategoryIDField;
        
        private bool storeCategoryIDFieldSpecified;
        
        private SellingManagerInventoryPropertyTypeCodeType[] filterField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerProductSortCodeType Sort
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
        public long FolderID
        {
            get
            {
                return this.folderIDField;
            }
            set
            {
                this.folderIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FolderIDSpecified
        {
            get
            {
                return this.folderIDFieldSpecified;
            }
            set
            {
                this.folderIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaginationType Pagination
        {
            get
            {
                return this.paginationField;
            }
            set
            {
                this.paginationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SortOrderCodeType SortOrder
        {
            get
            {
                return this.sortOrderField;
            }
            set
            {
                this.sortOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SortOrderSpecified
        {
            get
            {
                return this.sortOrderFieldSpecified;
            }
            set
            {
                this.sortOrderFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerSearchType Search
        {
            get
            {
                return this.searchField;
            }
            set
            {
                this.searchField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public long StoreCategoryID
        {
            get
            {
                return this.storeCategoryIDField;
            }
            set
            {
                this.storeCategoryIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool StoreCategoryIDSpecified
        {
            get
            {
                return this.storeCategoryIDFieldSpecified;
            }
            set
            {
                this.storeCategoryIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Filter" )]
        public SellingManagerInventoryPropertyTypeCodeType[] Filter
        {
            get
            {
                return this.filterField;
            }
            set
            {
                this.filterField = value;
            }
        }
    }
