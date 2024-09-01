    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetItemTransactionsResponseType : AbstractResponseType
    {
        
        private PaginationResultType paginationResultField;
        
        private bool hasMoreTransactionsField;
        
        private bool hasMoreTransactionsFieldSpecified;
        
        private int transactionsPerPageField;
        
        private bool transactionsPerPageFieldSpecified;
        
        private int pageNumberField;
        
        private bool pageNumberFieldSpecified;
        
        private int returnedTransactionCountActualField;
        
        private bool returnedTransactionCountActualFieldSpecified;
        
        private ItemType itemField;
        
        private TransactionType[] transactionArrayField;
        
        private bool payPalPreferredField;
        
        private bool payPalPreferredFieldSpecified;
        
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
        public bool HasMoreTransactions
        {
            get
            {
                return this.hasMoreTransactionsField;
            }
            set
            {
                this.hasMoreTransactionsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HasMoreTransactionsSpecified
        {
            get
            {
                return this.hasMoreTransactionsFieldSpecified;
            }
            set
            {
                this.hasMoreTransactionsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int TransactionsPerPage
        {
            get
            {
                return this.transactionsPerPageField;
            }
            set
            {
                this.transactionsPerPageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool TransactionsPerPageSpecified
        {
            get
            {
                return this.transactionsPerPageFieldSpecified;
            }
            set
            {
                this.transactionsPerPageFieldSpecified = value;
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
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int ReturnedTransactionCountActual
        {
            get
            {
                return this.returnedTransactionCountActualField;
            }
            set
            {
                this.returnedTransactionCountActualField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnedTransactionCountActualSpecified
        {
            get
            {
                return this.returnedTransactionCountActualFieldSpecified;
            }
            set
            {
                this.returnedTransactionCountActualFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemType Item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("Transaction", IsNullable=false)]
        public TransactionType[] TransactionArray
        {
            get
            {
                return this.transactionArrayField;
            }
            set
            {
                this.transactionArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public bool PayPalPreferred
        {
            get
            {
                return this.payPalPreferredField;
            }
            set
            {
                this.payPalPreferredField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PayPalPreferredSpecified
        {
            get
            {
                return this.payPalPreferredFieldSpecified;
            }
            set
            {
                this.payPalPreferredFieldSpecified = value;
            }
        }
    }
