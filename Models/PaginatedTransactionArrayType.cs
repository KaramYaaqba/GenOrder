    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class PaginatedTransactionArrayType
    {
        
        private TransactionType[] transactionArrayField;
        
        private PaginationResultType paginationResultField;
        
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
    }
