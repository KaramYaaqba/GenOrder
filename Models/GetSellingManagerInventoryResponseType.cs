    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetSellingManagerInventoryResponseType : AbstractResponseType
    {
        
        private System.DateTime inventoryCountLastCalculatedDateField;
        
        private bool inventoryCountLastCalculatedDateFieldSpecified;
        
        private SellingManagerProductType[] sellingManagerProductField;
        
        private PaginationResultType paginationResultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public System.DateTime InventoryCountLastCalculatedDate
        {
            get
            {
                return this.inventoryCountLastCalculatedDateField;
            }
            set
            {
                this.inventoryCountLastCalculatedDateField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InventoryCountLastCalculatedDateSpecified
        {
            get
            {
                return this.inventoryCountLastCalculatedDateFieldSpecified;
            }
            set
            {
                this.inventoryCountLastCalculatedDateFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SellingManagerProduct" )]
        public SellingManagerProductType[] SellingManagerProduct
        {
            get
            {
                return this.sellingManagerProductField;
            }
            set
            {
                this.sellingManagerProductField = value;
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
