    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetOrdersResponseType : AbstractResponseType
    {
        
        private PaginationResultType paginationResultField;
        
        private bool hasMoreOrdersField;
        
        private bool hasMoreOrdersFieldSpecified;
        
        private OrderType[] orderArrayField;
        
        private int ordersPerPageField;
        
        private bool ordersPerPageFieldSpecified;
        
        private int pageNumberField;
        
        private bool pageNumberFieldSpecified;
        
        private int returnedOrderCountActualField;
        
        private bool returnedOrderCountActualFieldSpecified;
        
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
        public bool HasMoreOrders
        {
            get
            {
                return this.hasMoreOrdersField;
            }
            set
            {
                this.hasMoreOrdersField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool HasMoreOrdersSpecified
        {
            get
            {
                return this.hasMoreOrdersFieldSpecified;
            }
            set
            {
                this.hasMoreOrdersFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("Order", IsNullable=false)]
        public OrderType[] OrderArray
        {
            get
            {
                return this.orderArrayField;
            }
            set
            {
                this.orderArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public int OrdersPerPage
        {
            get
            {
                return this.ordersPerPageField;
            }
            set
            {
                this.ordersPerPageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool OrdersPerPageSpecified
        {
            get
            {
                return this.ordersPerPageFieldSpecified;
            }
            set
            {
                this.ordersPerPageFieldSpecified = value;
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
        public int ReturnedOrderCountActual
        {
            get
            {
                return this.returnedOrderCountActualField;
            }
            set
            {
                this.returnedOrderCountActualField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ReturnedOrderCountActualSpecified
        {
            get
            {
                return this.returnedOrderCountActualFieldSpecified;
            }
            set
            {
                this.returnedOrderCountActualFieldSpecified = value;
            }
        }
    }
