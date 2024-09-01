    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetAccountResponseType : AbstractResponseType
    {
        
        private string accountIDField;
        
        private FeenettingStatusCodeType feeNettingStatusField;
        
        private bool feeNettingStatusFieldSpecified;
        
        private AccountSummaryType accountSummaryField;
        
        private CurrencyCodeType currencyField;
        
        private bool currencyFieldSpecified;
        
        private AccountEntriesType accountEntriesField;
        
        private PaginationResultType paginationResultField;
        
        private bool hasMoreEntriesField;
        
        private bool hasMoreEntriesFieldSpecified;
        
        private int entriesPerPageField;
        
        private bool entriesPerPageFieldSpecified;
        
        private int pageNumberField;
        
        private bool pageNumberFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string AccountID
        {
            get
            {
                return this.accountIDField;
            }
            set
            {
                this.accountIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public FeenettingStatusCodeType FeeNettingStatus
        {
            get
            {
                return this.feeNettingStatusField;
            }
            set
            {
                this.feeNettingStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool FeeNettingStatusSpecified
        {
            get
            {
                return this.feeNettingStatusFieldSpecified;
            }
            set
            {
                this.feeNettingStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AccountSummaryType AccountSummary
        {
            get
            {
                return this.accountSummaryField;
            }
            set
            {
                this.accountSummaryField = value;
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
        public AccountEntriesType AccountEntries
        {
            get
            {
                return this.accountEntriesField;
            }
            set
            {
                this.accountEntriesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaginationResultType PaginationResult
        {
            get
            {
                return this.paginationResultField;
            }
            set
            {
                this.paginationResultField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool HasMoreEntries
        {
            get
            {
                return this.hasMoreEntriesField;
            }
            set
            {
                this.hasMoreEntriesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HasMoreEntriesSpecified
        {
            get
            {
                return this.hasMoreEntriesFieldSpecified;
            }
            set
            {
                this.hasMoreEntriesFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int EntriesPerPage
        {
            get
            {
                return this.entriesPerPageField;
            }
            set
            {
                this.entriesPerPageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool EntriesPerPageSpecified
        {
            get
            {
                return this.entriesPerPageFieldSpecified;
            }
            set
            {
                this.entriesPerPageFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int PageNumber
        {
            get
            {
                return this.pageNumberField;
            }
            set
            {
                this.pageNumberField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PageNumberSpecified
        {
            get
            {
                return this.pageNumberFieldSpecified;
            }
            set
            {
                this.pageNumberFieldSpecified = value;
            }
        }
    }
