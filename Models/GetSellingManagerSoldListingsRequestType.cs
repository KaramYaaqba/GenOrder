    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetSellingManagerSoldListingsRequestType : AbstractRequestType
    {
        
        private SellingManagerSearchType searchField;
        
        private long storeCategoryIDField;
        
        private bool storeCategoryIDFieldSpecified;
        
        private SellingManagerSoldListingsPropertyTypeCodeType[] filterField;
        
        private bool archivedField;
        
        private bool archivedFieldSpecified;
        
        private SellingManagerSoldListingsSortTypeCodeType sortField;
        
        private bool sortFieldSpecified;
        
        private SortOrderCodeType sortOrderField;
        
        private bool sortOrderFieldSpecified;
        
        private PaginationType paginationField;
        
        private TimeRangeType saleDateRangeField;
        
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
        public SellingManagerSoldListingsPropertyTypeCodeType[] Filter
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool Archived
        {
            get
            {
                return this.archivedField;
            }
            set
            {
                this.archivedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ArchivedSpecified
        {
            get
            {
                return this.archivedFieldSpecified;
            }
            set
            {
                this.archivedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingManagerSoldListingsSortTypeCodeType Sort
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
        public TimeRangeType SaleDateRange
        {
            get
            {
                return this.saleDateRangeField;
            }
            set
            {
                this.saleDateRangeField = value;
            }
        }
    }
