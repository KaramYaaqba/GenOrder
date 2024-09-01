    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetSellingManagerSoldListingsResponseType : AbstractResponseType
    {
        
        private SellingManagerSoldOrderType[] saleRecordField;
        
        private PaginationResultType paginationResultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SaleRecord" )]
        public SellingManagerSoldOrderType[] SaleRecord
        {
            get
            {
                return this.saleRecordField;
            }
            set
            {
                this.saleRecordField = value;
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
