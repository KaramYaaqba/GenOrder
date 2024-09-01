    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.2.0-preview1.23462.5")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ebay:apis:eBLBaseComponents")]
    public partial class AddSecondChanceItemRequestType : AbstractRequestType
    {
        
        private string recipientBidderUserIDField;
        
        private AmountType buyItNowPriceField;
        
        private SecondChanceOfferDurationCodeType durationField;
        
        private bool durationFieldSpecified;
        
        private string itemIDField;
        
        private string sellerMessageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public string RecipientBidderUserID
        {
            get
            {
                return this.recipientBidderUserIDField;
            }
            set
            {
                this.recipientBidderUserIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public AmountType BuyItNowPrice
        {
            get
            {
                return this.buyItNowPriceField;
            }
            set
            {
                this.buyItNowPriceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute( )]
        public SecondChanceOfferDurationCodeType Duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool DurationSpecified
        {
            get
            {
                return this.durationFieldSpecified;
            }
            set
            {
                this.durationFieldSpecified = value;
            }
        }
        
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
        public string SellerMessage
        {
            get
            {
                return this.sellerMessageField;
            }
            set
            {
                this.sellerMessageField = value;
            }
        }
    }
