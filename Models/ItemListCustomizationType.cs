    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class ItemListCustomizationType
    {
        
        private bool includeField;
        
        private bool includeFieldSpecified;
        
        private ListingTypeCodeType listingTypeField;
        
        private bool listingTypeFieldSpecified;
        
        private ItemSortTypeCodeType sortField;
        
        private bool sortFieldSpecified;
        
        private int durationInDaysField;
        
        private bool durationInDaysFieldSpecified;
        
        private bool includeNotesField;
        
        private bool includeNotesFieldSpecified;
        
        private PaginationType paginationField;
        
        private OrderStatusFilterCodeType orderStatusFilterField;
        
        private bool orderStatusFilterFieldSpecified;
        
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
        public ListingTypeCodeType ListingType
        {
            get
            {
                return this.listingTypeField;
            }
            set
            {
                this.listingTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ListingTypeSpecified
        {
            get
            {
                return this.listingTypeFieldSpecified;
            }
            set
            {
                this.listingTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemSortTypeCodeType Sort
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
        public int DurationInDays
        {
            get
            {
                return this.durationInDaysField;
            }
            set
            {
                this.durationInDaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DurationInDaysSpecified
        {
            get
            {
                return this.durationInDaysFieldSpecified;
            }
            set
            {
                this.durationInDaysFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IncludeNotes
        {
            get
            {
                return this.includeNotesField;
            }
            set
            {
                this.includeNotesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeNotesSpecified
        {
            get
            {
                return this.includeNotesFieldSpecified;
            }
            set
            {
                this.includeNotesFieldSpecified = value;
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
        public OrderStatusFilterCodeType OrderStatusFilter
        {
            get
            {
                return this.orderStatusFilterField;
            }
            set
            {
                this.orderStatusFilterField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrderStatusFilterSpecified
        {
            get
            {
                return this.orderStatusFilterFieldSpecified;
            }
            set
            {
                this.orderStatusFilterFieldSpecified = value;
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
