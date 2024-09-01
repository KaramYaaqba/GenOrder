    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetSellerListResponseType : AbstractResponseType
    {
        
        private PaginationResultType paginationResultField;
        
        private bool hasMoreItemsField;
        
        private bool hasMoreItemsFieldSpecified;
        
        private ItemType[] itemArrayField;
        
        private int itemsPerPageField;
        
        private bool itemsPerPageFieldSpecified;
        
        private int pageNumberField;
        
        private bool pageNumberFieldSpecified;
        
        private int returnedItemCountActualField;
        
        private bool returnedItemCountActualFieldSpecified;
        
        private UserType sellerField;
        
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
        public bool HasMoreItems
        {
            get
            {
                return this.hasMoreItemsField;
            }
            set
            {
                this.hasMoreItemsField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HasMoreItemsSpecified
        {
            get
            {
                return this.hasMoreItemsFieldSpecified;
            }
            set
            {
                this.hasMoreItemsFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("Item", IsNullable=false)]
        public ItemType[] ItemArray
        {
            get
            {
                return this.itemArrayField;
            }
            set
            {
                this.itemArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int ItemsPerPage
        {
            get
            {
                return this.itemsPerPageField;
            }
            set
            {
                this.itemsPerPageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ItemsPerPageSpecified
        {
            get
            {
                return this.itemsPerPageFieldSpecified;
            }
            set
            {
                this.itemsPerPageFieldSpecified = value;
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
        public int ReturnedItemCountActual
        {
            get
            {
                return this.returnedItemCountActualField;
            }
            set
            {
                this.returnedItemCountActualField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnedItemCountActualSpecified
        {
            get
            {
                return this.returnedItemCountActualFieldSpecified;
            }
            set
            {
                this.returnedItemCountActualFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public UserType Seller
        {
            get
            {
                return this.sellerField;
            }
            set
            {
                this.sellerField = value;
            }
        }
    }
