    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetOrderTransactionsResponseType : AbstractResponseType
    {
        
        private OrderType[] orderArrayField;
        
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
    }
