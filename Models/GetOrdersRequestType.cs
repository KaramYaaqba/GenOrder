    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetOrdersRequestType : AbstractRequestType
    {
        
        private string[] orderIDArrayField;
        
        private System.DateTime createTimeFromField;
        
        private bool createTimeFromFieldSpecified;
        
        private System.DateTime createTimeToField;
        
        private bool createTimeToFieldSpecified;
        
        private TradingRoleCodeType orderRoleField;
        
        private bool orderRoleFieldSpecified;
        
        private OrderStatusCodeType orderStatusField;
        
        private bool orderStatusFieldSpecified;
        
        private ListingTypeCodeType listingTypeField;
        
        private bool listingTypeFieldSpecified;
        
        private PaginationType paginationField;
        
        private System.DateTime modTimeFromField;
        
        private bool modTimeFromFieldSpecified;
        
        private System.DateTime modTimeToField;
        
        private bool modTimeToFieldSpecified;
        
        private int numberOfDaysField;
        
        private bool numberOfDaysFieldSpecified;
        
        private bool includeFinalValueFeeField;
        
        private bool includeFinalValueFeeFieldSpecified;
        
        private SortOrderCodeType sortingOrderField;
        
        private bool sortingOrderFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("OrderID", IsNullable=false)]
        public string[] OrderIDArray
        {
            get
            {
                return this.orderIDArrayField;
            }
            set
            {
                this.orderIDArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime CreateTimeFrom
        {
            get
            {
                return this.createTimeFromField;
            }
            set
            {
                this.createTimeFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreateTimeFromSpecified
        {
            get
            {
                return this.createTimeFromFieldSpecified;
            }
            set
            {
                this.createTimeFromFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime CreateTimeTo
        {
            get
            {
                return this.createTimeToField;
            }
            set
            {
                this.createTimeToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CreateTimeToSpecified
        {
            get
            {
                return this.createTimeToFieldSpecified;
            }
            set
            {
                this.createTimeToFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public TradingRoleCodeType OrderRole
        {
            get
            {
                return this.orderRoleField;
            }
            set
            {
                this.orderRoleField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrderRoleSpecified
        {
            get
            {
                return this.orderRoleFieldSpecified;
            }
            set
            {
                this.orderRoleFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public OrderStatusCodeType OrderStatus
        {
            get
            {
                return this.orderStatusField;
            }
            set
            {
                this.orderStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrderStatusSpecified
        {
            get
            {
                return this.orderStatusFieldSpecified;
            }
            set
            {
                this.orderStatusFieldSpecified = value;
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
        public System.DateTime ModTimeFrom
        {
            get
            {
                return this.modTimeFromField;
            }
            set
            {
                this.modTimeFromField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModTimeFromSpecified
        {
            get
            {
                return this.modTimeFromFieldSpecified;
            }
            set
            {
                this.modTimeFromFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime ModTimeTo
        {
            get
            {
                return this.modTimeToField;
            }
            set
            {
                this.modTimeToField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ModTimeToSpecified
        {
            get
            {
                return this.modTimeToFieldSpecified;
            }
            set
            {
                this.modTimeToFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int NumberOfDays
        {
            get
            {
                return this.numberOfDaysField;
            }
            set
            {
                this.numberOfDaysField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool NumberOfDaysSpecified
        {
            get
            {
                return this.numberOfDaysFieldSpecified;
            }
            set
            {
                this.numberOfDaysFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IncludeFinalValueFee
        {
            get
            {
                return this.includeFinalValueFeeField;
            }
            set
            {
                this.includeFinalValueFeeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeFinalValueFeeSpecified
        {
            get
            {
                return this.includeFinalValueFeeFieldSpecified;
            }
            set
            {
                this.includeFinalValueFeeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SortOrderCodeType SortingOrder
        {
            get
            {
                return this.sortingOrderField;
            }
            set
            {
                this.sortingOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool SortingOrderSpecified
        {
            get
            {
                return this.sortingOrderFieldSpecified;
            }
            set
            {
                this.sortingOrderFieldSpecified = value;
            }
        }
    }
