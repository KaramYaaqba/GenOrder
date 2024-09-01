    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetBestOffersRequestType : AbstractRequestType
    {
        
        private string itemIDField;
        
        private string bestOfferIDField;
        
        private BestOfferStatusCodeType bestOfferStatusField;
        
        private bool bestOfferStatusFieldSpecified;
        
        private PaginationType paginationField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string ItemID
        {
            get
            {
                return this.itemIDField;
            }
            set
            {
                this.itemIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string BestOfferID
        {
            get
            {
                return this.bestOfferIDField;
            }
            set
            {
                this.bestOfferIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public BestOfferStatusCodeType BestOfferStatus
        {
            get
            {
                return this.bestOfferStatusField;
            }
            set
            {
                this.bestOfferStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool BestOfferStatusSpecified
        {
            get
            {
                return this.bestOfferStatusFieldSpecified;
            }
            set
            {
                this.bestOfferStatusFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public PaginationType Pagination
        {
            get
            {
                return this.paginationField;
            }
            set
            {
                this.paginationField = value;
            }
        }
    }
