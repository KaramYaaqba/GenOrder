    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetAccountRequestType : AbstractRequestType
    {
        
        private AccountHistorySelectionCodeType accountHistorySelectionField;
        
        private bool accountHistorySelectionFieldSpecified;
        
        private System.DateTime invoiceDateField;
        
        private bool invoiceDateFieldSpecified;
        
        private System.DateTime beginDateField;
        
        private bool beginDateFieldSpecified;
        
        private System.DateTime endDateField;
        
        private bool endDateFieldSpecified;
        
        private PaginationType paginationField;
        
        private bool excludeBalanceField;
        
        private bool excludeBalanceFieldSpecified;
        
        private bool excludeSummaryField;
        
        private bool excludeSummaryFieldSpecified;
        
        private bool includeConversionRateField;
        
        private bool includeConversionRateFieldSpecified;
        
        private bool includeNettedEntriesField;
        
        private bool includeNettedEntriesFieldSpecified;
        
        private AccountEntrySortTypeCodeType accountEntrySortTypeField;
        
        private bool accountEntrySortTypeFieldSpecified;
        
        private CurrencyCodeType currencyField;
        
        private bool currencyFieldSpecified;
        
        private string itemIDField;
        
        private string orderIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AccountHistorySelectionCodeType AccountHistorySelection
        {
            get
            {
                return this.accountHistorySelectionField;
            }
            set
            {
                this.accountHistorySelectionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccountHistorySelectionSpecified
        {
            get
            {
                return this.accountHistorySelectionFieldSpecified;
            }
            set
            {
                this.accountHistorySelectionFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime InvoiceDate
        {
            get
            {
                return this.invoiceDateField;
            }
            set
            {
                this.invoiceDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InvoiceDateSpecified
        {
            get
            {
                return this.invoiceDateFieldSpecified;
            }
            set
            {
                this.invoiceDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime BeginDate
        {
            get
            {
                return this.beginDateField;
            }
            set
            {
                this.beginDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BeginDateSpecified
        {
            get
            {
                return this.beginDateFieldSpecified;
            }
            set
            {
                this.beginDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime EndDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EndDateSpecified
        {
            get
            {
                return this.endDateFieldSpecified;
            }
            set
            {
                this.endDateFieldSpecified = value;
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
        public bool ExcludeBalance
        {
            get
            {
                return this.excludeBalanceField;
            }
            set
            {
                this.excludeBalanceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExcludeBalanceSpecified
        {
            get
            {
                return this.excludeBalanceFieldSpecified;
            }
            set
            {
                this.excludeBalanceFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool ExcludeSummary
        {
            get
            {
                return this.excludeSummaryField;
            }
            set
            {
                this.excludeSummaryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ExcludeSummarySpecified
        {
            get
            {
                return this.excludeSummaryFieldSpecified;
            }
            set
            {
                this.excludeSummaryFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IncludeConversionRate
        {
            get
            {
                return this.includeConversionRateField;
            }
            set
            {
                this.includeConversionRateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeConversionRateSpecified
        {
            get
            {
                return this.includeConversionRateFieldSpecified;
            }
            set
            {
                this.includeConversionRateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool IncludeNettedEntries
        {
            get
            {
                return this.includeNettedEntriesField;
            }
            set
            {
                this.includeNettedEntriesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeNettedEntriesSpecified
        {
            get
            {
                return this.includeNettedEntriesFieldSpecified;
            }
            set
            {
                this.includeNettedEntriesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AccountEntrySortTypeCodeType AccountEntrySortType
        {
            get
            {
                return this.accountEntrySortTypeField;
            }
            set
            {
                this.accountEntrySortTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AccountEntrySortTypeSpecified
        {
            get
            {
                return this.accountEntrySortTypeFieldSpecified;
            }
            set
            {
                this.accountEntrySortTypeFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public CurrencyCodeType Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool CurrencySpecified
        {
            get
            {
                return this.currencyFieldSpecified;
            }
            set
            {
                this.currencyFieldSpecified = value;
            }
        }
        
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
        public string OrderID
        {
            get
            {
                return this.orderIDField;
            }
            set
            {
                this.orderIDField = value;
            }
        }
    }
