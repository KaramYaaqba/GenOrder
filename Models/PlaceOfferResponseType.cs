    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class PlaceOfferResponseType : AbstractResponseType
    {
        
        private SellingStatusType sellingStatusField;
        
        private string transactionIDField;
        
        private BestOfferType bestOfferField;
        
        private string orderLineItemIDField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SellingStatusType SellingStatus
        {
            get
            {
                return this.sellingStatusField;
            }
            set
            {
                this.sellingStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string TransactionID
        {
            get
            {
                return this.transactionIDField;
            }
            set
            {
                this.transactionIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public BestOfferType BestOffer
        {
            get
            {
                return this.bestOfferField;
            }
            set
            {
                this.bestOfferField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string OrderLineItemID
        {
            get
            {
                return this.orderLineItemIDField;
            }
            set
            {
                this.orderLineItemIDField = value;
            }
        }
    }
