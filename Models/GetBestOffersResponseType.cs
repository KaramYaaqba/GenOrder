    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetBestOffersResponseType : AbstractResponseType
    {
        
        private BestOfferType[] bestOfferArrayField;
        
        private ItemType itemField;
        
        private ItemBestOffersArrayType itemBestOffersArrayField;
        
        private int pageNumberField;
        
        private bool pageNumberFieldSpecified;
        
        private PaginationResultType paginationResultField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("BestOffer", IsNullable=false)]
        public BestOfferType[] BestOfferArray
        {
            get
            {
                return this.bestOfferArrayField;
            }
            set
            {
                this.bestOfferArrayField = value;
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
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ItemBestOffersArrayType ItemBestOffersArray
        {
            get
            {
                return this.itemBestOffersArrayField;
            }
            set
            {
                this.itemBestOffersArrayField = value;
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
