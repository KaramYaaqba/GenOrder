    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetItemTransactionsRequestType : AbstractRequestType
    {
        
        private string itemIDField;
        
        private System.DateTime modTimeFromField;
        
        private bool modTimeFromFieldSpecified;
        
        private System.DateTime modTimeToField;
        
        private bool modTimeToFieldSpecified;
        
        private string transactionIDField;
        
        private PaginationType paginationField;
        
        private bool includeFinalValueFeeField;
        
        private bool includeFinalValueFeeFieldSpecified;
        
        private bool includeContainingOrderField;
        
        private bool includeContainingOrderFieldSpecified;
        
        private TransactionPlatformCodeType platformField;
        
        private bool platformFieldSpecified;
        
        private int numberOfDaysField;
        
        private bool numberOfDaysFieldSpecified;
        
        private bool includeVariationsField;
        
        private bool includeVariationsFieldSpecified;
        
        private string orderLineItemIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ItemID
        {
            get
            {
                return this.itemIDField;
            }
            set
            {
                this.itemIDField = value;
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
        public string TransactionID
        {
            get
            {
                return this.transactionIDField;
            }
            set
            {
                this.transactionIDField = value;
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
        public bool IncludeContainingOrder
        {
            get
            {
                return this.includeContainingOrderField;
            }
            set
            {
                this.includeContainingOrderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeContainingOrderSpecified
        {
            get
            {
                return this.includeContainingOrderFieldSpecified;
            }
            set
            {
                this.includeContainingOrderFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public TransactionPlatformCodeType Platform
        {
            get
            {
                return this.platformField;
            }
            set
            {
                this.platformField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PlatformSpecified
        {
            get
            {
                return this.platformFieldSpecified;
            }
            set
            {
                this.platformFieldSpecified = value;
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
        public bool IncludeVariations
        {
            get
            {
                return this.includeVariationsField;
            }
            set
            {
                this.includeVariationsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeVariationsSpecified
        {
            get
            {
                return this.includeVariationsFieldSpecified;
            }
            set
            {
                this.includeVariationsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string OrderLineItemID
        {
            get
            {
                return this.orderLineItemIDField;
            }
            set
            {
                this.orderLineItemIDField = value;
            }
        }
    }
