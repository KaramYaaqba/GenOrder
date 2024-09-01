    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetOrderTransactionsRequestType : AbstractRequestType
    {
        
        private ItemTransactionIDType[] itemTransactionIDArrayField;
        
        private string[] orderIDArrayField;
        
        private TransactionPlatformCodeType platformField;
        
        private bool platformFieldSpecified;
        
        private bool includeFinalValueFeesField;
        
        private bool includeFinalValueFeesFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("ItemTransactionID", IsNullable=false)]
        public ItemTransactionIDType[] ItemTransactionIDArray
        {
            get
            {
                return this.itemTransactionIDArrayField;
            }
            set
            {
                this.itemTransactionIDArrayField = value;
            }
        }
        
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
        public bool IncludeFinalValueFees
        {
            get
            {
                return this.includeFinalValueFeesField;
            }
            set
            {
                this.includeFinalValueFeesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool IncludeFinalValueFeesSpecified
        {
            get
            {
                return this.includeFinalValueFeesFieldSpecified;
            }
            set
            {
                this.includeFinalValueFeesFieldSpecified = value;
            }
        }
    }
