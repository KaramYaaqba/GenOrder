    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class GetAllBiddersResponseType : AbstractResponseType
    {
        
        private OfferType[] bidArrayField;
        
        private string highBidderField;
        
        private AmountType highestBidField;
        
        private ListingStatusCodeType listingStatusField;
        
        private bool listingStatusFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute( )]
        [System.Xml.Serialization.XmlArrayItemAttribute("Offer", IsNullable=false)]
        public OfferType[] BidArray
        {
            get
            {
                return this.bidArrayField;
            }
            set
            {
                this.bidArrayField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string HighBidder
        {
            get
            {
                return this.highBidderField;
            }
            set
            {
                this.highBidderField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType HighestBid
        {
            get
            {
                return this.highestBidField;
            }
            set
            {
                this.highestBidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public ListingStatusCodeType ListingStatus
        {
            get
            {
                return this.listingStatusField;
            }
            set
            {
                this.listingStatusField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ListingStatusSpecified
        {
            get
            {
                return this.listingStatusFieldSpecified;
            }
            set
            {
                this.listingStatusFieldSpecified = value;
            }
        }
    }
